﻿namespace Basicapp
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
            this.startbutton = new System.Windows.Forms.Button();
            this.massagelable = new System.Windows.Forms.Label();
            this.guessinput = new System.Windows.Forms.TextBox();
            this.guessbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(27, 28);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(107, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "New game";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // massagelable
            // 
            this.massagelable.AutoSize = true;
            this.massagelable.Location = new System.Drawing.Point(24, 87);
            this.massagelable.Name = "massagelable";
            this.massagelable.Size = new System.Drawing.Size(35, 13);
            this.massagelable.TabIndex = 1;
            this.massagelable.Text = "label1";
            // 
            // guessinput
            // 
            this.guessinput.Enabled = false;
            this.guessinput.Location = new System.Drawing.Point(35, 129);
            this.guessinput.Name = "guessinput";
            this.guessinput.Size = new System.Drawing.Size(100, 20);
            this.guessinput.TabIndex = 2;
            this.guessinput.TextChanged += new System.EventHandler(this.guessinput_TextChanged);
            // 
            // guessbutton
            // 
            this.guessbutton.Enabled = false;
            this.guessbutton.Location = new System.Drawing.Point(165, 129);
            this.guessbutton.Name = "guessbutton";
            this.guessbutton.Size = new System.Drawing.Size(85, 20);
            this.guessbutton.TabIndex = 3;
            this.guessbutton.Text = "Guess";
            this.guessbutton.UseVisualStyleBackColor = true;
            this.guessbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guessbutton);
            this.Controls.Add(this.guessinput);
            this.Controls.Add(this.massagelable);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "Guessing game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label massagelable;
        private System.Windows.Forms.TextBox guessinput;
        private System.Windows.Forms.Button guessbutton;
    }
}

