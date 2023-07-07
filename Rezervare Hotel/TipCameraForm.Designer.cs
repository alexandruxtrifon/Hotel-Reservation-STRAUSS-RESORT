namespace Rezervare_Hotel
{
    partial class TipCameraForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.textnumetipcamera = new Rezervare_Hotel.TextBoxR();
            this.butonR2 = new Rezervare_Hotel.ButonR();
            this.butonR1 = new Rezervare_Hotel.ButonR();
            this.label5 = new System.Windows.Forms.Label();
            this.textprettipcamera = new Rezervare_Hotel.TextBoxR();
            this.label7 = new System.Windows.Forms.Label();
            this.textcapacitatetipcamera = new Rezervare_Hotel.TextBoxR();
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.tipCameraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipCameraTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.TipCameraTableAdapter();
            this.codTipCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeTipCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretTipCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitateTipCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipCameraDataGridViewTextBoxColumn,
            this.numeTipCameraDataGridViewTextBoxColumn,
            this.pretTipCameraDataGridViewTextBoxColumn,
            this.capacitateTipCameraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipCameraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(417, 157);
            this.dataGridView1.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 69;
            this.label4.Text = "Nume";
            // 
            // textnumetipcamera
            // 
            this.textnumetipcamera.BackColor = System.Drawing.SystemColors.Control;
            this.textnumetipcamera.BorderColor = System.Drawing.SystemColors.Control;
            this.textnumetipcamera.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textnumetipcamera.BorderRadius = 20;
            this.textnumetipcamera.BorderSize = 2;
            this.textnumetipcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumetipcamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textnumetipcamera.Location = new System.Drawing.Point(133, 184);
            this.textnumetipcamera.Margin = new System.Windows.Forms.Padding(4);
            this.textnumetipcamera.Multiline = false;
            this.textnumetipcamera.Name = "textnumetipcamera";
            this.textnumetipcamera.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textnumetipcamera.PasswordChar = false;
            this.textnumetipcamera.PlaceholderColor = System.Drawing.Color.Empty;
            this.textnumetipcamera.PlaceholderText = "";
            this.textnumetipcamera.Size = new System.Drawing.Size(263, 33);
            this.textnumetipcamera.TabIndex = 68;
            this.textnumetipcamera.UnderlinedStyle = false;
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
            this.butonR2.Location = new System.Drawing.Point(269, 316);
            this.butonR2.Margin = new System.Windows.Forms.Padding(2);
            this.butonR2.Name = "butonR2";
            this.butonR2.Size = new System.Drawing.Size(127, 41);
            this.butonR2.TabIndex = 88;
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
            this.butonR1.Location = new System.Drawing.Point(39, 316);
            this.butonR1.Margin = new System.Windows.Forms.Padding(2);
            this.butonR1.Name = "butonR1";
            this.butonR1.Size = new System.Drawing.Size(226, 41);
            this.butonR1.TabIndex = 87;
            this.butonR1.TextColor = System.Drawing.Color.White;
            this.butonR1.UseVisualStyleBackColor = false;
            this.butonR1.Click += new System.EventHandler(this.butonR1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label5.Size = new System.Drawing.Size(42, 32);
            this.label5.TabIndex = 90;
            this.label5.Text = "Pret";
            // 
            // textprettipcamera
            // 
            this.textprettipcamera.BackColor = System.Drawing.SystemColors.Control;
            this.textprettipcamera.BorderColor = System.Drawing.SystemColors.Control;
            this.textprettipcamera.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textprettipcamera.BorderRadius = 20;
            this.textprettipcamera.BorderSize = 2;
            this.textprettipcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprettipcamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textprettipcamera.Location = new System.Drawing.Point(133, 225);
            this.textprettipcamera.Margin = new System.Windows.Forms.Padding(4);
            this.textprettipcamera.Multiline = false;
            this.textprettipcamera.Name = "textprettipcamera";
            this.textprettipcamera.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textprettipcamera.PasswordChar = false;
            this.textprettipcamera.PlaceholderColor = System.Drawing.Color.Empty;
            this.textprettipcamera.PlaceholderText = "";
            this.textprettipcamera.Size = new System.Drawing.Size(263, 33);
            this.textprettipcamera.TabIndex = 89;
            this.textprettipcamera.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label7.Size = new System.Drawing.Size(96, 32);
            this.label7.TabIndex = 92;
            this.label7.Text = "Capacitate";
            // 
            // textcapacitatetipcamera
            // 
            this.textcapacitatetipcamera.BackColor = System.Drawing.SystemColors.Control;
            this.textcapacitatetipcamera.BorderColor = System.Drawing.SystemColors.Control;
            this.textcapacitatetipcamera.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textcapacitatetipcamera.BorderRadius = 20;
            this.textcapacitatetipcamera.BorderSize = 2;
            this.textcapacitatetipcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcapacitatetipcamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textcapacitatetipcamera.Location = new System.Drawing.Point(133, 266);
            this.textcapacitatetipcamera.Margin = new System.Windows.Forms.Padding(4);
            this.textcapacitatetipcamera.Multiline = false;
            this.textcapacitatetipcamera.Name = "textcapacitatetipcamera";
            this.textcapacitatetipcamera.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.textcapacitatetipcamera.PasswordChar = false;
            this.textcapacitatetipcamera.PlaceholderColor = System.Drawing.Color.Empty;
            this.textcapacitatetipcamera.PlaceholderText = "";
            this.textcapacitatetipcamera.Size = new System.Drawing.Size(263, 33);
            this.textcapacitatetipcamera.TabIndex = 91;
            this.textcapacitatetipcamera.UnderlinedStyle = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipCameraBindingSource
            // 
            this.tipCameraBindingSource.DataMember = "TipCamera";
            this.tipCameraBindingSource.DataSource = this.dataSet1;
            // 
            // tipCameraTableAdapter
            // 
            this.tipCameraTableAdapter.ClearBeforeFill = true;
            // 
            // codTipCameraDataGridViewTextBoxColumn
            // 
            this.codTipCameraDataGridViewTextBoxColumn.DataPropertyName = "Cod_TipCamera";
            this.codTipCameraDataGridViewTextBoxColumn.HeaderText = "Cod_TipCamera";
            this.codTipCameraDataGridViewTextBoxColumn.Name = "codTipCameraDataGridViewTextBoxColumn";
            this.codTipCameraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTipCameraDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeTipCameraDataGridViewTextBoxColumn
            // 
            this.numeTipCameraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeTipCameraDataGridViewTextBoxColumn.DataPropertyName = "Nume_TipCamera";
            this.numeTipCameraDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeTipCameraDataGridViewTextBoxColumn.Name = "numeTipCameraDataGridViewTextBoxColumn";
            this.numeTipCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretTipCameraDataGridViewTextBoxColumn
            // 
            this.pretTipCameraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pretTipCameraDataGridViewTextBoxColumn.DataPropertyName = "Pret_TipCamera";
            this.pretTipCameraDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretTipCameraDataGridViewTextBoxColumn.Name = "pretTipCameraDataGridViewTextBoxColumn";
            this.pretTipCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacitateTipCameraDataGridViewTextBoxColumn
            // 
            this.capacitateTipCameraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacitateTipCameraDataGridViewTextBoxColumn.DataPropertyName = "Capacitate_TipCamera";
            this.capacitateTipCameraDataGridViewTextBoxColumn.HeaderText = "Capacitate";
            this.capacitateTipCameraDataGridViewTextBoxColumn.Name = "capacitateTipCameraDataGridViewTextBoxColumn";
            this.capacitateTipCameraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TipCameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 368);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textcapacitatetipcamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textprettipcamera);
            this.Controls.Add(this.butonR2);
            this.Controls.Add(this.butonR1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnumetipcamera);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipCameraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TipCamera";
            this.Load += new System.EventHandler(this.TipCameraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipCameraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private TextBoxR textnumetipcamera;
        private ButonR butonR2;
        private ButonR butonR1;
        private System.Windows.Forms.Label label5;
        private TextBoxR textprettipcamera;
        private System.Windows.Forms.Label label7;
        private TextBoxR textcapacitatetipcamera;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tipCameraBindingSource;
        private DataSet1TableAdapters.TipCameraTableAdapter tipCameraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeTipCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretTipCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitateTipCameraDataGridViewTextBoxColumn;
    }
}