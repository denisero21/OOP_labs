﻿
namespace lab1
{
    partial class InstallmentForm
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
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.RequestButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BankBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PercentBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installment";
            // 
            // SumEdit
            // 
            this.SumEdit.Location = new System.Drawing.Point(86, 166);
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(195, 22);
            this.SumEdit.TabIndex = 1;
            // 
            // MonthsBox
            // 
            this.MonthsBox.FormattingEnabled = true;
            this.MonthsBox.Location = new System.Drawing.Point(86, 112);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(195, 24);
            this.MonthsBox.TabIndex = 2;
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(129, 267);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(109, 27);
            this.RequestButton.TabIndex = 3;
            this.RequestButton.Text = "Request";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sum";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 323);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 27);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BankBox
            // 
            this.BankBox.FormattingEnabled = true;
            this.BankBox.Location = new System.Drawing.Point(86, 65);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(198, 24);
            this.BankBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bank";
            // 
            // PercentBox
            // 
            this.PercentBox.FormattingEnabled = true;
            this.PercentBox.Location = new System.Drawing.Point(86, 222);
            this.PercentBox.Name = "PercentBox";
            this.PercentBox.Size = new System.Drawing.Size(195, 24);
            this.PercentBox.TabIndex = 11;
            // 
            // InstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 362);
            this.Controls.Add(this.PercentBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.MonthsBox);
            this.Controls.Add(this.SumEdit);
            this.Controls.Add(this.label1);
            this.Name = "InstallmentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.ComboBox MonthsBox;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox BankBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PercentBox;
    }
}