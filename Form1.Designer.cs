using System;
using System.Drawing;

namespace AgeCalculator
{
    partial class Form1
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
            this.button_GetAge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_GetAge
            // 
            this.button_GetAge.Font = new System.Drawing.Font("HarmonyOS Sans SC Medium", 9F);
            this.button_GetAge.Location = new System.Drawing.Point(163, 157);
            this.button_GetAge.Name = "button_GetAge";
            this.button_GetAge.Size = new System.Drawing.Size(111, 40);
            this.button_GetAge.TabIndex = 0;
            this.button_GetAge.Text = "计算年龄";
            this.button_GetAge.UseVisualStyleBackColor = true;
            this.button_GetAge.Click += new System.EventHandler(this.buttonClick1_GetAge);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans SC Medium", 10F);
            this.label1.Location = new System.Drawing.Point(140, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入您的年龄:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HarmonyOS Sans SC Medium", 15F);
            this.label2.Location = new System.Drawing.Point(81, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "欢迎使用年龄计算器! :-)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 255);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_GetAge);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "AgeCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button_GetAge;
        
        #endregion
    }

}