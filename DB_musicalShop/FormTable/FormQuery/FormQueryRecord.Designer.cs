﻿namespace DB_musicalShop.FormTable.FormQuery
{
    partial class FormQueryRecord
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
            this.boxComposition = new System.Windows.Forms.ComboBox();
            this.numericWholesalePrice = new System.Windows.Forms.NumericUpDown();
            this.numericRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNumberRecord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericWholesalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetailPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // boxComposition
            // 
            this.boxComposition.FormattingEnabled = true;
            this.boxComposition.Location = new System.Drawing.Point(15, 192);
            this.boxComposition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxComposition.Name = "boxComposition";
            this.boxComposition.Size = new System.Drawing.Size(243, 24);
            this.boxComposition.TabIndex = 87;
            // 
            // numericWholesalePrice
            // 
            this.numericWholesalePrice.DecimalPlaces = 2;
            this.numericWholesalePrice.Location = new System.Drawing.Point(15, 137);
            this.numericWholesalePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericWholesalePrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericWholesalePrice.Name = "numericWholesalePrice";
            this.numericWholesalePrice.Size = new System.Drawing.Size(243, 22);
            this.numericWholesalePrice.TabIndex = 86;
            // 
            // numericRetailPrice
            // 
            this.numericRetailPrice.DecimalPlaces = 2;
            this.numericRetailPrice.Location = new System.Drawing.Point(15, 82);
            this.numericRetailPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericRetailPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericRetailPrice.Name = "numericRetailPrice";
            this.numericRetailPrice.Size = new System.Drawing.Size(243, 22);
            this.numericRetailPrice.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "Произведение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Розничная цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Оптовая цена";
            // 
            // boxNumberRecord
            // 
            this.boxNumberRecord.Location = new System.Drawing.Point(15, 30);
            this.boxNumberRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNumberRecord.MaxLength = 10;
            this.boxNumberRecord.Name = "boxNumberRecord";
            this.boxNumberRecord.Size = new System.Drawing.Size(243, 22);
            this.boxNumberRecord.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Номер пластинки";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(15, 223);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(243, 54);
            this.button.TabIndex = 88;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // FormQueryRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 284);
            this.Controls.Add(this.button);
            this.Controls.Add(this.boxComposition);
            this.Controls.Add(this.numericWholesalePrice);
            this.Controls.Add(this.numericRetailPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNumberRecord);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQueryRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQueryRecord";
            ((System.ComponentModel.ISupportInitialize)(this.numericWholesalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRetailPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxComposition;
        private System.Windows.Forms.NumericUpDown numericWholesalePrice;
        private System.Windows.Forms.NumericUpDown numericRetailPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNumberRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button;
    }
}