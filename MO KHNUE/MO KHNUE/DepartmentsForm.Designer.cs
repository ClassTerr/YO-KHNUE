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
            this.memberBlocksList1 = new MO_KHNUE.MemberBlockList();
            this.SuspendLayout();
            // 
            // memberBlocksList1
            // 
            this.memberBlocksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberBlocksList1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.memberBlocksList1.Location = new System.Drawing.Point(0, 0);
            this.memberBlocksList1.Margin = new System.Windows.Forms.Padding(4);
            this.memberBlocksList1.MinItemSize = 400;
            this.memberBlocksList1.Name = "memberBlocksList1";
            this.memberBlocksList1.OnTypeSearch = true;
            this.memberBlocksList1.Selectable = true;
            this.memberBlocksList1.Size = new System.Drawing.Size(968, 425);
            this.memberBlocksList1.TabIndex = 0;
            this.memberBlocksList1.WithControlPanel = true;
            // 
            // DepartmentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 425);
            this.Controls.Add(this.memberBlocksList1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentsForm";
            this.Text = "Отделы МО";
            this.ResumeLayout(false);

        }

        #endregion

        private MemberBlockList memberBlocksList1;
    }
}