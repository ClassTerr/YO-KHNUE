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
            this.components = new System.ComponentModel.Container();
            this.departmentHeadBlock = new MO_KHNUE.MemberBlock();
            this.memberBlocksListCurrent = new MO_KHNUE.MemberBlockList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.memberBlocksListAll = new MO_KHNUE.MemberBlockList();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.убратьИзОтделаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            // memberBlocksListCurrent
            // 
            this.memberBlocksListCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberBlocksListCurrent.AutoScroll = true;
            this.memberBlocksListCurrent.Caption = "Участники отдела";
            this.memberBlocksListCurrent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.memberBlocksListCurrent.Location = new System.Drawing.Point(4, 4);
            this.memberBlocksListCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.memberBlocksListCurrent.MinItemSize = 400;
            this.memberBlocksListCurrent.Name = "memberBlocksListCurrent";
            this.memberBlocksListCurrent.OneColumn = false;
            this.memberBlocksListCurrent.OnTypeSearch = true;
            this.memberBlocksListCurrent.Selectable = true;
            this.memberBlocksListCurrent.Size = new System.Drawing.Size(615, 513);
            this.memberBlocksListCurrent.TabIndex = 1;
            this.memberBlocksListCurrent.WithControlPanel = true;
            this.memberBlocksListCurrent.WithToolbox = true;
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
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.memberBlocksListCurrent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memberBlocksListAll, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 521);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // memberBlocksListAll
            // 
            this.memberBlocksListAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memberBlocksListAll.AutoScroll = true;
            this.memberBlocksListAll.Caption = "Добавить участника";
            this.memberBlocksListAll.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.memberBlocksListAll.Location = new System.Drawing.Point(627, 4);
            this.memberBlocksListAll.Margin = new System.Windows.Forms.Padding(4);
            this.memberBlocksListAll.MinItemSize = 400;
            this.memberBlocksListAll.Name = "memberBlocksListAll";
            this.memberBlocksListAll.OneColumn = false;
            this.memberBlocksListAll.OnTypeSearch = true;
            this.memberBlocksListAll.Selectable = true;
            this.memberBlocksListAll.Size = new System.Drawing.Size(616, 513);
            this.memberBlocksListAll.TabIndex = 1;
            this.memberBlocksListAll.WithControlPanel = true;
            this.memberBlocksListAll.WithToolbox = true;
            this.memberBlocksListAll.BlockDoubleClicked += new MO_KHNUE.BlockValueChangedHandler<MO_KHNUE.Entities.Member>(this.AddMember);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.убратьИзОтделаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 28);
            // 
            // убратьИзОтделаToolStripMenuItem
            // 
            this.убратьИзОтделаToolStripMenuItem.Name = "убратьИзОтделаToolStripMenuItem";
            this.убратьИзОтделаToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.убратьИзОтделаToolStripMenuItem.Text = "Убрать из отдела";
            // 
            // DepartmentControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentHeadBlock);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Name = "DepartmentControl";
            this.Size = new System.Drawing.Size(1247, 658);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemberBlock departmentHeadBlock;
        private MemberBlockList memberBlocksListCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MemberBlockList memberBlocksListAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem убратьИзОтделаToolStripMenuItem;
    }
}
