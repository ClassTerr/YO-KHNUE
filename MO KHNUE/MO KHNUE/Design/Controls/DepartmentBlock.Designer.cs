namespace MO_KHNUE
{
    partial class DepartmentBlock
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
            this.countLabel = new System.Windows.Forms.Label();
            this.photoComponent1 = new MO_KHNUE.PhotoComponent();
            ((System.ComponentModel.ISupportInitialize)(this.photoComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(110, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(550, 110);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.countLabel.Location = new System.Drawing.Point(660, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(73, 110);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "2";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // photoComponent1
            // 
            this.photoComponent1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoComponent1.Dock = System.Windows.Forms.DockStyle.Left;
            this.photoComponent1.Location = new System.Drawing.Point(0, 0);
            this.photoComponent1.Margin = new System.Windows.Forms.Padding(4);
            this.photoComponent1.Name = "photoComponent1";
            this.photoComponent1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.photoComponent1.Size = new System.Drawing.Size(110, 110);
            this.photoComponent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoComponent1.TabIndex = 0;
            this.photoComponent1.TabStop = false;
            // 
            // DepartmentBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoComponent1);
            this.Controls.Add(this.countLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(733, 110);
            this.MinimumSize = new System.Drawing.Size(300, 110);
            this.Name = "DepartmentBlock";
            this.Size = new System.Drawing.Size(733, 110);
            ((System.ComponentModel.ISupportInitialize)(this.photoComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoComponent photoComponent1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countLabel;
    }
}
