using CmdDepot.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CmdDepot
{
    public partial class CmdDepot : Form
    {
        //v0.3 - Started 20230413
        public CmdDepot()
        {
            InitializeComponent();
            //Captionless window
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //Define grip size bottom right
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 5;   // Caption bar height;
        //Expose these properties for the Settings form (tbCmd.Font, tbCmd.ForeColor and tbCmd.BackColor
        public Font TextBoxFont
        {
            get { return tbCmd.Font; }
            set { tbCmd.Font = value; }
        }

        public Color TextBoxForeColor
        {
            get { return tbCmd.ForeColor; }
            set { tbCmd.ForeColor = value; }
        }

        public Color TextBoxBackColor
        {
            get { return tbCmd.BackColor; }
            set { tbCmd.BackColor = value; }
        }
        //Move the form
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.Chartreuse, rc);
        }
        //Redraw when moving
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //Button close (X)
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //Button minimize (_)
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Button paste (P)
        private void btnPaste_Click(object sender, EventArgs e)
        {
            tbCmd.Paste();
        }
        //Button copy (C)
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCmd.Text);
        }
        //Button new (N)
        private void btnNew_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        }
        //Button Stay on Top (T)
        private void btnStayOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            if (this.TopMost) {
                btnStayOnTop.BackColor = Color.Tomato;
            } else
            {
                btnStayOnTop.BackColor = btnCopy.BackColor;
            }            
        }
        //Button settings - (S)
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form2 frmOptions = new Form2();
            frmOptions.ShowDialog(this);
        }
        //Event for shortcuts (CTRL-ALT <key>)
        private void tbCmd_KeyDown(object sender, KeyEventArgs e)
        {
            //Copy
            if (e.KeyCode == Keys.C && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnCopy_Click(sender, e);
            }
            //Paste
            if (e.KeyCode == Keys.P && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnPaste_Click(sender, e);
            }
            //New
            if (e.KeyCode == Keys.N && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnNew_Click(sender, e);
            }
            //Stay on top
            if (e.KeyCode == Keys.T && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnStayOnTop_Click(sender, e);
            }
            //Minimize
            if (e.KeyCode == Keys.M && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnMinimize_Click(sender, e);
            }
            //Close
            if (e.KeyCode == Keys.X && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnClose_Click(sender, e);
            }
            //Settings
            if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnSettings_Click(sender, e);
            }
            //CTRL-ALT-PLUS - to increase size of font, height, width
            if (e.KeyCode == Keys.Oemplus && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                tbCmd.Font = new Font(tbCmd.Font.FontFamily, tbCmd.Font.Size + 1);
                this.Size = new Size(this.Size.Width + 10, this.Size.Height + 10);
                
            }
            //CTRL-ALT-MINUS - to decrease size of font, height, width
            if (e.KeyCode == Keys.OemMinus && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                tbCmd.Font = new Font(tbCmd.Font.FontFamily, tbCmd.Font.Size - 1);
                this.Size = new Size(this.Size.Width - 10, this.Size.Height - 10);
            }
        }
        //When typing and if less than 20 chars in the text box, use that as form caption
        private void tbCmd_TextChanged(object sender, EventArgs e)
        {
            if (tbCmd.Text.Length < 20)
            {
                this.Text = tbCmd.Text;   
            }
        }
        //On form load get the app settings and if not, set the default %APDATA% (iAndreev folder)
        private void CmdDepot_Load(object sender, EventArgs e)
        {   
            // Set font size
            if (Settings.Default.Font != null)
            {
                tbCmd.Font = Settings.Default.Font;
            }
            else
            {
                tbCmd.Font = new Font("Courier New", 12, FontStyle.Regular);
            }
            // Set window size [this one is non-nullable, needs try/catch]
            try
            {
                this.Size = Settings.Default.WindowSize;
            }
            catch
            {
                this.Size = new Size(305, 55);
            }
            //Set text background color
            if (Settings.Default.BackColor != null)
            {
                tbCmd.BackColor = Settings.Default.BackColor;
            }
            else
            {
                tbCmd.BackColor = SystemColors.Window;
            }
            // Set text foreground color
            if (Settings.Default.ForeColor != null)
            {
                tbCmd.ForeColor = Settings.Default.ForeColor;
            }
            else
            {
                tbCmd.ForeColor = SystemColors.WindowText;
            }
        }
        //Save the current values when closing the program
        private void CmdDepot_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.WindowSize = this.Size;
            Settings.Default.Font = tbCmd.Font;
            Settings.Default.ForeColor = tbCmd.ForeColor;
            Settings.Default.BackColor = tbCmd.BackColor;
            Properties.Settings.Default.Save();
        }
    }
}
