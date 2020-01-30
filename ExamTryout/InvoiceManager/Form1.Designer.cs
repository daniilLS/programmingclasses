namespace InvoiceManager
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
            this.Pathtexbox = new System.Windows.Forms.TextBox();
            this.readbutton = new System.Windows.Forms.Button();
            this.resultlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pathtexbox
            // 
            this.Pathtexbox.Location = new System.Drawing.Point(29, 25);
            this.Pathtexbox.Name = "Pathtexbox";
            this.Pathtexbox.Size = new System.Drawing.Size(516, 20);
            this.Pathtexbox.TabIndex = 0;
            this.Pathtexbox.Text = "C:\\Users\\W59920\\Desktop\\invoice.txt";
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(29, 65);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(75, 23);
            this.readbutton.TabIndex = 1;
            this.readbutton.Text = "Read";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.Readbutton_Click);
            // 
            // resultlable
            // 
            this.resultlable.AutoSize = true;
            this.resultlable.Location = new System.Drawing.Point(42, 121);
            this.resultlable.Name = "resultlable";
            this.resultlable.Size = new System.Drawing.Size(0, 13);
            this.resultlable.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 152);
            this.Controls.Add(this.resultlable);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.Pathtexbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pathtexbox;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Label resultlable;
    }
}

