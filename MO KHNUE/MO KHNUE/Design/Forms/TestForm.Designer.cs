namespace MO_KHNUE
{
    partial class TestForm
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
            this.memberBlockList1 = new MO_KHNUE.MemberBlockList();
            this.SuspendLayout();
            // 
            // memberBlockList1
            // 
            this.memberBlockList1.ClientSize = new System.Drawing.Size(661, 329);
            this.memberBlockList1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.memberBlockList1.Location = new System.Drawing.Point(73, 44);
            this.memberBlockList1.Margin = new System.Windows.Forms.Padding(4);
            this.memberBlockList1.MinItemSize = 400;
            this.memberBlockList1.Name = "memberBlockList1";
            this.memberBlockList1.OnTypeSearch = true;
            this.memberBlockList1.Selectable = true;
            this.memberBlockList1.WithControlPanel = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberBlockList1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MemberBlockList memberBlockList1;
    }
}