namespace CmdDepot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblFont = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblBold = new System.Windows.Forms.Label();
            this.lblStrikeout = new System.Windows.Forms.Label();
            this.lblItalic = new System.Windows.Forms.Label();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.tbForeColor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBackColor = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(15, 50);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(46, 20);
            this.lblFont.TabIndex = 2;
            this.lblFont.Text = "Font:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(310, 50);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // lblBold
            // 
            this.lblBold.AutoSize = true;
            this.lblBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBold.Location = new System.Drawing.Point(15, 80);
            this.lblBold.Name = "lblBold";
            this.lblBold.Size = new System.Drawing.Size(50, 20);
            this.lblBold.TabIndex = 4;
            this.lblBold.Text = "Bold:";
            // 
            // lblStrikeout
            // 
            this.lblStrikeout.AutoSize = true;
            this.lblStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrikeout.Location = new System.Drawing.Point(15, 110);
            this.lblStrikeout.Name = "lblStrikeout";
            this.lblStrikeout.Size = new System.Drawing.Size(77, 20);
            this.lblStrikeout.TabIndex = 5;
            this.lblStrikeout.Text = "Strikeout:";
            // 
            // lblItalic
            // 
            this.lblItalic.AutoSize = true;
            this.lblItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItalic.Location = new System.Drawing.Point(310, 80);
            this.lblItalic.Name = "lblItalic";
            this.lblItalic.Size = new System.Drawing.Size(46, 20);
            this.lblItalic.TabIndex = 6;
            this.lblItalic.Text = "Italic:";
            // 
            // lblUnderline
            // 
            this.lblUnderline.AutoSize = true;
            this.lblUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline.Location = new System.Drawing.Point(310, 110);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(81, 20);
            this.lblUnderline.TabIndex = 7;
            this.lblUnderline.Text = "Underline:";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(178, 192);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(95, 39);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // gbFont
            // 
            this.gbFont.Controls.Add(this.tbForeColor);
            this.gbFont.Controls.Add(this.lblFont);
            this.gbFont.Controls.Add(this.btnFont);
            this.gbFont.Controls.Add(this.lblBold);
            this.gbFont.Controls.Add(this.lblUnderline);
            this.gbFont.Controls.Add(this.lblStrikeout);
            this.gbFont.Controls.Add(this.lblItalic);
            this.gbFont.Controls.Add(this.lblSize);
            this.gbFont.Location = new System.Drawing.Point(12, 12);
            this.gbFont.Name = "gbFont";
            this.gbFont.Size = new System.Drawing.Size(465, 257);
            this.gbFont.TabIndex = 9;
            this.gbFont.TabStop = false;
            this.gbFont.Text = " Font and Foreground Color";
            // 
            // tbForeColor
            // 
            this.tbForeColor.BackColor = System.Drawing.Color.Red;
            this.tbForeColor.Location = new System.Drawing.Point(104, 149);
            this.tbForeColor.Name = "tbForeColor";
            this.tbForeColor.ReadOnly = true;
            this.tbForeColor.Size = new System.Drawing.Size(252, 26);
            this.tbForeColor.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBackColor);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Location = new System.Drawing.Point(12, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 182);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Background Color";
            // 
            // tbBackColor
            // 
            this.tbBackColor.BackColor = System.Drawing.Color.Red;
            this.tbBackColor.Location = new System.Drawing.Point(104, 68);
            this.tbBackColor.Name = "tbBackColor";
            this.tbBackColor.ReadOnly = true;
            this.tbBackColor.Size = new System.Drawing.Size(252, 26);
            this.tbBackColor.TabIndex = 12;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(178, 119);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(95, 39);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.gbFont.ResumeLayout(false);
            this.gbFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.Label lblStrikeout;
        private System.Windows.Forms.Label lblItalic;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox gbFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbForeColor;
        private System.Windows.Forms.TextBox tbBackColor;
    }
}