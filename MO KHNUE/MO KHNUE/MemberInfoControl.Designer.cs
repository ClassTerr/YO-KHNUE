namespace MO_KHNUE.Entities
{
    partial class MemberInfoControl
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
            this.photo = new System.Windows.Forms.PictureBox();
            this.outputPhone = new System.Windows.Forms.Label();
            this.outputGroup = new System.Windows.Forms.Label();
            this.headPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.outputEmail = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outputBirthDay = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.outputName = new System.Windows.Forms.Label();
            this.iconButtonSmall2 = new MO_KHNUE.IconButtonSmall();
            this.iconButtonSmall4 = new MO_KHNUE.IconButtonSmall();
            this.iconButtonSmall1 = new MO_KHNUE.IconButtonSmall();
            this.iconButtonSmall3 = new MO_KHNUE.IconButtonSmall();
            this.iconButton1 = new Borderless.Buttons.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.headPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // photo
            // 
            this.photo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photo.Image = global::MO_KHNUE.Properties.Resources.UserImagePlaceholder;
            this.photo.Location = new System.Drawing.Point(148, 40);
            this.photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(200, 200);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 6;
            this.photo.TabStop = false;
            // 
            // outputPhone
            // 
            this.outputPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputPhone.AutoSize = true;
            this.outputPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputPhone.Location = new System.Drawing.Point(174, 1);
            this.outputPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPhone.Name = "outputPhone";
            this.outputPhone.Size = new System.Drawing.Size(177, 25);
            this.outputPhone.TabIndex = 10;
            this.outputPhone.Text = "+38 (012) 345 67 89";
            this.outputPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputGroup
            // 
            this.outputGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputGroup.AutoSize = true;
            this.outputGroup.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputGroup.Location = new System.Drawing.Point(178, 3);
            this.outputGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(118, 25);
            this.outputGroup.TabIndex = 10;
            this.outputGroup.Text = "6.04.51.15.01";
            this.outputGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.iconButton1);
            this.headPanel.Controls.Add(this.photo);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(496, 247);
            this.headPanel.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButtonSmall2);
            this.panel2.Controls.Add(this.outputGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 40);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.outputPhone);
            this.panel4.Controls.Add(this.iconButtonSmall1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 40);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.outputEmail);
            this.panel5.Controls.Add(this.iconButtonSmall4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 40);
            this.panel5.TabIndex = 17;
            // 
            // outputEmail
            // 
            this.outputEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputEmail.AutoSize = true;
            this.outputEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputEmail.Location = new System.Drawing.Point(174, 0);
            this.outputEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputEmail.Name = "outputEmail";
            this.outputEmail.Size = new System.Drawing.Size(212, 25);
            this.outputEmail.TabIndex = 14;
            this.outputEmail.Text = "example@example.com";
            this.outputEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButtonSmall3);
            this.panel3.Controls.Add(this.outputBirthDay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 40);
            this.panel3.TabIndex = 16;
            // 
            // outputBirthDay
            // 
            this.outputBirthDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputBirthDay.AutoSize = true;
            this.outputBirthDay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBirthDay.Location = new System.Drawing.Point(178, 1);
            this.outputBirthDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputBirthDay.Name = "outputBirthDay";
            this.outputBirthDay.Size = new System.Drawing.Size(100, 25);
            this.outputBirthDay.TabIndex = 13;
            this.outputBirthDay.Text = "01.01.1970";
            this.outputBirthDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(496, 242);
            this.panel6.TabIndex = 18;
            // 
            // outputName
            // 
            this.outputName.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputName.Location = new System.Drawing.Point(0, 247);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(496, 113);
            this.outputName.TabIndex = 20;
            this.outputName.Text = "Name Surname";
            this.outputName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconButtonSmall2
            // 
            this.iconButtonSmall2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall2.AutoSize = true;
            this.iconButtonSmall2.Font = new System.Drawing.Font("UI", 20F);
            this.iconButtonSmall2.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall2.Location = new System.Drawing.Point(143, 3);
            this.iconButtonSmall2.Name = "iconButtonSmall2";
            this.iconButtonSmall2.Size = new System.Drawing.Size(36, 27);
            this.iconButtonSmall2.TabIndex = 11;
            this.iconButtonSmall2.Text = "";
            this.iconButtonSmall2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonSmall4
            // 
            this.iconButtonSmall4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall4.AutoSize = true;
            this.iconButtonSmall4.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSmall4.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall4.Location = new System.Drawing.Point(140, -4);
            this.iconButtonSmall4.Name = "iconButtonSmall4";
            this.iconButtonSmall4.Size = new System.Drawing.Size(47, 44);
            this.iconButtonSmall4.TabIndex = 11;
            this.iconButtonSmall4.Text = "@";
            this.iconButtonSmall4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonSmall1
            // 
            this.iconButtonSmall1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall1.AutoSize = true;
            this.iconButtonSmall1.Font = new System.Drawing.Font("UI", 20F);
            this.iconButtonSmall1.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall1.Location = new System.Drawing.Point(143, 3);
            this.iconButtonSmall1.Name = "iconButtonSmall1";
            this.iconButtonSmall1.Size = new System.Drawing.Size(39, 27);
            this.iconButtonSmall1.TabIndex = 11;
            this.iconButtonSmall1.Text = "";
            this.iconButtonSmall1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonSmall3
            // 
            this.iconButtonSmall3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall3.AutoSize = true;
            this.iconButtonSmall3.Font = new System.Drawing.Font("UI", 20F);
            this.iconButtonSmall3.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall3.Location = new System.Drawing.Point(143, 3);
            this.iconButtonSmall3.Name = "iconButtonSmall3";
            this.iconButtonSmall3.Size = new System.Drawing.Size(39, 27);
            this.iconButtonSmall3.TabIndex = 11;
            this.iconButtonSmall3.Text = "";
            this.iconButtonSmall3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(58, 41);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.outputName);
            this.Controls.Add(this.headPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberInfoControl";
            this.Size = new System.Drawing.Size(496, 602);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox photo;
        private Borderless.Buttons.IconButton iconButton1;
        private System.Windows.Forms.Label outputPhone;
        private System.Windows.Forms.Label outputGroup;
        private IconButtonSmall iconButtonSmall1;
        private System.Windows.Forms.Panel headPanel;
        private IconButtonSmall iconButtonSmall2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label outputEmail;
        private IconButtonSmall iconButtonSmall4;
        private System.Windows.Forms.Panel panel3;
        private IconButtonSmall iconButtonSmall3;
        private System.Windows.Forms.Label outputBirthDay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label outputName;
    }
}