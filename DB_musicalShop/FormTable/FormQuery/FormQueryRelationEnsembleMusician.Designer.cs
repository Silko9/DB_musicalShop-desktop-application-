﻿namespace DB_musicalShop.FormTable.FormQuery
{
    partial class FormQueryRelationEnsembleMusician
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
            this.button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxMusician = new System.Windows.Forms.ComboBox();
            this.boxEnsemble = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(15, 116);
            this.button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(243, 54);
            this.button.TabIndex = 59;
            this.button.Text = "Добавить связь";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Музыкант";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ансамбль";
            // 
            // boxMusician
            // 
            this.boxMusician.FormattingEnabled = true;
            this.boxMusician.Location = new System.Drawing.Point(15, 85);
            this.boxMusician.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxMusician.Name = "boxMusician";
            this.boxMusician.Size = new System.Drawing.Size(241, 24);
            this.boxMusician.TabIndex = 56;
            // 
            // boxEnsemble
            // 
            this.boxEnsemble.FormattingEnabled = true;
            this.boxEnsemble.Location = new System.Drawing.Point(15, 28);
            this.boxEnsemble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxEnsemble.Name = "boxEnsemble";
            this.boxEnsemble.Size = new System.Drawing.Size(241, 24);
            this.boxEnsemble.TabIndex = 55;
            // 
            // FormQueryRelationEnsembleMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 180);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxMusician);
            this.Controls.Add(this.boxEnsemble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQueryRelationEnsembleMusician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление связи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxMusician;
        private System.Windows.Forms.ComboBox boxEnsemble;
    }
}