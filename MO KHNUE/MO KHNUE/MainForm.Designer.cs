namespace MO_KHNUE
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconButton4 = new Borderless.Buttons.IconButton();
            this.iconButton3 = new Borderless.Buttons.IconButton();
            this.iconButton2 = new Borderless.Buttons.IconButton();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new Borderless.Buttons.IconButton();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.AutoSize = true;
            this.iconButton4.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.Location = new System.Drawing.Point(0, 100);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(72, 50);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.iconButton4, "События");
            this.iconButton4.Click += new System.EventHandler(this.pictureBox3_Click);
            this.iconButton4.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.iconButton4.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.iconButton4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconButton1_MouseUp);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.AutoSize = true;
            this.iconButton3.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton3.ForeColor = System.Drawing.Color.Black;
            this.iconButton3.Location = new System.Drawing.Point(0, 50);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(67, 50);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.iconButton3, "Отделы");
            this.iconButton3.Click += new System.EventHandler(this.pictureBox2_Click);
            this.iconButton3.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.iconButton3.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.iconButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconButton1_MouseUp);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.AutoSize = true;
            this.iconButton2.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(72, 50);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.iconButton2, "Общая сводка");
            this.iconButton2.Click += new System.EventHandler(this.ShowOverview);
            this.iconButton2.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.iconButton2.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.iconButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconButton1_MouseUp);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.DimGray;
            this.controlPanel.Controls.Add(this.logoPictureBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(75, 37);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1135, 576);
            this.controlPanel.TabIndex = 15;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Enabled = false;
            this.logoPictureBox.Image = global::MO_KHNUE.Properties.Resources.MO_LOGO;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(1135, 576);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.AutoSize = true;
            this.iconButton1.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.Location = new System.Drawing.Point(0, 150);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(66, 50);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iconButton1.Click += new System.EventHandler(this.ShowMembers);
            this.iconButton1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.iconButton1.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.iconButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconButton1_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.iconButton2);
            this.menuPanel.Controls.Add(this.iconButton3);
            this.menuPanel.Controls.Add(this.iconButton4);
            this.menuPanel.Controls.Add(this.iconButton1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(3, 37);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(72, 576);
            this.menuPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 615);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.menuPanel, 0);
            this.Controls.SetChildIndex(this.controlPanel, 0);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private Borderless.Buttons.IconButton iconButton1;
        private Borderless.Buttons.IconButton iconButton4;
        private Borderless.Buttons.IconButton iconButton3;
        private Borderless.Buttons.IconButton iconButton2;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
    }
}



