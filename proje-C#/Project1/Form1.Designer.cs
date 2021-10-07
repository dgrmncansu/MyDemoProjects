namespace Project1
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
            this.btnHesap = new System.Windows.Forms.Button();
            this.tbVergi = new System.Windows.Forms.TextBox();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(200, 40);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            // 
            // tbVergi
            // 
            this.tbVergi.Location = new System.Drawing.Point(85, 40);
            this.tbVergi.Name = "tbVergi";
            this.tbVergi.Size = new System.Drawing.Size(100, 20);
            this.tbVergi.TabIndex = 1;
            this.tbVergi.TextChanged += new System.EventHandler(this.tbVergi_TextChanged);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(129, 88);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(103, 13);
            this.lbSonuc.TabIndex = 2;
            this.lbSonuc.Text = "Daha Hesaplanmadi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.tbVergi);
            this.Controls.Add(this.btnHesap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.TextBox tbVergi;
        private System.Windows.Forms.Label lbSonuc;
    }
}