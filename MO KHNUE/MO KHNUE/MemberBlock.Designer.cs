namespace MO_KHNUE
{
    partial class MemberBlock
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
            this.label1 = new System.Windows.Forms.Label();
            this.photoComponent1 = new MO_KHNUE.PhotoComponent();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(244, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Surname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // photoComponent1
            // 
            this.photoComponent1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoComponent1.Dock = System.Windows.Forms.DockStyle.Left;
            this.photoComponent1.Location = new System.Drawing.Point(0, 0);
            this.photoComponent1.Name = "photoComponent1";
            this.photoComponent1.Padding = new System.Windows.Forms.Padding(5);
            this.photoComponent1.Size = new System.Drawing.Size(56, 56);
            this.photoComponent1.TabIndex = 0;
            // 
            // MemberBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoComponent1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MemberBlock";
            this.Size = new System.Drawing.Size(300, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoComponent photoComponent1;
        private System.Windows.Forms.Label label1;
    }
}
