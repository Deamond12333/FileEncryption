using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FileEncryption
{
    public partial class Home : Form
    {
        string qurLogin, level;
        public Home()
        {
            InitializeComponent();
            
            Login login = new Login();
            login.FormClosing += login_FormClosing;
            login.ShowDialog();
        }

        void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = (Login)sender;
            if (!login.isEnter) Application.Exit();
            else
            {
                qurLogin = login.qurLogin;
                level = login.level;
                accessLevel.Text += level;
                if (level.CompareTo("manager") == 0)
                {
                    save.Enabled = false;
                    permission_settings.Enabled = false;
                }
                this.Refresh();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open file...";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFileDialog.OpenFile()) != null)
                    {
                        openFile.Text = null;
                        int streamLength = (int)fileStream.Length;
                        byte[] buffer = new byte[streamLength];
                        fileStream.Read(buffer, 0, streamLength);
                        openFile.Text = decryptFunc(qurLogin + "@" + level, Encoding.UTF8.GetString(buffer));
                        fileStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk. Original error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (openFile.Text.Length == 0)
            {
                MessageBox.Show("Open the text file firstly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encryptKey.Text == "Encrypt key...")
            {
                MessageBox.Show("Enter the encryption key firstly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFile.Text = encryptFunc(encryptKey.Text, openFile.Text);
        }

        private string encryptFunc(string encryptKey, string text)
        {
            string result = "";
            int k = 0, i = 0;

            while (i < text.Length)
            {
                int symb = (int)text[i];
                int encrypt = ((int)encryptKey[k] + symb) % 100000000;
                result += (char)encrypt;

                if (k < encryptKey.Length - 1) k++;
                else k = 0;

                i++;
            }
            return result;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFile.Text.Length == 0)
            {
                MessageBox.Show("Nothing to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stream fileStream = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Save file...";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog.OpenFile()) != null)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(encryptFunc(qurLogin + "@" + level, saveFile.Text));
                    fileStream.Write(buffer, 0, buffer.Length);
                    fileStream.Close();
                }
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (openFile.Text.Length == 0)
            {
                MessageBox.Show("Open the text file firstly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encryptKey.Text.Length == 0)
            {
                MessageBox.Show("Enter the encryption key firstly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFile.Text = decryptFunc(encryptKey.Text, openFile.Text);     
        }

        private string decryptFunc(string encryptKey, string text)
        {
            string result = "";
            int k = 0, i = 0;

            while (i < text.Length)
            {
                int symb = (int)text[i];
                int encrypt = (symb - (int)encryptKey[k]) % 100000000;
                result += (char)encrypt;

                if (k < encryptKey.Length - 1) k++;
                else k = 0;

                i++;
            }
            return result;
        }

        private void permission_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(qurLogin, level);
            settings.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ShadowText encryptKey_shadow = new ShadowText("Encrypt key...");
            encryptKey.GotFocus += new EventHandler(encryptKey_shadow.placehold_GotFocus);
            encryptKey.LostFocus += new EventHandler(encryptKey_shadow.placehold_LostFocus);
        }
    }
}
