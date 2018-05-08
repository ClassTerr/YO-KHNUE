namespace MO_KHNUE
{
    partial class DepartmentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.headLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.membersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Глава";
            // 
            // headLinkLabel
            // 
            this.headLinkLabel.AutoSize = true;
            this.headLinkLabel.Location = new System.Drawing.Point(140, 51);
            this.headLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headLinkLabel.Name = "headLinkLabel";
            this.headLinkLabel.Size = new System.Drawing.Size(16, 17);
            this.headLinkLabel.TabIndex = 3;
            this.headLinkLabel.TabStop = true;
            this.headLinkLabel.Text = "[]";
            this.headLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.headLinkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Участники";
            // 
            // membersFlowLayout
            // 
            this.membersFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.membersFlowLayout.AutoScroll = true;
            this.membersFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membersFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.membersFlowLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membersFlowLayout.Location = new System.Drawing.Point(16, 98);
            this.membersFlowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.membersFlowLayout.Name = "membersFlowLayout";
            this.membersFlowLayout.Size = new System.Drawing.Size(612, 271);
            this.membersFlowLayout.TabIndex = 4;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 382);
            this.Controls.Add(this.membersFlowLayout);
            this.Controls.Add(this.headLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentForm";
            this.Text = "Отделы МО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel headLinkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel membersFlowLayout;
    }
}