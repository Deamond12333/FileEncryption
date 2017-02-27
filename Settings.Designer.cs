namespace FileEncryption
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.changes = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.accessLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access manager";
            // 
            // newPass
            // 
            this.newPass.ForeColor = System.Drawing.Color.Gray;
            this.newPass.Location = new System.Drawing.Point(16, 84);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(100, 20);
            this.newPass.TabIndex = 2;
            this.newPass.Text = "New password...";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.Firebrick;
            this.delete.Location = new System.Drawing.Point(136, 32);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(136, 31);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete current";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.ForeColor = System.Drawing.Color.Gray;
            this.confirmPass.Location = new System.Drawing.Point(16, 110);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(100, 20);
            this.confirmPass.TabIndex = 5;
            this.confirmPass.Text = "Confirm password...";
            // 
            // changes
            // 
            this.changes.AutoSize = true;
            this.changes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changes.ForeColor = System.Drawing.Color.Green;
            this.changes.Location = new System.Drawing.Point(130, 236);
            this.changes.Name = "changes";
            this.changes.Size = new System.Drawing.Size(142, 16);
            this.changes.TabIndex = 6;
            this.changes.Text = "Changes accepted.";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.ForeColor = System.Drawing.Color.Teal;
            this.create.Location = new System.Drawing.Point(136, 69);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(136, 31);
            this.create.TabIndex = 7;
            this.create.Text = "Create new";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // newUsername
            // 
            this.newUsername.ForeColor = System.Drawing.Color.Gray;
            this.newUsername.Location = new System.Drawing.Point(16, 32);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(100, 20);
            this.newUsername.TabIndex = 8;
            this.newUsername.Text = "New username...";
            // 
            // accessLevel
            // 
            this.accessLevel.DisplayMember = "Access level...";
            this.accessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessLevel.ForeColor = System.Drawing.Color.Gray;
            this.accessLevel.FormattingEnabled = true;
            this.accessLevel.Items.AddRange(new object[] {
            "admin",
            "manager"});
            this.accessLevel.Location = new System.Drawing.Point(16, 58);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(100, 21);
            this.accessLevel.TabIndex = 9;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.accessLevel);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.create);
            this.Controls.Add(this.changes);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label changes;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.ComboBox accessLevel;
    }
}