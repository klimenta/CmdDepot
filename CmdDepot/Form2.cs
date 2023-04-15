using System;
using System.Windows.Forms;

namespace CmdDepot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private CmdDepot mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as CmdDepot;
            InitializeComponent();
        }
        //On form load, get the exposed properties from the main form and assign to labels and textboxes
        private void Form2_Load(object sender, EventArgs e)
        {
            lblFont.Text = "Font: " + ((CmdDepot)Owner).tbCmd.Font.Name;
            lblSize.Text = "Size: " + ((CmdDepot)Owner).tbCmd.Font.Size.ToString();
            lblBold.Text = "Bold: " + ((CmdDepot)Owner).tbCmd.Font.Bold.ToString();
            lblItalic.Text = "Italic: " +((CmdDepot)Owner).tbCmd.Font.Italic.ToString();
            lblStrikeout.Text = "Strikeout: " + ((CmdDepot)Owner).tbCmd.Font.Strikeout.ToString();
            lblUnderline.Text = "Underline: " + ((CmdDepot)Owner).tbCmd.Font.Underline.ToString();
            tbForeColor.BackColor = ((CmdDepot)Owner).tbCmd.ForeColor;
            tbBackColor.BackColor = ((CmdDepot)Owner).tbCmd.BackColor;
        }
        //Change the font
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = ((CmdDepot)Owner).tbCmd.Font;
            fontDialog1.Color = ((CmdDepot)Owner).tbCmd.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                ((CmdDepot)Owner).tbCmd.Font = fontDialog1.Font;
                ((CmdDepot)Owner).tbCmd.ForeColor = fontDialog1.Color;

                lblFont.Text = "Font: " + fontDialog1.Font.Name;
                lblSize.Text = "Size: " + fontDialog1.Font.Size.ToString();
                lblBold.Text = "Bold: " + fontDialog1.Font.Bold.ToString();
                lblItalic.Text = "Italic: " + fontDialog1.Font.Italic.ToString();
                lblStrikeout.Text = "Strikeout: " + fontDialog1.Font.Strikeout.ToString();
                lblUnderline.Text = "Underline: " + fontDialog1.Font.Underline.ToString();
                tbForeColor.BackColor = fontDialog1.Color;
            }
        }
        //Change the color
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tbBackColor.BackColor = colorDialog1.Color;
                ((CmdDepot)Owner).tbCmd.BackColor = colorDialog1.Color;
            }
        }
        //Close on ESC, KeyPreview for the form is true
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }
    }
}
