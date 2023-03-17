﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CmdDepot
{
    public partial class CmdDepot : Form
    {
        public CmdDepot()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 5;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.Chartreuse, rc);
        }

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
    
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            tbCmd.Paste();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCmd.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        }

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

        private void tbCmd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnCopy_Click(sender, e);
            }
            if (e.KeyCode == Keys.P && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnPaste_Click(sender, e);
            }
            if (e.KeyCode == Keys.N && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnNew_Click(sender, e);
            }
            if (e.KeyCode == Keys.T && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnStayOnTop_Click(sender, e);
            }
            if (e.KeyCode == Keys.OemMinus && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnMinimize_Click(sender, e);
            }
            if (e.KeyCode == Keys.X && e.Modifiers == (Keys.Control | Keys.Alt))
            {
                btnClose_Click(sender, e);
            }

        }
    }
}
