using System;
using System.Xml;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FileEncryption
{
    public partial class Login : Form
    {
        public bool isEnter;
        public string qurLogin, level;
        private string qurPass;
        private MD5 md5 = new MD5CryptoServiceProvider();
        public Login()
        {
            InitializeComponent();

            permission.Visible = false;
            password.PasswordChar = '*';
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (username.Text == "Username..." || username.Text == "")
            {
                MessageBox.Show("Enter the login please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                permission.Visible = true;
                permission.Text = "Permission denied!";
                permission.ForeColor = Color.Red;
                isEnter = false;
                this.Refresh();
                return;
            }

            if (password.Text == "Password..." || password.Text == "")
            {
                MessageBox.Show("Enter the password please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                permission.Visible = true;
                permission.Text = "Permission denied!";
                permission.ForeColor = Color.Red;
                isEnter = false;
                this.Refresh();
                return;
            }



            if (File.Exists("access.acs"))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("access.acs");
                foreach(XmlNode node in xml.DocumentElement)
                {
                    qurLogin = node.Attributes["login"].Value;
                    qurPass = node.Attributes["password"].Value;
                    if (qurLogin.CompareTo(username.Text) == 0)
                    {
                        if (qurPass.CompareTo(Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(password.Text +"@admin")))) == 0)
                        {
                            level = "admin";
                            permission.Text = "Permission granted!";
                            permission.ForeColor = Color.Green;
                            permission.Visible = true;
                            isEnter = true;
                            this.Refresh();
                            Thread.Sleep(1500);
                            this.Close();
                        }
                        else if (qurPass.CompareTo(Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(password.Text +"@manager")))) == 0)
                        {
                            level = "manager";
                            permission.Text = "Permission granted!";
                            permission.ForeColor = Color.Green;
                            permission.Visible = true;
                            isEnter = true;
                            this.Refresh();
                            Thread.Sleep(1500);
                            this.Close();
                        }
                        else
                        {
                            permission.Text = "Permission denied!";
                            permission.ForeColor = Color.Red;
                            permission.Visible = true;
                            isEnter = false;
                            this.Refresh();
                            return;
                        }
                    }
                }
            }
            else
            {
                qurLogin = "admin";
                qurPass = "password";
                level = "admin";
                if (qurPass.CompareTo(password.Text) == 0 & qurLogin.CompareTo(username.Text) == 0)
                {
                    permission.Text = "Permission granted!";
                    permission.ForeColor = Color.Green;
                    permission.Visible = true;
                    isEnter = true;
                    this.Refresh();
                    Thread.Sleep(1500);
                    this.Close();
                }
                else
                {
                    permission.Text = "Permission denied!";
                    permission.ForeColor = Color.Red;
                    permission.Visible = true;
                    isEnter = false;
                    this.Refresh();
                    return;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ShadowText username_shadow = new ShadowText("Username...");
            username.GotFocus += new EventHandler(username_shadow.placehold_GotFocus);
            username.LostFocus += new EventHandler(username_shadow.placehold_LostFocus);

            ShadowText password_shadow = new ShadowText("Password...");
            password.GotFocus += new EventHandler(password_shadow.placehold_GotFocus);
            password.LostFocus += new EventHandler(password_shadow.placehold_LostFocus);
        }
    }
}
