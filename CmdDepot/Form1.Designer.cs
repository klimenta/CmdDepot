namespace CmdDepot
{
    partial class CmdDepot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmdDepot));
            this.panHolder = new System.Windows.Forms.Panel();
            this.tbCmd = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.ttTooltips = new System.Windows.Forms.ToolTip(this.components);
            this.btnStayOnTop = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.panHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHolder
            // 
            this.panHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHolder.Controls.Add(this.tbCmd);
            this.panHolder.Location = new System.Drawing.Point(0, 32);
            this.panHolder.Name = "panHolder";
            this.panHolder.Size = new System.Drawing.Size(404, 50);
            this.panHolder.TabIndex = 0;
            // 
            // tbCmd
            // 
            this.tbCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCmd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCmd.Location = new System.Drawing.Point(0, 1);
            this.tbCmd.Multiline = true;
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.Size = new System.Drawing.Size(402, 44);
            this.tbCmd.TabIndex = 2;
            this.tbCmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCmd_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(64, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(30, 30);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "N";
            this.ttTooltips.SetToolTip(this.btnNew, "New Instance");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(128, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "-";
            this.ttTooltips.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(160, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.ttTooltips.SetToolTip(this.btnClose, "Exit Application");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Location = new System.Drawing.Point(32, 2);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(30, 30);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "P";
            this.ttTooltips.SetToolTip(this.btnPaste, "Paste from Clipboard");
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(0, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(30, 30);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "C";
            this.ttTooltips.SetToolTip(this.btnCopy, "Copy to Clipboard");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // ttTooltips
            // 
            this.ttTooltips.IsBalloon = true;
            // 
            // btnStayOnTop
            // 
            this.btnStayOnTop.Location = new System.Drawing.Point(96, 2);
            this.btnStayOnTop.Name = "btnStayOnTop";
            this.btnStayOnTop.Size = new System.Drawing.Size(30, 30);
            this.btnStayOnTop.TabIndex = 7;
            this.btnStayOnTop.Text = "T";
            this.ttTooltips.SetToolTip(this.btnStayOnTop, "Stay On Top");
            this.btnStayOnTop.UseVisualStyleBackColor = true;
            this.btnStayOnTop.Click += new System.EventHandler(this.btnStayOnTop_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(196, 10);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(210, 20);
            this.lblAbout.TabIndex = 6;
            this.lblAbout.Text = "Kliment Andreev - 2023, v0.2";
            // 
            // CmdDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 80);
            this.Controls.Add(this.btnStayOnTop);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panHolder);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CmdDepot";
            this.Text = "CmdDepot";
            this.panHolder.ResumeLayout(false);
            this.panHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHolder;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbCmd;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolTip ttTooltips;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnStayOnTop;
    }
}

