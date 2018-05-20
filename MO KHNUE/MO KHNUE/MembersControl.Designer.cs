using MO_KHNUE.Entities;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberInfoControl1 = new MO_KHNUE.Entities.MemberInfoControl();
            this.memberBlocksList1 = new MO_KHNUE.MemberBlockList();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.memberBlocksList1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 720);
            this.panel1.TabIndex = 1;
            // 
            // memberInfoControl1
            // 
            this.memberInfoControl1.AutoScroll = true;
            this.memberInfoControl1.BackColor = System.Drawing.Color.White;
            this.memberInfoControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberInfoControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.memberInfoControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInfoControl1.Location = new System.Drawing.Point(836, 0);
            this.memberInfoControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.memberInfoControl1.Name = "memberInfoControl1";
            this.memberInfoControl1.Size = new System.Drawing.Size(486, 720);
            this.memberInfoControl1.TabIndex = 0;
            // 
            // memberBlocksList1
            // 
            this.memberBlocksList1.BackColor = System.Drawing.Color.White;
            this.memberBlocksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberBlocksList1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.memberBlocksList1.Location = new System.Drawing.Point(0, 0);
            this.memberBlocksList1.Margin = new System.Windows.Forms.Padding(5);
            this.memberBlocksList1.MinItemSize = 400;
            this.memberBlocksList1.Name = "memberBlocksList1";
            this.memberBlocksList1.OnTypeSearch = true;
            this.memberBlocksList1.Selectable = true;
            this.memberBlocksList1.Size = new System.Drawing.Size(836, 720);
            this.memberBlocksList1.TabIndex = 2;
            this.memberBlocksList1.WithControlPanel = true;
            this.memberBlocksList1.BlockClicked += new MO_KHNUE.BlockValueChangedHandler<MO_KHNUE.Entities.Member>(this.memberBlocksList1_MemberChanged);
            this.memberBlocksList1.ItemRemoveButtonClick += new MO_KHNUE.BlockValueChangedHandler<MO_KHNUE.Entities.Member>(this.RemoveMember);
            this.memberBlocksList1.ItemAddButtonClick += new MO_KHNUE.BlockValueChangedHandler<Member>(this.AddMember);
            // 
            // MembersControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.memberInfoControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MembersControl";
            this.Size = new System.Drawing.Size(1322, 720);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Entities.MemberInfoControl memberInfoControl1;
        private System.Windows.Forms.Panel panel1;
        private MemberBlockList memberBlocksList1;
    }
}
