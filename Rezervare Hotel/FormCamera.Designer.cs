namespace Rezervare_Hotel
{
    partial class FormCamera
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
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etajCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeTipCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.combonume = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butonmodifica = new Rezervare_Hotel.ButonR();
            this.butonR2 = new Rezervare_Hotel.ButonR();
            this.butonR1 = new Rezervare_Hotel.ButonR();
            this.textetajcam = new Rezervare_Hotel.TextBoxR();
            this.textnrcam = new Rezervare_Hotel.TextBoxR();
            this.cameraTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.CameraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).BeginInit();
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
            this.cod,
            this.nrCameraDataGridViewTextBoxColumn,
            this.etajCameraDataGridViewTextBoxColumn,
            this.numeTipCameraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cameraBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(284, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "Cod_Camera";
            this.cod.HeaderText = "Cod_Camera";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Visible = false;
            // 
            // nrCameraDataGridViewTextBoxColumn
            // 
            this.nrCameraDataGridViewTextBoxColumn.DataPropertyName = "Nr_Camera";
            this.nrCameraDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.nrCameraDataGridViewTextBoxColumn.Name = "nrCameraDataGridViewTextBoxColumn";
            this.nrCameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCameraDataGridViewTextBoxColumn.Width = 60;
            // 
            // etajCameraDataGridViewTextBoxColumn
            // 
            this.etajCameraDataGridViewTextBoxColumn.DataPropertyName = "Etaj_Camera";
            this.etajCameraDataGridViewTextBoxColumn.HeaderText = "Etaj";
            this.etajCameraDataGridViewTextBoxColumn.Name = "etajCameraDataGridViewTextBoxColumn";
            this.etajCameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.etajCameraDataGridViewTextBoxColumn.Width = 70;
            // 
            // numeTipCameraDataGridViewTextBoxColumn
            // 
            this.numeTipCameraDataGridViewTextBoxColumn.DataPropertyName = "Nume_TipCamera";
            this.numeTipCameraDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeTipCameraDataGridViewTextBoxColumn.Name = "numeTipCameraDataGridViewTextBoxColumn";
            this.numeTipCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cameraBindingSource
            // 
            this.cameraBindingSource.DataMember = "Camera";
            this.cameraBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combonume
            // 
            this.combonume.BackColor = System.Drawing.SystemColors.Control;
            this.combonume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combonume.FormattingEnabled = true;
            this.combonume.ItemHeight = 20;
            this.combonume.Location = new System.Drawing.Point(145, 241);
            this.combonume.Margin = new System.Windows.Forms.Padding(2);
            this.combonume.Name = "combonume";
            this.combonume.Size = new System.Drawing.Size(263, 28);
            this.combonume.TabIndex = 37;
            this.combonume.SelectedIndexChanged += new System.EventHandler(this.combonumetipcamera_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label9.Size = new System.Drawing.Size(108, 32);
            this.label9.TabIndex = 69;
            this.label9.Text = "Etaj Camera";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label8.Size = new System.Drawing.Size(122, 32);
            this.label8.TabIndex = 68;
            this.label8.Text = "Nume Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Numar Camera";
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
            this.butonmodifica.Location = new System.Drawing.Point(180, 329);
            this.butonmodifica.Margin = new System.Windows.Forms.Padding(2);
            this.butonmodifica.Name = "butonmodifica";
            this.butonmodifica.Size = new System.Drawing.Size(120, 41);
            this.butonmodifica.TabIndex = 73;
            this.butonmodifica.TextColor = System.Drawing.Color.White;
            this.butonmodifica.UseVisualStyleBackColor = false;
            this.butonmodifica.Click += new System.EventHandler(this.butonmodifica_Click);
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
            this.butonR2.Location = new System.Drawing.Point(318, 329);
            this.butonR2.Margin = new System.Windows.Forms.Padding(2);
            this.butonR2.Name = "butonR2";
            this.butonR2.Size = new System.Drawing.Size(90, 41);
            this.butonR2.TabIndex = 72;
            this.butonR2.TextColor = System.Drawing.Color.White;
            this.butonR2.UseVisualStyleBackColor = false;
            this.butonR2.Click += new System.EventHandler(this.butonR2_Click);
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
            this.butonR1.Location = new System.Drawing.Point(11, 329);
            this.butonR1.Margin = new System.Windows.Forms.Padding(2);
            this.butonR1.Name = "butonR1";
            this.butonR1.Size = new System.Drawing.Size(150, 41);
            this.butonR1.TabIndex = 66;
            this.butonR1.TextColor = System.Drawing.Color.White;
            this.butonR1.UseVisualStyleBackColor = false;
            this.butonR1.Click += new System.EventHandler(this.butonR1_Click);
            // 
            // textetajcam
            // 
            this.textetajcam.BackColor = System.Drawing.SystemColors.Control;
            this.textetajcam.BorderColor = System.Drawing.SystemColors.Control;
            this.textetajcam.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textetajcam.BorderRadius = 20;
            this.textetajcam.BorderSize = 2;
            this.textetajcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textetajcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textetajcam.Location = new System.Drawing.Point(145, 278);
            this.textetajcam.Margin = new System.Windows.Forms.Padding(4);
            this.textetajcam.Multiline = false;
            this.textetajcam.Name = "textetajcam";
            this.textetajcam.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textetajcam.PasswordChar = false;
            this.textetajcam.PlaceholderColor = System.Drawing.Color.Empty;
            this.textetajcam.PlaceholderText = "";
            this.textetajcam.Size = new System.Drawing.Size(263, 33);
            this.textetajcam.TabIndex = 63;
            this.textetajcam.UnderlinedStyle = false;
            // 
            // textnrcam
            // 
            this.textnrcam.BackColor = System.Drawing.SystemColors.Control;
            this.textnrcam.BorderColor = System.Drawing.SystemColors.Control;
            this.textnrcam.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textnrcam.BorderRadius = 20;
            this.textnrcam.BorderSize = 2;
            this.textnrcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnrcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textnrcam.Location = new System.Drawing.Point(145, 199);
            this.textnrcam.Margin = new System.Windows.Forms.Padding(4);
            this.textnrcam.Multiline = false;
            this.textnrcam.Name = "textnrcam";
            this.textnrcam.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textnrcam.PasswordChar = false;
            this.textnrcam.PlaceholderColor = System.Drawing.Color.Empty;
            this.textnrcam.PlaceholderText = "";
            this.textnrcam.Size = new System.Drawing.Size(263, 33);
            this.textnrcam.TabIndex = 61;
            this.textnrcam.UnderlinedStyle = false;
            // 
            // cameraTableAdapter
            // 
            this.cameraTableAdapter.ClearBeforeFill = true;
            // 
            // FormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 416);
            this.Controls.Add(this.butonmodifica);
            this.Controls.Add(this.butonR2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butonR1);
            this.Controls.Add(this.textetajcam);
            this.Controls.Add(this.textnrcam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combonume);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combonume;
        private ButonR butonmodifica;
        private ButonR butonR2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private ButonR butonR1;
        private TextBoxR textetajcam;
        private TextBoxR textnrcam;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CameraTableAdapter cameraTableAdapter;
        private System.Windows.Forms.BindingSource cameraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etajCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeTipCameraDataGridViewTextBoxColumn;
    }
}