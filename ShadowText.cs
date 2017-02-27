using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace FileEncryption
{
    public class ShadowText
    {
        private string placehold;
        public ShadowText(string placehold)
        {
            this.placehold = placehold;
        }
        
        public void placehold_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == placehold)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void placehold_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = placehold;
                tb.ForeColor = Color.Gray;
            }
        }
    }
}
