namespace Borderless
{
    partial class BorderlessForm
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
            this.TopLeftCornerPanel = new System.Windows.Forms.Panel();
            this.TopRightCornerPanel = new System.Windows.Forms.Panel();
            this.BottomLeftCornerPanel = new System.Windows.Forms.Panel();
            this.BottomRightCornerPanel = new System.Windows.Forms.Panel();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.LeftBorderPanel = new System.Windows.Forms.Panel();
            this.RightBorderPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DecorationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BackButton = new Borderless.Buttons.HeaderButton();
            this.CloseButton = new Borderless.Buttons.HeaderButton();
            this.MaximizeButton = new Borderless.Buttons.HeaderButton();
            this.MinimizeButton = new Borderless.Buttons.HeaderButton();
            this.TitleLeftButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleRightButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomHeader = new System.Windows.Forms.Panel();
            this.TopBorderPanel.SuspendLayout();
            this.BottomBorderPanel.SuspendLayout();
            this.TitleLeftButtons.SuspendLayout();
            this.TitleRightButtons.SuspendLayout();
            this.CustomHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopLeftCornerPanel
            // 
            this.TopLeftCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.TopLeftCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.TopLeftCornerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopLeftCornerPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftCornerPanel.Name = "TopLeftCornerPanel";
            this.TopLeftCornerPanel.Size = new System.Drawing.Size(2, 2);
            this.TopLeftCornerPanel.TabIndex = 0;
            // 
            // TopRightCornerPanel
            // 
            this.TopRightCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.TopRightCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TopRightCornerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopRightCornerPanel.Location = new System.Drawing.Point(988, 0);
            this.TopRightCornerPanel.Name = "TopRightCornerPanel";
            this.TopRightCornerPanel.Size = new System.Drawing.Size(2, 2);
            this.TopRightCornerPanel.TabIndex = 1;
            // 
            // BottomLeftCornerPanel
            // 
            this.BottomLeftCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.BottomLeftCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.BottomLeftCornerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BottomLeftCornerPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomLeftCornerPanel.Name = "BottomLeftCornerPanel";
            this.BottomLeftCornerPanel.Size = new System.Drawing.Size(2, 2);
            this.BottomLeftCornerPanel.TabIndex = 1;
            // 
            // BottomRightCornerPanel
            // 
            this.BottomRightCornerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.BottomRightCornerPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.BottomRightCornerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BottomRightCornerPanel.Location = new System.Drawing.Point(986, 0);
            this.BottomRightCornerPanel.Name = "BottomRightCornerPanel";
            this.BottomRightCornerPanel.Size = new System.Drawing.Size(2, 2);
            this.BottomRightCornerPanel.TabIndex = 1;
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.TopBorderPanel.Controls.Add(this.TopLeftCornerPanel);
            this.TopBorderPanel.Controls.Add(this.TopRightCornerPanel);
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(990, 2);
            this.TopBorderPanel.TabIndex = 2;
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.BottomBorderPanel.Controls.Add(this.BottomRightCornerPanel);
            this.BottomBorderPanel.Controls.Add(this.BottomLeftCornerPanel);
            this.BottomBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel.Location = new System.Drawing.Point(2, 522);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(988, 2);
            this.BottomBorderPanel.TabIndex = 3;
            // 
            // LeftBorderPanel
            // 
            this.LeftBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.LeftBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorderPanel.Location = new System.Drawing.Point(0, 2);
            this.LeftBorderPanel.Name = "LeftBorderPanel";
            this.LeftBorderPanel.Size = new System.Drawing.Size(2, 522);
            this.LeftBorderPanel.TabIndex = 4;
            // 
            // RightBorderPanel
            // 
            this.RightBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.RightBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorderPanel.Location = new System.Drawing.Point(990, 0);
            this.RightBorderPanel.Name = "RightBorderPanel";
            this.RightBorderPanel.Size = new System.Drawing.Size(2, 524);
            this.RightBorderPanel.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TitleLabel.Location = new System.Drawing.Point(34, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(843, 31);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 27);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DecorationToolTip.SetToolTip(this.BackButton, "Maximize");
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("Marlett", 8.5F);
            this.CloseButton.Location = new System.Drawing.Point(77, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "r";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecorationToolTip.SetToolTip(this.CloseButton, "Close");
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.White;
            this.MaximizeButton.Font = new System.Drawing.Font("Marlett", 8.5F);
            this.MaximizeButton.Location = new System.Drawing.Point(43, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(34, 23);
            this.MaximizeButton.TabIndex = 8;
            this.MaximizeButton.Text = "1";
            this.MaximizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecorationToolTip.SetToolTip(this.MaximizeButton, "Maximize");
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.White;
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 8.5F);
            this.MinimizeButton.Location = new System.Drawing.Point(9, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 23);
            this.MinimizeButton.TabIndex = 10;
            this.MinimizeButton.Text = "0";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecorationToolTip.SetToolTip(this.MinimizeButton, "Minimize");
            // 
            // TitleLeftButtons
            // 
            this.TitleLeftButtons.AutoSize = true;
            this.TitleLeftButtons.BackColor = System.Drawing.Color.Transparent;
            this.TitleLeftButtons.Controls.Add(this.BackButton);
            this.TitleLeftButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLeftButtons.Location = new System.Drawing.Point(0, 0);
            this.TitleLeftButtons.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLeftButtons.Name = "TitleLeftButtons";
            this.TitleLeftButtons.Size = new System.Drawing.Size(34, 31);
            this.TitleLeftButtons.TabIndex = 11;
            // 
            // TitleRightButtons
            // 
            this.TitleRightButtons.Controls.Add(this.CloseButton);
            this.TitleRightButtons.Controls.Add(this.MaximizeButton);
            this.TitleRightButtons.Controls.Add(this.MinimizeButton);
            this.TitleRightButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleRightButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TitleRightButtons.Location = new System.Drawing.Point(877, 0);
            this.TitleRightButtons.Margin = new System.Windows.Forms.Padding(0);
            this.TitleRightButtons.Name = "TitleRightButtons";
            this.TitleRightButtons.Size = new System.Drawing.Size(111, 31);
            this.TitleRightButtons.TabIndex = 0;
            // 
            // CustomHeader
            // 
            this.CustomHeader.BackColor = System.Drawing.Color.White;
            this.CustomHeader.Controls.Add(this.TitleLabel);
            this.CustomHeader.Controls.Add(this.TitleLeftButtons);
            this.CustomHeader.Controls.Add(this.TitleRightButtons);
            this.CustomHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomHeader.Location = new System.Drawing.Point(2, 2);
            this.CustomHeader.Margin = new System.Windows.Forms.Padding(0);
            this.CustomHeader.Name = "CustomHeader";
            this.CustomHeader.Size = new System.Drawing.Size(988, 31);
            this.CustomHeader.TabIndex = 12;
            // 
            // BorderlessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 524);
            this.Controls.Add(this.CustomHeader);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.LeftBorderPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.RightBorderPanel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BorderlessForm";
            this.Text = "Titlehjkl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopBorderPanel.ResumeLayout(false);
            this.BottomBorderPanel.ResumeLayout(false);
            this.TitleLeftButtons.ResumeLayout(false);
            this.TitleRightButtons.ResumeLayout(false);
            this.CustomHeader.ResumeLayout(false);
            this.CustomHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopLeftCornerPanel;
        private System.Windows.Forms.Panel TopRightCornerPanel;
        private System.Windows.Forms.Panel BottomLeftCornerPanel;
        private System.Windows.Forms.Panel BottomRightCornerPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel BottomBorderPanel;
        private System.Windows.Forms.Panel LeftBorderPanel;
        private System.Windows.Forms.Panel RightBorderPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ToolTip DecorationToolTip;
        private System.Windows.Forms.FlowLayoutPanel TitleLeftButtons;
        private System.Windows.Forms.FlowLayoutPanel TitleRightButtons;
        private System.Windows.Forms.Panel CustomHeader;
        protected Buttons.HeaderButton MaximizeButton;
        protected Buttons.HeaderButton CloseButton;
        protected Buttons.HeaderButton BackButton;
        protected Buttons.HeaderButton MinimizeButton;
    }
}

