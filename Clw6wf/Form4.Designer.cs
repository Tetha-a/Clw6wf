﻿namespace Clw6wf
{
    partial class Form4
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
            this.textBoxKatA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKatB = new System.Windows.Forms.TextBox();
            this.textBoxGep = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Катет А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Катет Б";
            // 
            // textBoxKatA
            // 
            this.textBoxKatA.Location = new System.Drawing.Point(191, 140);
            this.textBoxKatA.Name = "textBoxKatA";
            this.textBoxKatA.Size = new System.Drawing.Size(100, 20);
            this.textBoxKatA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Гипотенуза";
            // 
            // textBoxKatB
            // 
            this.textBoxKatB.Location = new System.Drawing.Point(191, 189);
            this.textBoxKatB.Name = "textBoxKatB";
            this.textBoxKatB.Size = new System.Drawing.Size(100, 20);
            this.textBoxKatB.TabIndex = 4;
            // 
            // textBoxGep
            // 
            this.textBoxGep.Location = new System.Drawing.Point(191, 241);
            this.textBoxGep.Name = "textBoxGep";
            this.textBoxGep.Size = new System.Drawing.Size(100, 20);
            this.textBoxGep.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(640, 388);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(148, 50);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "В начальное меню";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(440, 143);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(105, 43);
            this.buttonResult.TabIndex = 7;
            this.buttonResult.Text = "Решить";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(440, 220);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 41);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxGep);
            this.Controls.Add(this.textBoxKatB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKatA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Теорема пифагора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKatA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKatB;
        private System.Windows.Forms.TextBox textBoxGep;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonClear;
    }
}