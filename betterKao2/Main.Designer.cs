namespace betterKao2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_selectDirectory = new System.Windows.Forms.Label();
            this.label_patch = new System.Windows.Forms.Label();
            this.label_skipIntro = new System.Windows.Forms.Label();
            this.label_fixWaterError = new System.Windows.Forms.Label();
            this.label_dontFreeze = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_directory = new System.Windows.Forms.Label();
            this.checkbox_dontFreeze = new System.Windows.Forms.PictureBox();
            this.checkbox_fixWaterError = new System.Windows.Forms.PictureBox();
            this.checkbox_skipintro = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Patch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_dontFreeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_fixWaterError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_skipintro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Patch)).BeginInit();
            this.SuspendLayout();
            // 
            // button_selectDirectory
            // 
            this.button_selectDirectory.Font = new System.Drawing.Font("Lato", 11F);
            this.button_selectDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(171)))));
            this.button_selectDirectory.Location = new System.Drawing.Point(179, 166);
            this.button_selectDirectory.Name = "button_selectDirectory";
            this.button_selectDirectory.Size = new System.Drawing.Size(119, 18);
            this.button_selectDirectory.TabIndex = 9;
            this.button_selectDirectory.Text = "Select Directory";
            this.button_selectDirectory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_selectDirectory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_selectDirectory_MouseDown);
            this.button_selectDirectory.MouseEnter += new System.EventHandler(this.button_selectDirectory_MouseEnter);
            this.button_selectDirectory.MouseLeave += new System.EventHandler(this.button_selectDirectory_MouseLeave);
            this.button_selectDirectory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_selectDirectory_MouseUp);
            // 
            // label_patch
            // 
            this.label_patch.AutoSize = true;
            this.label_patch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_patch.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patch.ForeColor = System.Drawing.Color.White;
            this.label_patch.Location = new System.Drawing.Point(133, 222);
            this.label_patch.Name = "label_patch";
            this.label_patch.Size = new System.Drawing.Size(46, 18);
            this.label_patch.TabIndex = 10;
            this.label_patch.Text = "Patch";
            this.label_patch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Patch_MouseDown);
            this.label_patch.MouseEnter += new System.EventHandler(this.button_Patch_MouseEnter);
            this.label_patch.MouseLeave += new System.EventHandler(this.button_Patch_MouseLeave);
            this.label_patch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Patch_MouseUp);
            // 
            // label_skipIntro
            // 
            this.label_skipIntro.AutoSize = true;
            this.label_skipIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.label_skipIntro.Font = new System.Drawing.Font("Lato", 11F);
            this.label_skipIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_skipIntro.Location = new System.Drawing.Point(37, 43);
            this.label_skipIntro.Name = "label_skipIntro";
            this.label_skipIntro.Size = new System.Drawing.Size(123, 18);
            this.label_skipIntro.TabIndex = 11;
            this.label_skipIntro.Text = "Skip intro on boot";
            this.label_skipIntro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // label_fixWaterError
            // 
            this.label_fixWaterError.AutoSize = true;
            this.label_fixWaterError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.label_fixWaterError.Font = new System.Drawing.Font("Lato", 11F);
            this.label_fixWaterError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_fixWaterError.Location = new System.Drawing.Point(37, 64);
            this.label_fixWaterError.Name = "label_fixWaterError";
            this.label_fixWaterError.Size = new System.Drawing.Size(149, 18);
            this.label_fixWaterError.TabIndex = 12;
            this.label_fixWaterError.Text = "Fix water levels error";
            this.label_fixWaterError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // label_dontFreeze
            // 
            this.label_dontFreeze.AutoSize = true;
            this.label_dontFreeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.label_dontFreeze.Font = new System.Drawing.Font("Lato", 11F);
            this.label_dontFreeze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label_dontFreeze.Location = new System.Drawing.Point(37, 85);
            this.label_dontFreeze.Name = "label_dontFreeze";
            this.label_dontFreeze.Size = new System.Drawing.Size(206, 18);
            this.label_dontFreeze.TabIndex = 13;
            this.label_dontFreeze.Text = "Don’t freeze when out of focus";
            this.label_dontFreeze.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Lato", 11F);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(171)))));
            this.label_title.Location = new System.Drawing.Point(12, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(85, 18);
            this.label_title.TabIndex = 14;
            this.label_title.Text = "betterKao2";
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Font = new System.Drawing.Font("Lato", 7F);
            this.label_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(171)))));
            this.label_version.Location = new System.Drawing.Point(282, 115);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(16, 12);
            this.label_version.TabIndex = 15;
            this.label_version.Text = "v1";
            this.label_version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // label_directory
            // 
            this.label_directory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.label_directory.Font = new System.Drawing.Font("Lato", 11F);
            this.label_directory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(106)))));
            this.label_directory.Location = new System.Drawing.Point(14, 191);
            this.label_directory.Name = "label_directory";
            this.label_directory.Size = new System.Drawing.Size(281, 17);
            this.label_directory.TabIndex = 16;
            this.label_directory.UseCompatibleTextRendering = true;
            this.label_directory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // checkbox_dontFreeze
            // 
            this.checkbox_dontFreeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.checkbox_dontFreeze.Image = ((System.Drawing.Image)(resources.GetObject("checkbox_dontFreeze.Image")));
            this.checkbox_dontFreeze.Location = new System.Drawing.Point(18, 87);
            this.checkbox_dontFreeze.Name = "checkbox_dontFreeze";
            this.checkbox_dontFreeze.Size = new System.Drawing.Size(15, 15);
            this.checkbox_dontFreeze.TabIndex = 8;
            this.checkbox_dontFreeze.TabStop = false;
            this.checkbox_dontFreeze.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkbox_dontFreeze_MouseDown);
            this.checkbox_dontFreeze.MouseEnter += new System.EventHandler(this.checkbox_dontFreeze_MouseEnter);
            this.checkbox_dontFreeze.MouseLeave += new System.EventHandler(this.checkbox_dontFreeze_MouseLeave);
            this.checkbox_dontFreeze.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkbox_dontFreeze_MouseUp);
            // 
            // checkbox_fixWaterError
            // 
            this.checkbox_fixWaterError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.checkbox_fixWaterError.Image = ((System.Drawing.Image)(resources.GetObject("checkbox_fixWaterError.Image")));
            this.checkbox_fixWaterError.Location = new System.Drawing.Point(18, 66);
            this.checkbox_fixWaterError.Name = "checkbox_fixWaterError";
            this.checkbox_fixWaterError.Size = new System.Drawing.Size(15, 15);
            this.checkbox_fixWaterError.TabIndex = 7;
            this.checkbox_fixWaterError.TabStop = false;
            this.checkbox_fixWaterError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkbox_fixWaterError_MouseDown);
            this.checkbox_fixWaterError.MouseEnter += new System.EventHandler(this.checkbox_fixWaterError_MouseEnter);
            this.checkbox_fixWaterError.MouseLeave += new System.EventHandler(this.checkbox_fixWaterError_MouseLeave);
            this.checkbox_fixWaterError.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkbox_fixWaterError_MouseUp);
            // 
            // checkbox_skipintro
            // 
            this.checkbox_skipintro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.checkbox_skipintro.Image = ((System.Drawing.Image)(resources.GetObject("checkbox_skipintro.Image")));
            this.checkbox_skipintro.Location = new System.Drawing.Point(18, 45);
            this.checkbox_skipintro.Name = "checkbox_skipintro";
            this.checkbox_skipintro.Size = new System.Drawing.Size(15, 15);
            this.checkbox_skipintro.TabIndex = 6;
            this.checkbox_skipintro.TabStop = false;
            this.checkbox_skipintro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkbox_skipintro_MouseDown);
            this.checkbox_skipintro.MouseEnter += new System.EventHandler(this.checkbox_skipintro_MouseEnter);
            this.checkbox_skipintro.MouseLeave += new System.EventHandler(this.checkbox_skipintro_MouseLeave);
            this.checkbox_skipintro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkbox_skipintro_MouseUp);
            // 
            // button_minimize
            // 
            this.button_minimize.Image = ((System.Drawing.Image)(resources.GetObject("button_minimize.Image")));
            this.button_minimize.Location = new System.Drawing.Point(262, 10);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(15, 15);
            this.button_minimize.TabIndex = 5;
            this.button_minimize.TabStop = false;
            this.button_minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_minimize_MouseDown);
            this.button_minimize.MouseEnter += new System.EventHandler(this.button_minimize_MouseEnter);
            this.button_minimize.MouseLeave += new System.EventHandler(this.button_minimize_MouseLeave);
            this.button_minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_minimize_MouseUp);
            // 
            // button_close
            // 
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(283, 10);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(15, 15);
            this.button_close.TabIndex = 4;
            this.button_close.TabStop = false;
            this.button_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_close_MouseDown);
            this.button_close.MouseEnter += new System.EventHandler(this.button_close_MouseEnter);
            this.button_close.MouseLeave += new System.EventHandler(this.button_close_MouseLeave);
            this.button_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_close_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::betterKao2.Properties.Resources.panelTop;
            this.pictureBox3.Location = new System.Drawing.Point(10, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(288, 76);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::betterKao2.Properties.Resources.panelDirectory;
            this.pictureBox1.Location = new System.Drawing.Point(9, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_Patch
            // 
            this.button_Patch.Image = global::betterKao2.Properties.Resources.buttonPatchDefault;
            this.button_Patch.Location = new System.Drawing.Point(9, 219);
            this.button_Patch.Name = "button_Patch";
            this.button_Patch.Size = new System.Drawing.Size(289, 25);
            this.button_Patch.TabIndex = 0;
            this.button_Patch.TabStop = false;
            this.button_Patch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Patch_MouseDown);
            this.button_Patch.MouseEnter += new System.EventHandler(this.button_Patch_MouseEnter);
            this.button_Patch.MouseLeave += new System.EventHandler(this.button_Patch_MouseLeave);
            this.button_Patch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Patch_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(308, 255);
            this.Controls.Add(this.label_directory);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_dontFreeze);
            this.Controls.Add(this.label_fixWaterError);
            this.Controls.Add(this.label_skipIntro);
            this.Controls.Add(this.label_patch);
            this.Controls.Add(this.button_selectDirectory);
            this.Controls.Add(this.checkbox_dontFreeze);
            this.Controls.Add(this.checkbox_fixWaterError);
            this.Controls.Add(this.checkbox_skipintro);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Patch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "betterKao2";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_dontFreeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_fixWaterError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_skipintro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Patch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox button_Patch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox button_close;
        private System.Windows.Forms.PictureBox button_minimize;
        private System.Windows.Forms.PictureBox checkbox_skipintro;
        private System.Windows.Forms.PictureBox checkbox_fixWaterError;
        private System.Windows.Forms.PictureBox checkbox_dontFreeze;
        private System.Windows.Forms.Label button_selectDirectory;
        private System.Windows.Forms.Label label_patch;
        private System.Windows.Forms.Label label_skipIntro;
        private System.Windows.Forms.Label label_fixWaterError;
        private System.Windows.Forms.Label label_dontFreeze;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_directory;
    }
}
