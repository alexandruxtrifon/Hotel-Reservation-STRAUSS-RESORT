namespace Rezervare_Hotel
{
    partial class UtilizatorForm
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
            this.numeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.butoninsereaza = new System.Windows.Forms.Button();
            this.butonactualizeaza = new System.Windows.Forms.Button();
            this.butonsterge = new System.Windows.Forms.Button();
            this.cautaclient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textnumer = new Rezervare_Hotel.TextBoxR();
            this.textprenumer = new Rezervare_Hotel.TextBoxR();
            this.textemailr = new Rezervare_Hotel.TextBoxR();
            this.texttelefonr = new Rezervare_Hotel.TextBoxR();
            this.textadresar = new Rezervare_Hotel.TextBoxR();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.ClientTableAdapter();
            this.client1TableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.Client1TableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butonR2 = new Rezervare_Hotel.ButonR();
            this.butonR1 = new Rezervare_Hotel.ButonR();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeClientDataGridViewTextBoxColumn,
            this.prenumeClientDataGridViewTextBoxColumn,
            this.emailClientDataGridViewTextBoxColumn,
            this.telefonClientDataGridViewTextBoxColumn,
            this.Adresa_Client});
            this.dataGridView1.DataSource = this.client1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(453, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(693, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // numeClientDataGridViewTextBoxColumn
            // 
            this.numeClientDataGridViewTextBoxColumn.DataPropertyName = "Nume_Client";
            this.numeClientDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeClientDataGridViewTextBoxColumn.Name = "numeClientDataGridViewTextBoxColumn";
            this.numeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeClientDataGridViewTextBoxColumn
            // 
            this.prenumeClientDataGridViewTextBoxColumn.DataPropertyName = "Prenume_Client";
            this.prenumeClientDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeClientDataGridViewTextBoxColumn.Name = "prenumeClientDataGridViewTextBoxColumn";
            this.prenumeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailClientDataGridViewTextBoxColumn
            // 
            this.emailClientDataGridViewTextBoxColumn.DataPropertyName = "Email_Client";
            this.emailClientDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailClientDataGridViewTextBoxColumn.Name = "emailClientDataGridViewTextBoxColumn";
            this.emailClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonClientDataGridViewTextBoxColumn
            // 
            this.telefonClientDataGridViewTextBoxColumn.DataPropertyName = "Telefon_Client";
            this.telefonClientDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonClientDataGridViewTextBoxColumn.Name = "telefonClientDataGridViewTextBoxColumn";
            this.telefonClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Adresa_Client
            // 
            this.Adresa_Client.DataPropertyName = "Adresa_Client";
            this.Adresa_Client.HeaderText = "Adresa";
            this.Adresa_Client.MinimumWidth = 6;
            this.Adresa_Client.Name = "Adresa_Client";
            this.Adresa_Client.ReadOnly = true;
            // 
            // client1BindingSource
            // 
            this.client1BindingSource.DataMember = "Client1";
            this.client1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butoninsereaza
            // 
            this.butoninsereaza.Location = new System.Drawing.Point(548, 447);
            this.butoninsereaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butoninsereaza.Name = "butoninsereaza";
            this.butoninsereaza.Size = new System.Drawing.Size(75, 75);
            this.butoninsereaza.TabIndex = 11;
            this.butoninsereaza.Text = "Insereaza";
            this.butoninsereaza.UseVisualStyleBackColor = true;
            this.butoninsereaza.Click += new System.EventHandler(this.butoninsereaza_Click);
            // 
            // butonactualizeaza
            // 
            this.butonactualizeaza.Location = new System.Drawing.Point(693, 447);
            this.butonactualizeaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butonactualizeaza.Name = "butonactualizeaza";
            this.butonactualizeaza.Size = new System.Drawing.Size(75, 75);
            this.butonactualizeaza.TabIndex = 12;
            this.butonactualizeaza.Text = "Actualizeaza";
            this.butonactualizeaza.UseVisualStyleBackColor = true;
            this.butonactualizeaza.Click += new System.EventHandler(this.butonactualizeaza_Click);
            // 
            // butonsterge
            // 
            this.butonsterge.Location = new System.Drawing.Point(829, 447);
            this.butonsterge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butonsterge.Name = "butonsterge";
            this.butonsterge.Size = new System.Drawing.Size(75, 75);
            this.butonsterge.TabIndex = 13;
            this.butonsterge.Text = "Sterge";
            this.butonsterge.UseVisualStyleBackColor = true;
            this.butonsterge.Click += new System.EventHandler(this.butonsterge_Click);
            // 
            // cautaclient
            // 
            this.cautaclient.Location = new System.Drawing.Point(264, 22);
            this.cautaclient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cautaclient.Name = "cautaclient";
            this.cautaclient.Size = new System.Drawing.Size(459, 22);
            this.cautaclient.TabIndex = 18;
            this.cautaclient.TextChanged += new System.EventHandler(this.cautaclient_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cauta";
            // 
            // textnumer
            // 
            this.textnumer.BackColor = System.Drawing.SystemColors.Control;
            this.textnumer.BorderColor = System.Drawing.SystemColors.Control;
            this.textnumer.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textnumer.BorderRadius = 20;
            this.textnumer.BorderSize = 2;
            this.textnumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textnumer.Location = new System.Drawing.Point(151, 98);
            this.textnumer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textnumer.Multiline = false;
            this.textnumer.Name = "textnumer";
            this.textnumer.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.textnumer.PasswordChar = false;
            this.textnumer.PlaceholderColor = System.Drawing.Color.Empty;
            this.textnumer.PlaceholderText = "";
            this.textnumer.Size = new System.Drawing.Size(293, 40);
            this.textnumer.TabIndex = 21;
            this.textnumer.UnderlinedStyle = false;
            // 
            // textprenumer
            // 
            this.textprenumer.BackColor = System.Drawing.SystemColors.Control;
            this.textprenumer.BorderColor = System.Drawing.SystemColors.Control;
            this.textprenumer.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textprenumer.BorderRadius = 20;
            this.textprenumer.BorderSize = 2;
            this.textprenumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprenumer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textprenumer.Location = new System.Drawing.Point(151, 148);
            this.textprenumer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textprenumer.Multiline = false;
            this.textprenumer.Name = "textprenumer";
            this.textprenumer.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.textprenumer.PasswordChar = false;
            this.textprenumer.PlaceholderColor = System.Drawing.Color.Empty;
            this.textprenumer.PlaceholderText = "";
            this.textprenumer.Size = new System.Drawing.Size(293, 40);
            this.textprenumer.TabIndex = 22;
            this.textprenumer.UnderlinedStyle = false;
            // 
            // textemailr
            // 
            this.textemailr.BackColor = System.Drawing.SystemColors.Control;
            this.textemailr.BorderColor = System.Drawing.SystemColors.Control;
            this.textemailr.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textemailr.BorderRadius = 20;
            this.textemailr.BorderSize = 2;
            this.textemailr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemailr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textemailr.Location = new System.Drawing.Point(151, 194);
            this.textemailr.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textemailr.Multiline = false;
            this.textemailr.Name = "textemailr";
            this.textemailr.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.textemailr.PasswordChar = false;
            this.textemailr.PlaceholderColor = System.Drawing.Color.Empty;
            this.textemailr.PlaceholderText = "";
            this.textemailr.Size = new System.Drawing.Size(293, 40);
            this.textemailr.TabIndex = 23;
            this.textemailr.UnderlinedStyle = false;
            // 
            // texttelefonr
            // 
            this.texttelefonr.BackColor = System.Drawing.SystemColors.Control;
            this.texttelefonr.BorderColor = System.Drawing.SystemColors.Control;
            this.texttelefonr.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.texttelefonr.BorderRadius = 20;
            this.texttelefonr.BorderSize = 2;
            this.texttelefonr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttelefonr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.texttelefonr.Location = new System.Drawing.Point(149, 244);
            this.texttelefonr.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.texttelefonr.Multiline = false;
            this.texttelefonr.Name = "texttelefonr";
            this.texttelefonr.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.texttelefonr.PasswordChar = false;
            this.texttelefonr.PlaceholderColor = System.Drawing.Color.Empty;
            this.texttelefonr.PlaceholderText = "";
            this.texttelefonr.Size = new System.Drawing.Size(293, 40);
            this.texttelefonr.TabIndex = 24;
            this.texttelefonr.UnderlinedStyle = false;
            // 
            // textadresar
            // 
            this.textadresar.BackColor = System.Drawing.SystemColors.Control;
            this.textadresar.BorderColor = System.Drawing.SystemColors.Control;
            this.textadresar.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.textadresar.BorderRadius = 20;
            this.textadresar.BorderSize = 2;
            this.textadresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textadresar.Location = new System.Drawing.Point(149, 290);
            this.textadresar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textadresar.Multiline = false;
            this.textadresar.Name = "textadresar";
            this.textadresar.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.textadresar.PasswordChar = false;
            this.textadresar.PlaceholderColor = System.Drawing.Color.Empty;
            this.textadresar.PlaceholderText = "";
            this.textadresar.Size = new System.Drawing.Size(293, 40);
            this.textadresar.TabIndex = 25;
            this.textadresar.UnderlinedStyle = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // client1TableAdapter
            // 
            this.client1TableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 100);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label6.Size = new System.Drawing.Size(68, 39);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 148);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label8.Size = new System.Drawing.Size(98, 39);
            this.label8.TabIndex = 28;
            this.label8.Text = "Prenume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 196);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label9.Size = new System.Drawing.Size(65, 39);
            this.label9.TabIndex = 29;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 244);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label10.Size = new System.Drawing.Size(85, 39);
            this.label10.TabIndex = 30;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 292);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label11.Size = new System.Drawing.Size(81, 39);
            this.label11.TabIndex = 31;
            this.label11.Text = "Adresa";
            // 
            // butonR2
            // 
            this.butonR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butonR2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butonR2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butonR2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.butonR2.BorderRadius = 20;
            this.butonR2.BorderSize = 2;
            this.butonR2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonR2.FlatAppearance.BorderSize = 0;
            this.butonR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonR2.ForeColor = System.Drawing.Color.White;
            this.butonR2.Location = new System.Drawing.Point(336, 357);
            this.butonR2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butonR2.Name = "butonR2";
            this.butonR2.Size = new System.Drawing.Size(107, 49);
            this.butonR2.TabIndex = 32;
            this.butonR2.TextColor = System.Drawing.Color.White;
            this.butonR2.UseVisualStyleBackColor = false;
            // 
            // butonR1
            // 
            this.butonR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BackgroundImage = global::Rezervare_Hotel.Properties.Resources.pencil;
            this.butonR1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butonR1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BorderRadius = 20;
            this.butonR1.BorderSize = 2;
            this.butonR1.FlatAppearance.BorderSize = 0;
            this.butonR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonR1.ForeColor = System.Drawing.Color.White;
            this.butonR1.Location = new System.Drawing.Point(53, 357);
            this.butonR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butonR1.Name = "butonR1";
            this.butonR1.Size = new System.Drawing.Size(267, 49);
            this.butonR1.TabIndex = 26;
            this.butonR1.TextColor = System.Drawing.Color.White;
            this.butonR1.UseVisualStyleBackColor = false;
            // 
            // UtilizatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 553);
            this.Controls.Add(this.butonR2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butonR1);
            this.Controls.Add(this.textadresar);
            this.Controls.Add(this.texttelefonr);
            this.Controls.Add(this.textemailr);
            this.Controls.Add(this.textprenumer);
            this.Controls.Add(this.textnumer);
            this.Controls.Add(this.cautaclient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butonsterge);
            this.Controls.Add(this.butonactualizeaza);
            this.Controls.Add(this.butoninsereaza);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UtilizatorForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butoninsereaza;
        private System.Windows.Forms.Button butonactualizeaza;
        private System.Windows.Forms.Button butonsterge;
        private System.Windows.Forms.TextBox cautaclient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource client1BindingSource;
        private DataSet1TableAdapters.Client1TableAdapter client1TableAdapter;
        private TextBoxR textnumer;
        private TextBoxR textprenumer;
        private TextBoxR textemailr;
        private TextBoxR texttelefonr;
        private TextBoxR textadresar;
        private ButonR butonR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa_Client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ButonR butonR2;
    }
}