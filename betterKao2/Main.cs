using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betterKao2
{
    public partial class Main : Form
    {
        // initializing component, ignore
        public Main() { InitializeComponent(); }

        // top panel checkboxes
        bool skipIntroCheck = true; // skip intro
        bool fixWaterLevelsErrorCheck = true; // fix water levels error
        bool dontFreezeCheck = true; // don't freeze

        // imports
        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();

        // font collection
        PrivateFontCollection pfc = new PrivateFontCollection();

        // preloaded directory
        string kaoPreloadedDirectory = "";

        // runs on form load
        private void Main_Load(object sender, EventArgs e)
        {
            // load lato font
            AddFontFromMemory();

            // change label's font
            button_selectDirectory.Font = new Font(pfc.Families[0], 11.0f, FontStyle.Regular);
            label_patch.Font = new Font(pfc.Families[0], 11.0f, FontStyle.Regular);
            label_skipIntro.Font = new Font(pfc.Families[0], 11.0f, FontStyle.Regular);
            label_fixWaterError.Font = new Font(pfc.Families[0], 11.0f, FontStyle.Regular);
            label_dontFreeze.Font = new Font(pfc.Families[0], 11.0f, FontStyle.Regular);
            label_title.Font = new Font(pfc.Families[0], 11.0f, FontStyle.Regular);
            label_version.Font = new Font(pfc.Families[0], 7.0f, FontStyle.Regular);

            // check default locations for kao2
            if (File.Exists(@"C:\Program Files (x86)\Steam\steamapps\common\Kao the Kangaroo Round 2\kao2.exe"))
            /* steam */ kaoPreloadedDirectory = @"C:\Program Files (x86)\Steam\steamapps\common\Kao the Kangaroo Round 2";

            else if (File.Exists(@"C:\Program Files\Epic Games\KaotheKangarooRound2o7FCt\kao2.exe"))
            /* epic games */ kaoPreloadedDirectory = @"C:\Program Files\Epic Games\KaotheKangarooRound2o7FCt";

            else if (File.Exists(@"C:\Program Files (x86)\GOG Galaxy\Games\Kao the Kangaroo Round 2\kao2.exe"))
            /* gog */ kaoPreloadedDirectory = @"C:\Program Files (x86)\GOG Galaxy\Games\Kao the Kangaroo Round 2";

            else if (File.Exists(@"C:\ZOOM PLATFORM\Tate Multimedia\Kao the Kangaroo - Complete Kaollection\Kao the Kangaroo - Round 2\kao2.exe"))
            /* zoom */ kaoPreloadedDirectory = @"C:\ZOOM PLATFORM\Tate Multimedia\Kao the Kangaroo - Complete Kaollection\Kao the Kangaroo - Round 2";

            // apply if found
            if (kaoPreloadedDirectory != "") label_directory.Text = kaoPreloadedDirectory;
        }

        // patch byte variable
        byte[] LocalPatch(byte[] toPatch, string toFind, string toReplace)
        {
            // amount of successful bytes found, like 8B or CF, if all of them found
            // meaning it exceeds certain number then we found address of signature
            int foundBytes = 0;

            // we are splitting signature to bytes in string array
            string[] explodedToFind = toFind.Split(' ');
            string[] explodedToReplace = toReplace.Split(' ');

            // arrays of bytes that will hold signatures
            byte[] byteArrayToFind = new byte[explodedToFind.Length];
            byte[] byteArrayToReplace = new byte[explodedToReplace.Length];

            // mask can have either "?" or "x" type of characters, if it's "?" it means we skip this byte and
            // act like we found it, where for "x" the byte actually has to match, it's used for signatures
            // where some bytes inside might be changing per game session and we want to skip them
            // mask will look like this "xxxxxxxxxx?xxx?"
            string maskToFind = "";

            // converting string byte array to just normal byte array
            for (int i = 0; i < byteArrayToFind.Length; i++)
            {
                if (explodedToFind[i] != "??") byteArrayToFind[i] = byte.Parse(explodedToFind[i], System.Globalization.NumberStyles.HexNumber);
                else byteArrayToFind[i] = 0; // doesn't matter if it's 0 because mask will make it skip this byte anyway
            }

            // converting string byte array to just normal byte array
            for (int i = 0; i < byteArrayToReplace.Length; i++)
            {
                if (explodedToReplace[i] != "??") byteArrayToReplace[i] = byte.Parse(explodedToReplace[i], System.Globalization.NumberStyles.HexNumber);
                else byteArrayToReplace[i] = 0; // doesn't matter if it's 0 because mask will make it skip this byte anyway
            }

            // creating mask based on provided signatures and question marks instead of bytes
            // for full explanation read above initialization of "mask" variable 
            foreach (string character in explodedToFind)
            {
                if (character != "??") maskToFind += "x";
                else maskToFind += "?";
            }

            // go through the file bytes
            for (int i = 0; i < toPatch.Length; i++)
            {
                // we don't skip the byte and act like we found it if mask doesn't say so
                if (maskToFind[foundBytes] != '?')
                {
                    if (toPatch[i] == byteArrayToFind[foundBytes])
                        foundBytes += 1;

                    // we reset to 0 because if found signature breaks it's no longer the signature we're looking for
                    else foundBytes = 0;

                    // found match!
                    if (foundBytes == byteArrayToFind.Length)
                    {
                        // replace bytes
                        int startIndex = i - byteArrayToFind.Length + 1;
                        foreach (byte value in byteArrayToReplace)
                        {
                            toPatch[startIndex] = value;
                            startIndex += 1;
                        }

                        // leave loop if patched
                        break;
                    }
                }
            }

            // return patched byte array
            return toPatch;
        }

        // gets file checksum in MD5
        static string GetFileChecksum(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        // move form with mouse
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        // load font from resources
        private void AddFontFromMemory()
        {
            byte[] fontdata = Properties.Resources.Lato_Regular;
            unsafe { fixed (byte* pFontData = fontdata) pfc.AddMemoryFont((IntPtr)pFontData, fontdata.Length); }
        }

        // patches game file with selected options
        private void Patch()
        {
            // check if directory selected
            if (label_directory.Text != "")
            {
                // kao2.exe file path
                string kao2ExePath = Path.Combine(label_directory.Text, "kao2.exe");

                // check if kao exists
                if (File.Exists(kao2ExePath))
                {
                    // kill all kao2 processes
                    foreach (Process process in Process.GetProcessesByName("kao2"))
                        process.Kill();

                    // wait till fully closed
                    while (Process.GetProcessesByName("kao2").Length > 0) { Thread.Sleep(1); }

                    // holds kao2.exe bytes
                    byte[] fileByteArray;

                    // get kao2 file byte array
                    if (GetFileChecksum(kao2ExePath) == "28ab645257a99ded13f141039c3d75a5") fileByteArray = Properties.Resources.steamless;
                    else fileByteArray = File.ReadAllBytes(kao2ExePath);

                    // patch whats selected or patch back whats not selected
                    if (skipIntroCheck) fileByteArray = LocalPatch(fileByteArray, "8B 4D E4 3B 4D EC", "E9 F7 00 00 00 90");
                    else fileByteArray = LocalPatch(fileByteArray, "E9 F7 00 00 00 90", "8B 4D E4 3B 4D EC");

                    if (fixWaterLevelsErrorCheck) fileByteArray = LocalPatch(fileByteArray, "8B 09 50 8B 51 40 FF D2 85 C0 7D 7E", "8B 09 50 8B 51 40 FF D2 85 C0 EB 7E");
                    else fileByteArray = LocalPatch(fileByteArray, "8B 09 50 8B 51 40 FF D2 85 C0 EB 7E", "8B 09 50 8B 51 40 FF D2 85 C0 7D 7E");

                    if (dontFreezeCheck) fileByteArray = LocalPatch(fileByteArray, "89 45 F4 33 C0 83 7D 08 01 0F 94", "89 45 F4 33 C0 83 7D 08 01 0F 9E");
                    else fileByteArray = LocalPatch(fileByteArray, "89 45 F4 33 C0 83 7D 08 01 0F 9E", "89 45 F4 33 C0 83 7D 08 01 0F 94");

                    // save patched file
                    File.WriteAllBytes(kao2ExePath, fileByteArray);

                    // show success message
                    ShowInfo("kao2 patched successfully");
                }
                else ShowError("kao2.exe doesn't exist");
            }
            else ShowError("kao2 directory not selected");
        }

        // select directory for kao2
        private void SelectDirectory()
        {
            // create file browser
            OpenFileDialog folderBrowser = new OpenFileDialog();

            // disable security checks so you could select folders
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;

            // set initial directory if found on load
            if (kaoPreloadedDirectory != "")
                folderBrowser.InitialDirectory = kaoPreloadedDirectory;

            // show select folder text
            folderBrowser.FileName = "Select Folder...";

            // if directory selected
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string selectedDirectory = Path.GetDirectoryName(folderBrowser.FileName);

                // check if directory is correct
                if (File.Exists(Path.Combine(selectedDirectory, "kao2.exe")))
                {
                    // display new directory
                    label_directory.Text = selectedDirectory;
                }
                else ShowError("kao2.exe not found in the selected folder");
            }
        }

        // show custom message box with warning or error icon
        public static void ShowError(string message) { MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public static void ShowInfo(string message) { MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        // button -> patch
        private void button_Patch_MouseLeave(object sender, EventArgs e)
        { button_Patch.Image = Properties.Resources.buttonPatchDefault; label_patch.BackColor = Color.FromArgb(57, 148, 255); }

        private void button_Patch_MouseEnter(object sender, EventArgs e)
        { button_Patch.Image = Properties.Resources.buttonPatchHover; label_patch.BackColor = Color.FromArgb(47, 123, 212); }

        private void button_Patch_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;

            button_Patch.Image = Properties.Resources.buttonPatchClick; label_patch.BackColor = Color.FromArgb(30, 82, 144);
        }

        private void button_Patch_MouseUp(object sender, MouseEventArgs e)
        {
            // change button visual values
            button_Patch.Image = Properties.Resources.buttonPatchHover; label_patch.BackColor = Color.FromArgb(47, 123, 212);

            // run select directory function
            Patch();
        }


        // checkbox -> skip intro
        private void checkbox_skipintro_MouseEnter(object sender, EventArgs e)
        {
            if (skipIntroCheck == true) checkbox_skipintro.Image = Properties.Resources.checkboxCheckedHover;
            else checkbox_skipintro.Image = Properties.Resources.checkboxHover;
        }

        private void checkbox_skipintro_MouseLeave(object sender, EventArgs e)
        {
            if (skipIntroCheck == true) checkbox_skipintro.Image = Properties.Resources.checkboxCheckedDefault;
            else checkbox_skipintro.Image = Properties.Resources.checkboxDefault;
        }

        private void checkbox_skipintro_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;

            if (skipIntroCheck == true) checkbox_skipintro.Image = Properties.Resources.checkboxCheckedClick;
            else checkbox_skipintro.Image = Properties.Resources.checkboxClick;
        }

        private void checkbox_skipintro_MouseUp(object sender, MouseEventArgs e)
        {
            if (skipIntroCheck == true)
            {
                checkbox_skipintro.Image = Properties.Resources.checkboxHover;
                label_skipIntro.ForeColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                checkbox_skipintro.Image = Properties.Resources.checkboxCheckedHover;
                label_skipIntro.ForeColor = Color.FromArgb(200, 200, 200);
            }

            skipIntroCheck = !skipIntroCheck;
        }

        // checkbox -> fixWaterError
        private void checkbox_fixWaterError_MouseEnter(object sender, EventArgs e)
        {
            if (fixWaterLevelsErrorCheck == true) checkbox_fixWaterError.Image = Properties.Resources.checkboxCheckedHover;
            else checkbox_fixWaterError.Image = Properties.Resources.checkboxHover;
        }

        private void checkbox_fixWaterError_MouseLeave(object sender, EventArgs e)
        {
            if (fixWaterLevelsErrorCheck == true) checkbox_fixWaterError.Image = Properties.Resources.checkboxCheckedDefault;
            else checkbox_fixWaterError.Image = Properties.Resources.checkboxDefault;
        }

        private void checkbox_fixWaterError_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;

            if (fixWaterLevelsErrorCheck == true) checkbox_fixWaterError.Image = Properties.Resources.checkboxCheckedClick;
            else checkbox_fixWaterError.Image = Properties.Resources.checkboxClick;
        }

        private void checkbox_fixWaterError_MouseUp(object sender, MouseEventArgs e)
        {
            if (fixWaterLevelsErrorCheck == true)
            {
                checkbox_fixWaterError.Image = Properties.Resources.checkboxHover;
                label_fixWaterError.ForeColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                checkbox_fixWaterError.Image = Properties.Resources.checkboxCheckedHover;
                label_fixWaterError.ForeColor = Color.FromArgb(200, 200, 200);
            }

            fixWaterLevelsErrorCheck = !fixWaterLevelsErrorCheck;
        }

        // checkbox -> dontFreeze
        private void checkbox_dontFreeze_MouseEnter(object sender, EventArgs e)
        {
            if (dontFreezeCheck == true) checkbox_dontFreeze.Image = Properties.Resources.checkboxCheckedHover;
            else checkbox_dontFreeze.Image = Properties.Resources.checkboxHover;
        }

        private void checkbox_dontFreeze_MouseLeave(object sender, EventArgs e)
        {
            if (dontFreezeCheck == true) checkbox_dontFreeze.Image = Properties.Resources.checkboxCheckedDefault;
            else checkbox_dontFreeze.Image = Properties.Resources.checkboxDefault;
        }

        private void checkbox_dontFreeze_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;

            if (dontFreezeCheck == true) checkbox_dontFreeze.Image = Properties.Resources.checkboxCheckedClick;
            else checkbox_dontFreeze.Image = Properties.Resources.checkboxClick;
        }

        private void checkbox_dontFreeze_MouseUp(object sender, MouseEventArgs e)
        {
            if (dontFreezeCheck == true)
            {
                checkbox_dontFreeze.Image = Properties.Resources.checkboxHover;
                label_dontFreeze.ForeColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                checkbox_dontFreeze.Image = Properties.Resources.checkboxCheckedHover;
                label_dontFreeze.ForeColor = Color.FromArgb(200, 200, 200);
            }

            dontFreezeCheck = !dontFreezeCheck;
        }

        // button -> selectDirectory
        private void button_selectDirectory_MouseLeave(object sender, EventArgs e)
        { button_selectDirectory.ForeColor = Color.FromArgb(145, 145, 171); }

        private void button_selectDirectory_MouseEnter(object sender, EventArgs e)
        { button_selectDirectory.ForeColor = Color.FromArgb(124, 124, 148); }

        private void button_selectDirectory_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;
            button_selectDirectory.ForeColor = Color.FromArgb(64, 64, 77);
        }

        private void button_selectDirectory_MouseUp(object sender, MouseEventArgs e)
        {
            // change button visual values
            button_selectDirectory.ForeColor = Color.FromArgb(124, 124, 148);

            // run select directory function
            SelectDirectory();
        }

        // button -> minimize
        private void button_minimize_MouseEnter(object sender, EventArgs e)
        { button_minimize.Image = Properties.Resources.buttonMinimizeHover; }

        private void button_minimize_MouseLeave(object sender, EventArgs e)
        { button_minimize.Image = Properties.Resources.buttonMinimizeDefault; }

        private void button_minimize_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;

            button_minimize.Image = Properties.Resources.buttonMinimizeClick;
        }

        private void button_minimize_MouseUp(object sender, MouseEventArgs e)
        { button_minimize.Image = Properties.Resources.buttonMinimizeHover; WindowState = FormWindowState.Minimized; }

        // button -> close
        private void button_close_MouseEnter(object sender, EventArgs e)
        { button_close.Image = Properties.Resources.buttonCloseHover; }

        private void button_close_MouseLeave(object sender, EventArgs e)
        { button_close.Image = Properties.Resources.buttonCloseDefault; }

        private void button_close_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Capture = false;

            button_close.Image = Properties.Resources.buttonCloseClick;
        }

        private void button_close_MouseUp(object sender, MouseEventArgs e)
        { button_close.Image = Properties.Resources.buttonCloseHover; Application.Exit(); }
    }
}
