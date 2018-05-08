namespace MO_KHNUE
{
    partial class StyledForm
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
            this.Title = new System.Windows.Forms.Panel();
            this.TitleLeftButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.captionLabel = new System.Windows.Forms.Label();
            this.TitleRightButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.Controls.Add(this.TitleLeftButtons);
            this.Title.Controls.Add(this.captionLabel);
            this.Title.Controls.Add(this.TitleRightButtons);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 39);
            this.Title.TabIndex = 14;
            // 
            // TitleLeftButtons
            // 
            this.TitleLeftButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLeftButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TitleLeftButtons.Location = new System.Drawing.Point(0, 0);
            this.TitleLeftButtons.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLeftButtons.Name = "TitleLeftButtons";
            this.TitleLeftButtons.Size = new System.Drawing.Size(132, 39);
            this.TitleLeftButtons.TabIndex = 6;
            // 
            // captionLabel
            // 
            this.captionLabel.AutoEllipsis = true;
            this.captionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captionLabel.ForeColor = System.Drawing.Color.White;
            this.captionLabel.Location = new System.Drawing.Point(0, 0);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.captionLabel.Size = new System.Drawing.Size(668, 39);
            this.captionLabel.TabIndex = 5;
            this.captionLabel.Text = "Caption";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleRightButtons
            // 
            this.TitleRightButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleRightButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TitleRightButtons.Location = new System.Drawing.Point(668, 0);
            this.TitleRightButtons.Margin = new System.Windows.Forms.Padding(0);
            this.TitleRightButtons.Name = "TitleRightButtons";
            this.TitleRightButtons.Size = new System.Drawing.Size(132, 39);
            this.TitleRightButtons.TabIndex = 4;
            // 
            // StyledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(190, 30);
            this.Name = "StyledForm";
            this.Text = "StyledForm";
            this.Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.FlowLayoutPanel TitleRightButtons;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.FlowLayoutPanel TitleLeftButtons;
    }
}