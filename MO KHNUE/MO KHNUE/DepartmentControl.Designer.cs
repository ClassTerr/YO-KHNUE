namespace MO_KHNUE
{
    partial class DepartmentControl
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
            this.departmentHeadBlock = new MO_KHNUE.MemberBlock();
            this.memberBlocksList1 = new MO_KHNUE.MemberBlockList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departmentHeadBlock
            // 
            this.departmentHeadBlock.BackColor = System.Drawing.Color.White;
            this.departmentHeadBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departmentHeadBlock.ForeColor = System.Drawing.Color.Black;
            this.departmentHeadBlock.Location = new System.Drawing.Point(0, 40);
            this.departmentHeadBlock.Margin = new System.Windows.Forms.Padding(4);
            this.departmentHeadBlock.MaximumSize = new System.Drawing.Size(733, 90);
            this.departmentHeadBlock.MinimumSize = new System.Drawing.Size(300, 90);
            this.departmentHeadBlock.Name = "departmentHeadBlock";
            this.departmentHeadBlock.Selectable = false;
            this.departmentHeadBlock.Selected = false;
            this.departmentHeadBlock.Size = new System.Drawing.Size(412, 90);
            this.departmentHeadBlock.TabIndex = 0;
            this.departmentHeadBlock.Value = null;
            // 
            // memberBlocksList1
            // 
            this.memberBlocksList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberBlocksList1.AutoScroll = true;
            this.memberBlocksList1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.memberBlocksList1.Location = new System.Drawing.Point(0, 226);
            this.memberBlocksList1.Margin = new System.Windows.Forms.Padding(4);
            this.memberBlocksList1.MinItemSize = 400;
            this.memberBlocksList1.Name = "memberBlocksList1";
            this.memberBlocksList1.OnTypeSearch = true;
            this.memberBlocksList1.Selectable = true;
            this.memberBlocksList1.Size = new System.Drawing.Size(1283, 254);
            this.memberBlocksList1.TabIndex = 1;
            this.memberBlocksList1.WithControlPanel = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Глава отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Участники отдела";
            // 
            // DepartmentControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberBlocksList1);
            this.Controls.Add(this.departmentHeadBlock);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Name = "DepartmentControl";
            this.Size = new System.Drawing.Size(1287, 484);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemberBlock departmentHeadBlock;
        private MemberBlockList memberBlocksList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
