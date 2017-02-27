using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;

namespace FileEncryption
{
    public partial class Settings : Form
    {
        MD5 md5 = new MD5CryptoServiceProvider();
        string qurLogin, qurPassword;
        public Settings(string qurLogin, string accessLevel)
        {
            InitializeComponent();

            changes.Visible = false;
            this.qurLogin = qurLogin;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ShadowText newUser_shadow = new ShadowText("New username...");
            newUsername.GotFocus += new EventHandler(newUser_shadow.placehold_GotFocus);
            newUsername.LostFocus += new EventHandler(newUser_shadow.placehold_LostFocus);

            ShadowText newPass_shadow = new ShadowText("New password...");
            newPass.GotFocus += new EventHandler(newPass_shadow.placehold_GotFocus);
            newPass.LostFocus += new EventHandler(newPass_shadow.placehold_LostFocus);

            ShadowText confPass_shadow = new ShadowText("Confirm password...");
            confirmPass.GotFocus += new EventHandler(confPass_shadow.placehold_GotFocus);
            confirmPass.LostFocus += new EventHandler(confPass_shadow.placehold_LostFocus);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("access.acs");
            foreach (XmlNode node in xml.DocumentElement)
            {
                string includeLogin = node.Attributes["login"].Value;
                if (includeLogin.CompareTo(qurLogin) == 0)
                {
                    node.RemoveAll();
                    xml.Save("access.acs");
                    changes.Visible = true;
                    changes.Text = "Changes accepted.";
                    changes.ForeColor = Color.Green;
                    this.Refresh();
                    return;
                }
            }   
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (newUsername.Text == "New username..." || newUsername.Text == "")
            {
                MessageBox.Show("Enter the new username please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changes.Visible = true;
                changes.Text = "Changes rejected.";
                changes.ForeColor = Color.Red;
                this.Refresh();
                return;
            }

            if (newPass.Text == "New password..." || newPass.Text == "")
            {
                MessageBox.Show("Enter the new password please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changes.Visible = true;
                changes.Text = "Changes rejected.";
                changes.ForeColor = Color.Red;
                this.Refresh();
                return;
            }

            if (accessLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Select the access level please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changes.Visible = true;
                changes.Text = "Changes rejected.";
                changes.ForeColor = Color.Red;
                this.Refresh();
                return;
            }

            if (confirmPass.Text == "Confirm password..." || confirmPass.Text == "")
            {
                MessageBox.Show("Confirm the new password please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changes.Visible = true;
                changes.Text = "Changes rejected.";
                changes.ForeColor = Color.Red;
                this.Refresh();
                return;
            }

            if (newPass.Text.CompareTo(confirmPass.Text) != 0)
            {
                MessageBox.Show("New password don't compared with confirm password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changes.Visible = true;
                changes.Text = "Changes rejected.";
                changes.ForeColor = Color.Red;
                this.Refresh();
                return;
            }

            XmlDocument xml = new XmlDocument();
            if (File.Exists("access.acs"))
            {
                xml.Load("access.acs");
                foreach (XmlNode node in xml.DocumentElement)
                {
                    qurLogin = node.Attributes["login"].Value;
                    qurPassword = node.Attributes["password"].Value;
                    if (qurLogin.CompareTo(newUsername.Text) == 0)
                    {
                        xml.Save("access.acs");
                        MessageBox.Show("The new user is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changes.Visible = true;
                        changes.Text = "Changes rejected.";
                        changes.ForeColor = Color.Red;
                        this.Refresh();
                        return;
                    }
                }
            }
            else
            {
                XmlNode element = xml.CreateElement("base");
                xml.AppendChild(element);
            }

            XmlNode user = xml.CreateElement("user");
            XmlAttribute login = xml.CreateAttribute("login"); ;
            XmlAttribute password = xml.CreateAttribute("password");
            login.Value = newUsername.Text;
            password.Value = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(newPass.Text + "@" + accessLevel.SelectedItem.ToString())));
            user.Attributes.Append(login);
            user.Attributes.Append(password);
            xml.DocumentElement.AppendChild(user);

            xml.Save("access.acs");

            changes.Visible = true;
            changes.Text = "Changes accepted.";
            changes.ForeColor = Color.Green;
            this.Refresh();
        }
    }
}
