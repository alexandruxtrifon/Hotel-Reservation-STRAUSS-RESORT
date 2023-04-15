namespace Rezervare_Hotel
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textcodcamera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butonsterge = new System.Windows.Forms.Button();
            this.butonactualizeaza = new System.Windows.Forms.Button();
            this.butoninsereaza = new System.Windows.Forms.Button();
            this.textetajcamera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnrcamera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butontipcamera = new System.Windows.Forms.Button();
            this.combonumetipcamera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textcodcamera
            // 
            this.textcodcamera.Location = new System.Drawing.Point(981, 109);
            this.textcodcamera.Name = "textcodcamera";
            this.textcodcamera.ReadOnly = true;
            this.textcodcamera.Size = new System.Drawing.Size(100, 22);
            this.textcodcamera.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cod Camera";
            // 
            // butonsterge
            // 
            this.butonsterge.Location = new System.Drawing.Point(1061, 431);
            this.butonsterge.Name = "butonsterge";
            this.butonsterge.Size = new System.Drawing.Size(75, 75);
            this.butonsterge.TabIndex = 33;
            this.butonsterge.Text = "Sterge";
            this.butonsterge.UseVisualStyleBackColor = true;
            // 
            // butonactualizeaza
            // 
            this.butonactualizeaza.Location = new System.Drawing.Point(980, 431);
            this.butonactualizeaza.Name = "butonactualizeaza";
            this.butonactualizeaza.Size = new System.Drawing.Size(75, 75);
            this.butonactualizeaza.TabIndex = 32;
            this.butonactualizeaza.Text = "Actualizeaza";
            this.butonactualizeaza.UseVisualStyleBackColor = true;
            // 
            // butoninsereaza
            // 
            this.butoninsereaza.Location = new System.Drawing.Point(899, 431);
            this.butoninsereaza.Name = "butoninsereaza";
            this.butoninsereaza.Size = new System.Drawing.Size(75, 75);
            this.butoninsereaza.TabIndex = 31;
            this.butoninsereaza.Text = "Insereaza";
            this.butoninsereaza.UseVisualStyleBackColor = true;
            this.butoninsereaza.Click += new System.EventHandler(this.butoninsereaza_Click);
            // 
            // textetajcamera
            // 
            this.textetajcamera.Location = new System.Drawing.Point(981, 221);
            this.textetajcamera.Name = "textetajcamera";
            this.textetajcamera.Size = new System.Drawing.Size(100, 22);
            this.textetajcamera.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(856, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Etaj Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nume Tip Camera";
            // 
            // textnrcamera
            // 
            this.textnrcamera.Location = new System.Drawing.Point(981, 137);
            this.textnrcamera.Name = "textnrcamera";
            this.textnrcamera.Size = new System.Drawing.Size(100, 22);
            this.textnrcamera.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nr Camera";
            // 
            // butontipcamera
            // 
            this.butontipcamera.Location = new System.Drawing.Point(29, 431);
            this.butontipcamera.Name = "butontipcamera";
            this.butontipcamera.Size = new System.Drawing.Size(75, 75);
            this.butontipcamera.TabIndex = 36;
            this.butontipcamera.Text = "Tip Camera";
            this.butontipcamera.UseVisualStyleBackColor = true;
            this.butontipcamera.Click += new System.EventHandler(this.butontipcamera_Click);
            // 
            // combonumetipcamera
            // 
            this.combonumetipcamera.FormattingEnabled = true;
            this.combonumetipcamera.Location = new System.Drawing.Point(981, 193);
            this.combonumetipcamera.Name = "combonumetipcamera";
            this.combonumetipcamera.Size = new System.Drawing.Size(121, 24);
            this.combonumetipcamera.TabIndex = 37;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.combonumetipcamera);
            this.Controls.Add(this.butontipcamera);
            this.Controls.Add(this.textcodcamera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butonsterge);
            this.Controls.Add(this.butonactualizeaza);
            this.Controls.Add(this.butoninsereaza);
            this.Controls.Add(this.textetajcamera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnrcamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textcodcamera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butonsterge;
        private System.Windows.Forms.Button butonactualizeaza;
        private System.Windows.Forms.Button butoninsereaza;
        private System.Windows.Forms.TextBox textetajcamera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnrcamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butontipcamera;
        private System.Windows.Forms.ComboBox combonumetipcamera;
    }
}