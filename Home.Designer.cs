namespace FileEncryption
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.encryptKey = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.permission_settings = new System.Windows.Forms.Button();
            this.accessLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(13, 13);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(330, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Open file...";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(551, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(330, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save file...";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // encryptKey
            // 
            this.encryptKey.ForeColor = System.Drawing.Color.Gray;
            this.encryptKey.Location = new System.Drawing.Point(349, 15);
            this.encryptKey.Name = "encryptKey";
            this.encryptKey.Size = new System.Drawing.Size(196, 20);
            this.encryptKey.TabIndex = 2;
            this.encryptKey.Text = "Encrypt key...";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(349, 42);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(196, 23);
            this.encrypt.TabIndex = 3;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(349, 71);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(196, 23);
            this.decrypt.TabIndex = 4;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(13, 42);
            this.openFile.Multiline = true;
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(330, 440);
            this.openFile.TabIndex = 5;
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(551, 42);
            this.saveFile.Multiline = true;
            this.saveFile.Name = "saveFile";
            this.saveFile.ReadOnly = true;
            this.saveFile.Size = new System.Drawing.Size(330, 440);
            this.saveFile.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // permission_settings
            // 
            this.permission_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("permission_settings.BackgroundImage")));
            this.permission_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.permission_settings.Location = new System.Drawing.Point(354, 423);
            this.permission_settings.Name = "permission_settings";
            this.permission_settings.Size = new System.Drawing.Size(191, 59);
            this.permission_settings.TabIndex = 9;
            this.permission_settings.UseVisualStyleBackColor = true;
            this.permission_settings.Click += new System.EventHandler(this.permission_settings_Click);
            // 
            // accessLevel
            // 
            this.accessLevel.AutoSize = true;
            this.accessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accessLevel.ForeColor = System.Drawing.Color.OrangeRed;
            this.accessLevel.Location = new System.Drawing.Point(349, 302);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(105, 16);
            this.accessLevel.TabIndex = 12;
            this.accessLevel.Text = "Access level: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 494);
            this.Controls.Add(this.accessLevel);
            this.Controls.Add(this.permission_settings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.encryptKey);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encryption";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox encryptKey;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox openFile;
        private System.Windows.Forms.TextBox saveFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button permission_settings;
        private System.Windows.Forms.Label accessLevel;
    }
}

