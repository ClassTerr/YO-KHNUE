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
            this.SuspendLayout();
            // 
            // memberInfoControl1
            // 
            this.memberInfoControl1.AutoScroll = true;
            this.memberInfoControl1.BackColor = System.Drawing.Color.White;
            this.memberInfoControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.memberInfoControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoControl1.Location = new System.Drawing.Point(538, 0);
            this.memberInfoControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberInfoControl1.Name = "memberInfoControl1";
            this.memberInfoControl1.Size = new System.Drawing.Size(457, 594);
            this.memberInfoControl1.TabIndex = 0;
            // 
            // MembersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberInfoControl1);
            this.Name = "MembersControl";
            this.Size = new System.Drawing.Size(995, 594);
            this.ResumeLayout(false);

        }

        #endregion

        private Entities.MemberInfoControl memberInfoControl1;
    }
}
