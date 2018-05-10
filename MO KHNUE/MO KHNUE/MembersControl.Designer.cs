namespace MO_KHNUE
{
    partial class MembersControl
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
            this.memberInfoControl1 = new MO_KHNUE.Entities.MemberInfoControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberBlocksList1 = new MO_KHNUE.MemberBlocksList();
            this.toolbox = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new Borderless.Buttons.IconButton();
            this.iconButton2 = new Borderless.Buttons.IconButton();
            this.panel1.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberInfoControl1
            // 
            this.memberInfoControl1.AutoScroll = true;
            this.memberInfoControl1.BackColor = System.Drawing.Color.White;
            this.memberInfoControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberInfoControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.memberInfoControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoControl1.Location = new System.Drawing.Point(846, 0);
            this.memberInfoControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.memberInfoControl1.Name = "memberInfoControl1";
            this.memberInfoControl1.Size = new System.Drawing.Size(481, 731);
            this.memberInfoControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memberBlocksList1);
            this.panel1.Controls.Add(this.toolbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 731);
            this.panel1.TabIndex = 1;
            // 
            // memberBlocksList1
            // 
            this.memberBlocksList1.BackColor = System.Drawing.Color.White;
            this.memberBlocksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberBlocksList1.Location = new System.Drawing.Point(0, 63);
            this.memberBlocksList1.Margin = new System.Windows.Forms.Padding(5);
            this.memberBlocksList1.MinItemSize = 300;
            this.memberBlocksList1.Name = "memberBlocksList1";
            this.memberBlocksList1.Size = new System.Drawing.Size(846, 668);
            this.memberBlocksList1.TabIndex = 2;
            this.memberBlocksList1.MemberChanged += new MO_KHNUE.MemberBlocksList.MemberChangedHandler(this.memberBlocksList1_MemberChanged);
            // 
            // toolbox
            // 
            this.toolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbox.Controls.Add(this.iconButton1);
            this.toolbox.Controls.Add(this.iconButton2);
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(846, 63);
            this.toolbox.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.Location = new System.Drawing.Point(3, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(64, 50);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.AutoSize = true;
            this.iconButton2.Font = new System.Drawing.Font("UI", 30F);
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.Location = new System.Drawing.Point(73, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(63, 50);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MembersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.memberInfoControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MembersControl";
            this.Size = new System.Drawing.Size(1327, 731);
            this.panel1.ResumeLayout(false);
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Entities.MemberInfoControl memberInfoControl1;
        private System.Windows.Forms.Panel panel1;
        private MemberBlocksList memberBlocksList1;
        private System.Windows.Forms.FlowLayoutPanel toolbox;
        private Borderless.Buttons.IconButton iconButton1;
        private Borderless.Buttons.IconButton iconButton2;
    }
}
