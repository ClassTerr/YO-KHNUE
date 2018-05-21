namespace MO_KHNUE
{
    partial class DepartmentInfoControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButtonSmall6 = new MO_KHNUE.IconButtonSmall();
            this.outputLeader = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputMembersCount = new System.Windows.Forms.Label();
            this.iconButtonSmall5 = new MO_KHNUE.IconButtonSmall();
            this.iconButtonSmall2 = new MO_KHNUE.IconButtonSmall();
            this.headPanel = new System.Windows.Forms.Panel();
            this.editButton = new Borderless.Buttons.IconButton();
            this.photo = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // outputName
            // 
            this.outputName.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputName.Location = new System.Drawing.Point(0, 247);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(496, 130);
            this.outputName.TabIndex = 23;
            this.outputName.Text = "Department Name";
            this.outputName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.iconButtonSmall6);
            this.panel7.Controls.Add(this.outputLeader);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(496, 40);
            this.panel7.TabIndex = 18;
            // 
            // iconButtonSmall6
            // 
            this.iconButtonSmall6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall6.AutoSize = true;
            this.iconButtonSmall6.Font = new System.Drawing.Font("UI", 20F);
            this.iconButtonSmall6.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall6.Location = new System.Drawing.Point(120, 3);
            this.iconButtonSmall6.Name = "iconButtonSmall6";
            this.iconButtonSmall6.Size = new System.Drawing.Size(49, 34);
            this.iconButtonSmall6.TabIndex = 11;
            this.iconButtonSmall6.Text = "";
            this.iconButtonSmall6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLeader
            // 
            this.outputLeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputLeader.AutoSize = true;
            this.outputLeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLeader.Location = new System.Drawing.Point(178, 1);
            this.outputLeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLeader.Name = "outputLeader";
            this.outputLeader.Size = new System.Drawing.Size(196, 32);
            this.outputLeader.TabIndex = 13;
            this.outputLeader.Text = "Артем Баляница";
            this.outputLeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 377);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(496, 80);
            this.panel6.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.iconButtonSmall2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 40);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outputMembersCount);
            this.panel1.Controls.Add(this.iconButtonSmall5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 40);
            this.panel1.TabIndex = 12;
            // 
            // outputMembersCount
            // 
            this.outputMembersCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outputMembersCount.AutoSize = true;
            this.outputMembersCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputMembersCount.Location = new System.Drawing.Point(172, 4);
            this.outputMembersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputMembersCount.Name = "outputMembersCount";
            this.outputMembersCount.Size = new System.Drawing.Size(28, 32);
            this.outputMembersCount.TabIndex = 12;
            this.outputMembersCount.Text = "3";
            this.outputMembersCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButtonSmall5
            // 
            this.iconButtonSmall5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall5.AutoSize = true;
            this.iconButtonSmall5.Font = new System.Drawing.Font("UI", 20F);
            this.iconButtonSmall5.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall5.Location = new System.Drawing.Point(120, 3);
            this.iconButtonSmall5.Name = "iconButtonSmall5";
            this.iconButtonSmall5.Size = new System.Drawing.Size(45, 34);
            this.iconButtonSmall5.TabIndex = 11;
            this.iconButtonSmall5.Text = "";
            this.iconButtonSmall5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonSmall2
            // 
            this.iconButtonSmall2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSmall2.AutoSize = true;
            this.iconButtonSmall2.Font = new System.Drawing.Font("UI", 20F);
            this.iconButtonSmall2.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall2.Location = new System.Drawing.Point(120, 3);
            this.iconButtonSmall2.Name = "iconButtonSmall2";
            this.iconButtonSmall2.Size = new System.Drawing.Size(45, 34);
            this.iconButtonSmall2.TabIndex = 11;
            this.iconButtonSmall2.Text = "";
            this.iconButtonSmall2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.editButton);
            this.headPanel.Controls.Add(this.photo);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(496, 247);
            this.headPanel.TabIndex = 21;
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Font = new System.Drawing.Font("UI", 30F);
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(0, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(72, 50);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            // DepartmentInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.outputName);
            this.Controls.Add(this.headPanel);
            this.Name = "DepartmentInfoControl";
            this.Size = new System.Drawing.Size(496, 476);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputName;
        private IconButtonSmall iconButtonSmall6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label outputLeader;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label outputMembersCount;
        private IconButtonSmall iconButtonSmall5;
        private IconButtonSmall iconButtonSmall2;
        private Borderless.Buttons.IconButton editButton;
        public System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Panel headPanel;
    }
}
