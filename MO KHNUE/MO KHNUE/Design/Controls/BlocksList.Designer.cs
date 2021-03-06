﻿namespace MO_KHNUE
{
    partial class BlocksList<T>
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.toolbox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.captionPanel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchField = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.iconButtonSmall1 = new MO_KHNUE.IconButtonSmall();
            this.controlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.toolbox);
            this.controlPanel.Controls.Add(this.panel1);
            this.controlPanel.Controls.Add(this.searchPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1092, 57);
            this.controlPanel.TabIndex = 5;
            // 
            // toolbox
            // 
            this.toolbox.AutoSize = true;
            this.toolbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolbox.Location = new System.Drawing.Point(6, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(0, 55);
            this.toolbox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.captionPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 55);
            this.panel1.TabIndex = 9;
            // 
            // captionPanel
            // 
            this.captionPanel.AutoSize = true;
            this.captionPanel.Location = new System.Drawing.Point(3, 14);
            this.captionPanel.Name = "captionPanel";
            this.captionPanel.Size = new System.Drawing.Size(0, 25);
            this.captionPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchField);
            this.searchPanel.Controls.Add(this.iconButtonSmall1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchPanel.Location = new System.Drawing.Point(785, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(305, 55);
            this.searchPanel.TabIndex = 6;
            // 
            // searchField
            // 
            this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchField.Location = new System.Drawing.Point(12, 11);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(249, 32);
            this.searchField.TabIndex = 0;
            this.searchField.TextChanged += new System.EventHandler(this.SearchBoxTyped);
            // 
            // table
            // 
            this.table.AutoScroll = true;
            this.table.ColumnCount = 6;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 57);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.Size = new System.Drawing.Size(1092, 259);
            this.table.TabIndex = 6;
            // 
            // iconButtonSmall1
            // 
            this.iconButtonSmall1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSmall1.AutoSize = true;
            this.iconButtonSmall1.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSmall1.Location = new System.Drawing.Point(257, 11);
            this.iconButtonSmall1.Name = "iconButtonSmall1";
            this.iconButtonSmall1.Size = new System.Drawing.Size(49, 34);
            this.iconButtonSmall1.TabIndex = 2;
            this.iconButtonSmall1.Text = "";
            this.iconButtonSmall1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlocksList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.table);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlocksList";
            this.Size = new System.Drawing.Size(1092, 316);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel controlPanel;
        public System.Windows.Forms.Panel searchPanel;
        public System.Windows.Forms.TextBox searchField;
        public System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel toolbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label captionPanel;
        private IconButtonSmall iconButtonSmall1;
    }
}
