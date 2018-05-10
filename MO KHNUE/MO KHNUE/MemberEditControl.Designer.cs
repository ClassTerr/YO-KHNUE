namespace MO_KHNUE.Entities
{
    partial class MemberControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.outputBirthDay = new System.Windows.Forms.TextBox();
            this.outputEmail = new System.Windows.Forms.TextBox();
            this.outputPhone = new System.Windows.Forms.TextBox();
            this.outputGroup = new System.Windows.Forms.TextBox();
            this.outputName = new System.Windows.Forms.TextBox();
            this.outputSurname = new System.Windows.Forms.TextBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Группа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "Телефон";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 50);
            this.label8.TabIndex = 2;
            this.label8.Text = "Эл. Почта:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(4, 250);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 50);
            this.label11.TabIndex = 4;
            this.label11.Text = "Дата рождения:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputBirthDay, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.outputEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.outputPhone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputGroup, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputSurname, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(258, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 301);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // outputBirthDay
            // 
            this.outputBirthDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBirthDay.Location = new System.Drawing.Point(154, 250);
            this.outputBirthDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputBirthDay.Name = "outputBirthDay";
            this.outputBirthDay.Size = new System.Drawing.Size(191, 32);
            this.outputBirthDay.TabIndex = 5;
            this.outputBirthDay.Text = "[]";
            // 
            // outputEmail
            // 
            this.outputEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputEmail.Location = new System.Drawing.Point(154, 200);
            this.outputEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputEmail.Name = "outputEmail";
            this.outputEmail.Size = new System.Drawing.Size(191, 32);
            this.outputEmail.TabIndex = 3;
            this.outputEmail.Text = "[]";
            // 
            // outputPhone
            // 
            this.outputPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPhone.Location = new System.Drawing.Point(154, 150);
            this.outputPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPhone.Name = "outputPhone";
            this.outputPhone.Size = new System.Drawing.Size(191, 32);
            this.outputPhone.TabIndex = 3;
            this.outputPhone.Text = "[]";
            // 
            // outputGroup
            // 
            this.outputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputGroup.Location = new System.Drawing.Point(154, 100);
            this.outputGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(191, 32);
            this.outputGroup.TabIndex = 3;
            this.outputGroup.Text = "[]";
            // 
            // outputName
            // 
            this.outputName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputName.Location = new System.Drawing.Point(154, 0);
            this.outputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(191, 32);
            this.outputName.TabIndex = 2;
            this.outputName.Text = "[]";
            // 
            // outputSurname
            // 
            this.outputSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputSurname.Location = new System.Drawing.Point(154, 50);
            this.outputSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputSurname.Name = "outputSurname";
            this.outputSurname.Size = new System.Drawing.Size(191, 32);
            this.outputSurname.TabIndex = 3;
            this.outputSurname.Text = "[]";
            // 
            // photo
            // 
            this.photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photo.Image = global::MO_KHNUE.Properties.Resources.UserImagePlaceholder;
            this.photo.Location = new System.Drawing.Point(7, 55);
            this.photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(193, 194);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 6;
            this.photo.TabStop = false;
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.photo);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(717, 596);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outputSurname;
        private System.Windows.Forms.TextBox outputGroup;
        private System.Windows.Forms.TextBox outputPhone;
        private System.Windows.Forms.TextBox outputEmail;
        private System.Windows.Forms.TextBox outputBirthDay;
        private System.Windows.Forms.TextBox outputName;
        public System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}