﻿namespace _13_08_2020_do_oefeningen__2darray_
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
            this.btnOef1Btns = new System.Windows.Forms.Button();
            this.btnOef1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOef1Btns
            // 
            this.btnOef1Btns.Location = new System.Drawing.Point(171, 128);
            this.btnOef1Btns.Name = "btnOef1Btns";
            this.btnOef1Btns.Size = new System.Drawing.Size(154, 56);
            this.btnOef1Btns.TabIndex = 0;
            this.btnOef1Btns.Text = "Oefening 1 origineel idea";
            this.btnOef1Btns.UseVisualStyleBackColor = true;
            this.btnOef1Btns.Click += new System.EventHandler(this.btnOef1Btns_Click);
            // 
            // btnOef1
            // 
            this.btnOef1.Location = new System.Drawing.Point(171, 66);
            this.btnOef1.Name = "btnOef1";
            this.btnOef1.Size = new System.Drawing.Size(154, 56);
            this.btnOef1.TabIndex = 1;
            this.btnOef1.Text = "Oefening 1";
            this.btnOef1.UseVisualStyleBackColor = true;
            this.btnOef1.Click += new System.EventHandler(this.btnOef1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOef1);
            this.Controls.Add(this.btnOef1Btns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOef1Btns;
        private System.Windows.Forms.Button btnOef1;
    }
}

