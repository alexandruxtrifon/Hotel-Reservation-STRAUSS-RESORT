namespace Rezervare_Hotel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butonclienti = new System.Windows.Forms.Button();
            this.butoncamere = new System.Windows.Forms.Button();
            this.panoujos = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.butonrezervari = new System.Windows.Forms.Button();
            this.butoncheckin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.butondelogare = new System.Windows.Forms.Button();
            this.panoujos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(725, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(725, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(725, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(725, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butonclienti
            // 
            this.butonclienti.Location = new System.Drawing.Point(75, 0);
            this.butonclienti.Name = "butonclienti";
            this.butonclienti.Size = new System.Drawing.Size(75, 75);
            this.butonclienti.TabIndex = 2;
            this.butonclienti.Text = "clienti";
            this.butonclienti.UseVisualStyleBackColor = true;
            this.butonclienti.Click += new System.EventHandler(this.butonclienti_Click);
            // 
            // butoncamere
            // 
            this.butoncamere.Location = new System.Drawing.Point(0, 0);
            this.butoncamere.Name = "butoncamere";
            this.butoncamere.Size = new System.Drawing.Size(75, 75);
            this.butoncamere.TabIndex = 1;
            this.butoncamere.Text = "camere";
            this.butoncamere.UseVisualStyleBackColor = true;
            this.butoncamere.Click += new System.EventHandler(this.button2_Click);
            // 
            // panoujos
            // 
            this.panoujos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panoujos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panoujos.Controls.Add(this.butondelogare);
            this.panoujos.Controls.Add(this.button6);
            this.panoujos.Controls.Add(this.butoncheckin);
            this.panoujos.Controls.Add(this.butonrezervari);
            this.panoujos.Controls.Add(this.butonclienti);
            this.panoujos.Controls.Add(this.butoncamere);
            this.panoujos.Location = new System.Drawing.Point(0, 378);
            this.panoujos.Name = "panoujos";
            this.panoujos.Size = new System.Drawing.Size(882, 75);
            this.panoujos.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // butonrezervari
            // 
            this.butonrezervari.Location = new System.Drawing.Point(150, 0);
            this.butonrezervari.Name = "butonrezervari";
            this.butonrezervari.Size = new System.Drawing.Size(75, 75);
            this.butonrezervari.TabIndex = 7;
            this.butonrezervari.Text = "rezervari";
            this.butonrezervari.UseVisualStyleBackColor = true;
            // 
            // butoncheckin
            // 
            this.butoncheckin.Location = new System.Drawing.Point(225, 0);
            this.butoncheckin.Name = "butoncheckin";
            this.butoncheckin.Size = new System.Drawing.Size(75, 75);
            this.butoncheckin.TabIndex = 8;
            this.butoncheckin.Text = "check-in";
            this.butoncheckin.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(300, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // butondelogare
            // 
            this.butondelogare.Location = new System.Drawing.Point(375, 0);
            this.butondelogare.Name = "butondelogare";
            this.butondelogare.Size = new System.Drawing.Size(75, 75);
            this.butondelogare.TabIndex = 10;
            this.butondelogare.Text = "delogare";
            this.butondelogare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panoujos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panoujos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butoncamere;
        private System.Windows.Forms.Button butonclienti;
        private System.Windows.Forms.Panel panoujos;
        private System.Windows.Forms.Button butondelogare;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button butoncheckin;
        private System.Windows.Forms.Button butonrezervari;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

