namespace Rezervare_Hotel
{
    partial class RezervareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervareForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textcodclient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textcodcamera = new System.Windows.Forms.TextBox();
            this.combonumeclient = new System.Windows.Forms.ComboBox();
            this.butonsterge = new System.Windows.Forms.Button();
            this.butonactualizeaza = new System.Windows.Forms.Button();
            this.butoninsereaza = new System.Windows.Forms.Button();
            this.checkoutdate = new System.Windows.Forms.DateTimePicker();
            this.checkindate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.combonrcamera = new System.Windows.Forms.ComboBox();
            this.combotipcamera = new System.Windows.Forms.ComboBox();
            this.textcodrezervare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textcodclient);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textcodcamera);
            this.tabPage1.Controls.Add(this.combonumeclient);
            this.tabPage1.Controls.Add(this.butonsterge);
            this.tabPage1.Controls.Add(this.butonactualizeaza);
            this.tabPage1.Controls.Add(this.butoninsereaza);
            this.tabPage1.Controls.Add(this.checkoutdate);
            this.tabPage1.Controls.Add(this.checkindate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.combonrcamera);
            this.tabPage1.Controls.Add(this.combotipcamera);
            this.tabPage1.Controls.Add(this.textcodrezervare);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meniu Rezervare";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // textcodclient
            // 
            this.textcodclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodclient.Location = new System.Drawing.Point(749, 38);
            this.textcodclient.Name = "textcodclient";
            this.textcodclient.ReadOnly = true;
            this.textcodclient.Size = new System.Drawing.Size(100, 30);
            this.textcodclient.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Cod Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(604, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Cod Camera";
            // 
            // textcodcamera
            // 
            this.textcodcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodcamera.Location = new System.Drawing.Point(749, 84);
            this.textcodcamera.Name = "textcodcamera";
            this.textcodcamera.ReadOnly = true;
            this.textcodcamera.Size = new System.Drawing.Size(100, 30);
            this.textcodcamera.TabIndex = 55;
            // 
            // combonumeclient
            // 
            this.combonumeclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combonumeclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonumeclient.FormattingEnabled = true;
            this.combonumeclient.Location = new System.Drawing.Point(368, 77);
            this.combonumeclient.Name = "combonumeclient";
            this.combonumeclient.Size = new System.Drawing.Size(120, 33);
            this.combonumeclient.TabIndex = 53;
            this.combonumeclient.SelectedIndexChanged += new System.EventHandler(this.combonumeclient_SelectedIndexChanged);
            // 
            // butonsterge
            // 
            this.butonsterge.Location = new System.Drawing.Point(490, 316);
            this.butonsterge.Name = "butonsterge";
            this.butonsterge.Size = new System.Drawing.Size(100, 100);
            this.butonsterge.TabIndex = 52;
            this.butonsterge.Text = "Sterge";
            this.butonsterge.UseVisualStyleBackColor = true;
            // 
            // butonactualizeaza
            // 
            this.butonactualizeaza.Location = new System.Drawing.Point(358, 316);
            this.butonactualizeaza.Name = "butonactualizeaza";
            this.butonactualizeaza.Size = new System.Drawing.Size(100, 100);
            this.butonactualizeaza.TabIndex = 51;
            this.butonactualizeaza.Text = "Actualizeaza";
            this.butonactualizeaza.UseVisualStyleBackColor = true;
            // 
            // butoninsereaza
            // 
            this.butoninsereaza.Location = new System.Drawing.Point(226, 316);
            this.butoninsereaza.Name = "butoninsereaza";
            this.butoninsereaza.Size = new System.Drawing.Size(100, 100);
            this.butoninsereaza.TabIndex = 50;
            this.butoninsereaza.Text = "Insereaza";
            this.butoninsereaza.UseVisualStyleBackColor = true;
            this.butoninsereaza.Click += new System.EventHandler(this.butoninsereaza_Click);
            // 
            // checkoutdate
            // 
            this.checkoutdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkoutdate.Location = new System.Drawing.Point(367, 257);
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.Size = new System.Drawing.Size(164, 30);
            this.checkoutdate.TabIndex = 16;
            // 
            // checkindate
            // 
            this.checkindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkindate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkindate.Location = new System.Drawing.Point(368, 216);
            this.checkindate.Name = "checkindate";
            this.checkindate.Size = new System.Drawing.Size(163, 30);
            this.checkindate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Checkout";
            // 
            // combonrcamera
            // 
            this.combonrcamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combonrcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonrcamera.FormattingEnabled = true;
            this.combonrcamera.Location = new System.Drawing.Point(368, 169);
            this.combonrcamera.Name = "combonrcamera";
            this.combonrcamera.Size = new System.Drawing.Size(121, 33);
            this.combonrcamera.TabIndex = 13;
            // 
            // combotipcamera
            // 
            this.combotipcamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotipcamera.FormattingEnabled = true;
            this.combotipcamera.Location = new System.Drawing.Point(368, 126);
            this.combotipcamera.Name = "combotipcamera";
            this.combotipcamera.Size = new System.Drawing.Size(120, 33);
            this.combotipcamera.TabIndex = 11;
            this.combotipcamera.SelectedIndexChanged += new System.EventHandler(this.combotipcamera_SelectedIndexChanged);
            // 
            // textcodrezervare
            // 
            this.textcodrezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodrezervare.Location = new System.Drawing.Point(368, 38);
            this.textcodrezervare.Name = "textcodrezervare";
            this.textcodrezervare.Size = new System.Drawing.Size(120, 30);
            this.textcodrezervare.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Checkin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nr Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Rezervare";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista Rezervari";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // RezervareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "RezervareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervareForm";
            this.Load += new System.EventHandler(this.RezervareForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker checkoutdate;
        private System.Windows.Forms.DateTimePicker checkindate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combonrcamera;
        private System.Windows.Forms.ComboBox combotipcamera;
        private System.Windows.Forms.TextBox textcodrezervare;
        private System.Windows.Forms.Button butonsterge;
        private System.Windows.Forms.Button butonactualizeaza;
        private System.Windows.Forms.Button butoninsereaza;
        private System.Windows.Forms.ComboBox combonumeclient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textcodcamera;
        private System.Windows.Forms.TextBox textcodclient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}