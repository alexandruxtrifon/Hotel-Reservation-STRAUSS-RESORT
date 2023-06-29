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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCazareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlecareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeTipCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textpretcamera = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combonumeclient = new System.Windows.Forms.ComboBox();
            this.checkoutdate = new System.Windows.Forms.DateTimePicker();
            this.checkindate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.combonrcamera = new System.Windows.Forms.ComboBox();
            this.combotipcamera = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butonmodifica = new Rezervare_Hotel.ButonR();
            this.butonR2 = new Rezervare_Hotel.ButonR();
            this.butonR1 = new Rezervare_Hotel.ButonR();
            this.rezervareTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.RezervareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCameraDataGridViewTextBoxColumn,
            this.dataCazareDataGridViewTextBoxColumn,
            this.dataPlecareDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.receptionerDataGridViewTextBoxColumn,
            this.numeTipCameraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(284, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 156);
            this.dataGridView1.TabIndex = 84;
            // 
            // nrCameraDataGridViewTextBoxColumn
            // 
            this.nrCameraDataGridViewTextBoxColumn.DataPropertyName = "Nr_Camera";
            this.nrCameraDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.nrCameraDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.nrCameraDataGridViewTextBoxColumn.Name = "nrCameraDataGridViewTextBoxColumn";
            this.nrCameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCameraDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataCazareDataGridViewTextBoxColumn
            // 
            this.dataCazareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataCazareDataGridViewTextBoxColumn.DataPropertyName = "Data_Cazare";
            this.dataCazareDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.dataCazareDataGridViewTextBoxColumn.HeaderText = "Data_Cazare";
            this.dataCazareDataGridViewTextBoxColumn.Name = "dataCazareDataGridViewTextBoxColumn";
            this.dataCazareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPlecareDataGridViewTextBoxColumn
            // 
            this.dataPlecareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataPlecareDataGridViewTextBoxColumn.DataPropertyName = "Data_Plecare";
            this.dataPlecareDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.dataPlecareDataGridViewTextBoxColumn.HeaderText = "Data_Plecare";
            this.dataPlecareDataGridViewTextBoxColumn.Name = "dataPlecareDataGridViewTextBoxColumn";
            this.dataPlecareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptionerDataGridViewTextBoxColumn
            // 
            this.receptionerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionerDataGridViewTextBoxColumn.DataPropertyName = "Receptioner";
            this.receptionerDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.receptionerDataGridViewTextBoxColumn.HeaderText = "Receptioner";
            this.receptionerDataGridViewTextBoxColumn.Name = "receptionerDataGridViewTextBoxColumn";
            this.receptionerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeTipCameraDataGridViewTextBoxColumn
            // 
            this.numeTipCameraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeTipCameraDataGridViewTextBoxColumn.DataPropertyName = "Nume_TipCamera";
            this.numeTipCameraDataGridViewTextBoxColumn.FillWeight = 89.54315F;
            this.numeTipCameraDataGridViewTextBoxColumn.HeaderText = "Nume Camera";
            this.numeTipCameraDataGridViewTextBoxColumn.Name = "numeTipCameraDataGridViewTextBoxColumn";
            this.numeTipCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervareBindingSource
            // 
            this.rezervareBindingSource.DataMember = "Rezervare";
            this.rezervareBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(606, 230);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 121);
            this.listBox1.TabIndex = 83;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(359, 185);
            this.monthCalendar1.MaxSelectionCount = 99;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 82;
            // 
            // textpretcamera
            // 
            this.textpretcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpretcamera.Location = new System.Drawing.Point(123, 198);
            this.textpretcamera.Margin = new System.Windows.Forms.Padding(2);
            this.textpretcamera.Name = "textpretcamera";
            this.textpretcamera.ReadOnly = true;
            this.textpretcamera.Size = new System.Drawing.Size(123, 26);
            this.textpretcamera.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "Pret Camera";
            // 
            // combonumeclient
            // 
            this.combonumeclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combonumeclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonumeclient.FormattingEnabled = true;
            this.combonumeclient.Location = new System.Drawing.Point(123, 12);
            this.combonumeclient.Margin = new System.Windows.Forms.Padding(2);
            this.combonumeclient.Name = "combonumeclient";
            this.combonumeclient.Size = new System.Drawing.Size(123, 28);
            this.combonumeclient.TabIndex = 79;
            // 
            // checkoutdate
            // 
            this.checkoutdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkoutdate.Location = new System.Drawing.Point(122, 158);
            this.checkoutdate.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.Size = new System.Drawing.Size(124, 26);
            this.checkoutdate.TabIndex = 75;
            // 
            // checkindate
            // 
            this.checkindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkindate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkindate.Location = new System.Drawing.Point(123, 125);
            this.checkindate.Margin = new System.Windows.Forms.Padding(2);
            this.checkindate.Name = "checkindate";
            this.checkindate.Size = new System.Drawing.Size(123, 26);
            this.checkindate.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Checkout";
            // 
            // combonrcamera
            // 
            this.combonrcamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combonrcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonrcamera.FormattingEnabled = true;
            this.combonrcamera.Location = new System.Drawing.Point(123, 86);
            this.combonrcamera.Margin = new System.Windows.Forms.Padding(2);
            this.combonrcamera.Name = "combonrcamera";
            this.combonrcamera.Size = new System.Drawing.Size(123, 28);
            this.combonrcamera.TabIndex = 72;
            // 
            // combotipcamera
            // 
            this.combotipcamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combotipcamera.FormattingEnabled = true;
            this.combotipcamera.Location = new System.Drawing.Point(123, 51);
            this.combotipcamera.Margin = new System.Windows.Forms.Padding(2);
            this.combotipcamera.Name = "combotipcamera";
            this.combotipcamera.Size = new System.Drawing.Size(123, 28);
            this.combotipcamera.TabIndex = 71;
            this.combotipcamera.SelectedIndexChanged += new System.EventHandler(this.combotipcamera_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Checkin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Nr Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tip Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Nume Client";
            // 
            // butonmodifica
            // 
            this.butonmodifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.butonmodifica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.butonmodifica.BackgroundImage = global::Rezervare_Hotel.Properties.Resources.pencil;
            this.butonmodifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butonmodifica.BorderColor = System.Drawing.Color.Empty;
            this.butonmodifica.BorderRadius = 20;
            this.butonmodifica.BorderSize = 2;
            this.butonmodifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonmodifica.FlatAppearance.BorderSize = 0;
            this.butonmodifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonmodifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonmodifica.ForeColor = System.Drawing.Color.White;
            this.butonmodifica.Location = new System.Drawing.Point(11, 306);
            this.butonmodifica.Margin = new System.Windows.Forms.Padding(2);
            this.butonmodifica.Name = "butonmodifica";
            this.butonmodifica.Size = new System.Drawing.Size(244, 41);
            this.butonmodifica.TabIndex = 87;
            this.butonmodifica.TextColor = System.Drawing.Color.White;
            this.butonmodifica.UseVisualStyleBackColor = false;
            // 
            // butonR2
            // 
            this.butonR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butonR2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butonR2.BackgroundImage = global::Rezervare_Hotel.Properties.Resources.trash__1_;
            this.butonR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butonR2.BorderColor = System.Drawing.Color.Empty;
            this.butonR2.BorderRadius = 20;
            this.butonR2.BorderSize = 2;
            this.butonR2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonR2.FlatAppearance.BorderSize = 0;
            this.butonR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonR2.ForeColor = System.Drawing.Color.White;
            this.butonR2.Location = new System.Drawing.Point(165, 248);
            this.butonR2.Margin = new System.Windows.Forms.Padding(2);
            this.butonR2.Name = "butonR2";
            this.butonR2.Size = new System.Drawing.Size(90, 41);
            this.butonR2.TabIndex = 86;
            this.butonR2.TextColor = System.Drawing.Color.White;
            this.butonR2.UseVisualStyleBackColor = false;
            // 
            // butonR1
            // 
            this.butonR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BackgroundImage = global::Rezervare_Hotel.Properties.Resources.check;
            this.butonR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butonR1.BorderColor = System.Drawing.Color.Empty;
            this.butonR1.BorderRadius = 20;
            this.butonR1.BorderSize = 2;
            this.butonR1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonR1.FlatAppearance.BorderSize = 0;
            this.butonR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonR1.ForeColor = System.Drawing.Color.White;
            this.butonR1.Location = new System.Drawing.Point(11, 248);
            this.butonR1.Margin = new System.Windows.Forms.Padding(2);
            this.butonR1.Name = "butonR1";
            this.butonR1.Size = new System.Drawing.Size(150, 41);
            this.butonR1.TabIndex = 85;
            this.butonR1.TextColor = System.Drawing.Color.White;
            this.butonR1.UseVisualStyleBackColor = false;
            this.butonR1.Click += new System.EventHandler(this.butonR1_Click);
            // 
            // rezervareTableAdapter
            // 
            this.rezervareTableAdapter.ClearBeforeFill = true;
            // 
            // RezervareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 368);
            this.Controls.Add(this.butonmodifica);
            this.Controls.Add(this.butonR2);
            this.Controls.Add(this.butonR1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textpretcamera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combonumeclient);
            this.Controls.Add(this.checkoutdate);
            this.Controls.Add(this.checkindate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combonrcamera);
            this.Controls.Add(this.combotipcamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RezervareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RezervareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textpretcamera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combonumeclient;
        private System.Windows.Forms.DateTimePicker checkoutdate;
        private System.Windows.Forms.DateTimePicker checkindate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combonrcamera;
        private System.Windows.Forms.ComboBox combotipcamera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ButonR butonmodifica;
        private ButonR butonR2;
        private ButonR butonR1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private DataSet1TableAdapters.RezervareTableAdapter rezervareTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCazareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlecareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeTipCameraDataGridViewTextBoxColumn;
    }
}