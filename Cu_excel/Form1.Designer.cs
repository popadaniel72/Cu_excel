﻿
namespace Cu_excel
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
            this.cauta = new System.Windows.Forms.Button();
            this.od = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.li = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cauta
            // 
            this.cauta.Location = new System.Drawing.Point(12, 12);
            this.cauta.Name = "cauta";
            this.cauta.Size = new System.Drawing.Size(75, 23);
            this.cauta.TabIndex = 0;
            this.cauta.Text = "Cauta";
            this.cauta.UseVisualStyleBackColor = true;
            this.cauta.Click += new System.EventHandler(this.cauta_Click);
            // 
            // od
            // 
            this.od.Filter = "Fisier excel|*.xlsx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Extrage nume";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // li
            // 
            this.li.FormattingEnabled = true;
            this.li.ItemHeight = 16;
            this.li.Location = new System.Drawing.Point(12, 81);
            this.li.Name = "li";
            this.li.Size = new System.Drawing.Size(145, 324);
            this.li.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calcul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.li);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cauta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cauta;
        private System.Windows.Forms.OpenFileDialog od;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox li;
        private System.Windows.Forms.Button button2;
    }
}

