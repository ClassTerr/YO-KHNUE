namespace MO_KHNUE
{
    partial class DepartmentsForm
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
            this.departmentBlockList1 = new MO_KHNUE.DepartmentBlockList();
            this.departmentInfoControl1 = new MO_KHNUE.DepartmentInfoControl();
            this.SuspendLayout();
            // 
            // departmentBlockList1
            // 
            this.departmentBlockList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentBlockList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentBlockList1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.departmentBlockList1.Location = new System.Drawing.Point(0, 0);
            this.departmentBlockList1.Margin = new System.Windows.Forms.Padding(4);
            this.departmentBlockList1.MinItemSize = 400;
            this.departmentBlockList1.Name = "departmentBlockList1";
            this.departmentBlockList1.OneColumn = false;
            this.departmentBlockList1.OnTypeSearch = true;
            this.departmentBlockList1.Selectable = true;
            this.departmentBlockList1.Size = new System.Drawing.Size(652, 466);
            this.departmentBlockList1.TabIndex = 0;
            this.departmentBlockList1.WithControlPanel = true;
            // 
            // departmentInfoControl1
            // 
            this.departmentInfoControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentInfoControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.departmentInfoControl1.Location = new System.Drawing.Point(652, 0);
            this.departmentInfoControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentInfoControl1.Name = "departmentInfoControl1";
            this.departmentInfoControl1.Size = new System.Drawing.Size(496, 466);
            this.departmentInfoControl1.TabIndex = 1;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 466);
            this.Controls.Add(this.departmentBlockList1);
            this.Controls.Add(this.departmentInfoControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentsForm";
            this.Text = "Отделы МО";
            this.ResumeLayout(false);

        }

        #endregion

        private DepartmentBlockList departmentBlockList1;
        private DepartmentInfoControl departmentInfoControl1;
    }
}