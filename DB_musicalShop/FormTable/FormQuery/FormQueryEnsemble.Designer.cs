﻿namespace DB_musicalShop.FormTable.FormQuery
{
    partial class FormQueryEnsemble
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
            this.boxTypeEnsemble = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxTypeEnsemble
            // 
            this.boxTypeEnsemble.FormattingEnabled = true;
            this.boxTypeEnsemble.Location = new System.Drawing.Point(15, 84);
            this.boxTypeEnsemble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxTypeEnsemble.Name = "boxTypeEnsemble";
            this.boxTypeEnsemble.Size = new System.Drawing.Size(239, 24);
            this.boxTypeEnsemble.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Тип ансамбля";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(13, 124);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(243, 54);
            this.button.TabIndex = 45;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(15, 26);
            this.boxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxName.MaxLength = 20;
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(240, 22);
            this.boxName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Название ансамбля";
            // 
            // FormQueryEnsemble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 188);
            this.Controls.Add(this.boxTypeEnsemble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQueryEnsemble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQueryEnsemble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxTypeEnsemble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label1;
    }
}