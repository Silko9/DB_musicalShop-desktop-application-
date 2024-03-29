﻿namespace DB_musicalShop
{
    partial class FormTablePerformance
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
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCircumstances_execution = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataRecord = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(759, 508);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(243, 54);
            this.buttonUpdateTable.TabIndex = 54;
            this.buttonUpdateTable.Text = "Обновить таблицу";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 508);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 54);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(263, 508);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(243, 54);
            this.buttonChange.TabIndex = 52;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(511, 508);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(243, 54);
            this.buttonDelete.TabIndex = 51;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataPerformance
            // 
            this.dataPerformance.AllowUserToAddRows = false;
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataPerformance.Location = new System.Drawing.Point(12, 11);
            this.dataPerformance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPerformance.MultiSelect = false;
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.ReadOnly = true;
            this.dataPerformance.RowHeadersVisible = false;
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPerformance.Size = new System.Drawing.Size(823, 492);
            this.dataPerformance.TabIndex = 48;
            this.dataPerformance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Исполнения";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата исполнения";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ансамбль";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Произведение";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Обстоятельства исполнения";
            // 
            // boxCircumstances_execution
            // 
            this.boxCircumstances_execution.Location = new System.Drawing.Point(841, 37);
            this.boxCircumstances_execution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxCircumstances_execution.MaxLength = 200;
            this.boxCircumstances_execution.Name = "boxCircumstances_execution";
            this.boxCircumstances_execution.ReadOnly = true;
            this.boxCircumstances_execution.Size = new System.Drawing.Size(261, 147);
            this.boxCircumstances_execution.TabIndex = 66;
            this.boxCircumstances_execution.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataRecord);
            this.groupBox1.Controls.Add(this.buttonDeleteRecord);
            this.groupBox1.Controls.Add(this.buttonAddRecord);
            this.groupBox1.Location = new System.Drawing.Point(841, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(263, 310);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Записаны на пластинках";
            // 
            // dataRecord
            // 
            this.dataRecord.AllowUserToAddRows = false;
            this.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6});
            this.dataRecord.Location = new System.Drawing.Point(7, 22);
            this.dataRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRecord.MultiSelect = false;
            this.dataRecord.Name = "dataRecord";
            this.dataRecord.ReadOnly = true;
            this.dataRecord.RowHeadersVisible = false;
            this.dataRecord.RowHeadersWidth = 51;
            this.dataRecord.RowTemplate.Height = 24;
            this.dataRecord.Size = new System.Drawing.Size(243, 161);
            this.dataRecord.TabIndex = 34;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Номер пластинки";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(7, 247);
            this.buttonDeleteRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(243, 54);
            this.buttonDeleteRecord.TabIndex = 38;
            this.buttonDeleteRecord.Text = "Удалить";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(7, 188);
            this.buttonAddRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(243, 54);
            this.buttonAddRecord.TabIndex = 37;
            this.buttonAddRecord.Text = "Добавить";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // FormTablePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxCircumstances_execution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataPerformance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTablePerformance";
            this.Text = "Таблица исполнений";
            this.Shown += new System.EventHandler(this.FormTablePerformance_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox boxCircumstances_execution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataRecord;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}