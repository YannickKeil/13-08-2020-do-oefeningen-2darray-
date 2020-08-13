namespace Joepie2DArrays
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
            this.cbTafel = new System.Windows.Forms.ComboBox();
            this.lblTafel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTafel
            // 
            this.cbTafel.FormattingEnabled = true;
            this.cbTafel.Location = new System.Drawing.Point(13, 13);
            this.cbTafel.Name = "cbTafel";
            this.cbTafel.Size = new System.Drawing.Size(121, 21);
            this.cbTafel.TabIndex = 0;
            this.cbTafel.SelectedIndexChanged += new System.EventHandler(this.cbTafel_SelectedIndexChanged);
            // 
            // lblTafel
            // 
            this.lblTafel.AutoSize = true;
            this.lblTafel.Location = new System.Drawing.Point(13, 41);
            this.lblTafel.Name = "lblTafel";
            this.lblTafel.Size = new System.Drawing.Size(13, 13);
            this.lblTafel.TabIndex = 1;
            this.lblTafel.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTafel);
            this.Controls.Add(this.cbTafel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTafel;
        private System.Windows.Forms.Label lblTafel;
    }
}

