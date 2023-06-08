namespace Rezervare_Hotel
{
    partial class Form3
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
            this.textnume = new System.Windows.Forms.TextBox();
            this.textprenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texttelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textadresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.butonR1 = new Rezervare_Hotel.ButonR();
            this.client1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Rezervare_Hotel.DataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.ClientTableAdapter();
            this.client1TableAdapter = new Rezervare_Hotel.DataSet1TableAdapters.Client1TableAdapter();
            this.numeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(457, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(694, 340);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // textnume
            // 
            this.textnume.Location = new System.Drawing.Point(123, 74);
            this.textnume.Name = "textnume";
            this.textnume.Size = new System.Drawing.Size(100, 22);
            this.textnume.TabIndex = 2;
            // 
            // textprenume
            // 
            this.textprenume.Location = new System.Drawing.Point(123, 102);
            this.textprenume.Name = "textprenume";
            this.textprenume.Size = new System.Drawing.Size(100, 22);
            this.textprenume.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(123, 130);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 22);
            this.textemail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // texttelefon
            // 
            this.texttelefon.Location = new System.Drawing.Point(123, 158);
            this.texttelefon.Name = "texttelefon";
            this.texttelefon.Size = new System.Drawing.Size(100, 22);
            this.texttelefon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // textadresa
            // 
            this.textadresa.Location = new System.Drawing.Point(123, 186);
            this.textadresa.Name = "textadresa";
            this.textadresa.Size = new System.Drawing.Size(100, 22);
            this.textadresa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresa";
            // 
            // butoninsereaza
            // 
            this.butoninsereaza.Location = new System.Drawing.Point(548, 447);
            this.butoninsereaza.Name = "butoninsereaza";
            this.butoninsereaza.Size = new System.Drawing.Size(75, 75);
            this.butoninsereaza.TabIndex = 11;
            this.butoninsereaza.Text = "Insereaza";
            this.butoninsereaza.UseVisualStyleBackColor = true;
            this.butoninsereaza.Click += new System.EventHandler(this.butoninsereaza_Click);
            // 
            // butonactualizeaza
            // 
            this.butonactualizeaza.Location = new System.Drawing.Point(694, 447);
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
            this.butonsterge.Name = "butonsterge";
            this.butonsterge.Size = new System.Drawing.Size(75, 75);
            this.butonsterge.TabIndex = 13;
            this.butonsterge.Text = "Sterge";
            this.butonsterge.UseVisualStyleBackColor = true;
            this.butonsterge.Click += new System.EventHandler(this.butonsterge_Click);
            // 
            // cautaclient
            // 
            this.cautaclient.Location = new System.Drawing.Point(123, 23);
            this.cautaclient.Name = "cautaclient";
            this.cautaclient.Size = new System.Drawing.Size(272, 22);
            this.cautaclient.TabIndex = 18;
            this.cautaclient.TextChanged += new System.EventHandler(this.cautaclient_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 26);
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
            this.textnumer.Location = new System.Drawing.Point(145, 232);
            this.textnumer.Margin = new System.Windows.Forms.Padding(4);
            this.textnumer.Multiline = false;
            this.textnumer.Name = "textnumer";
            this.textnumer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textnumer.PasswordChar = false;
            this.textnumer.PlaceholderColor = System.Drawing.Color.Empty;
            this.textnumer.PlaceholderText = "";
            this.textnumer.Size = new System.Drawing.Size(250, 40);
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
            this.textprenumer.Location = new System.Drawing.Point(145, 280);
            this.textprenumer.Margin = new System.Windows.Forms.Padding(4);
            this.textprenumer.Multiline = false;
            this.textprenumer.Name = "textprenumer";
            this.textprenumer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textprenumer.PasswordChar = false;
            this.textprenumer.PlaceholderColor = System.Drawing.Color.Empty;
            this.textprenumer.PlaceholderText = "";
            this.textprenumer.Size = new System.Drawing.Size(250, 40);
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
            this.textemailr.Location = new System.Drawing.Point(145, 328);
            this.textemailr.Margin = new System.Windows.Forms.Padding(4);
            this.textemailr.Multiline = false;
            this.textemailr.Name = "textemailr";
            this.textemailr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textemailr.PasswordChar = false;
            this.textemailr.PlaceholderColor = System.Drawing.Color.Empty;
            this.textemailr.PlaceholderText = "";
            this.textemailr.Size = new System.Drawing.Size(250, 40);
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
            this.texttelefonr.Location = new System.Drawing.Point(144, 376);
            this.texttelefonr.Margin = new System.Windows.Forms.Padding(4);
            this.texttelefonr.Multiline = false;
            this.texttelefonr.Name = "texttelefonr";
            this.texttelefonr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.texttelefonr.PasswordChar = false;
            this.texttelefonr.PlaceholderColor = System.Drawing.Color.Empty;
            this.texttelefonr.PlaceholderText = "";
            this.texttelefonr.Size = new System.Drawing.Size(250, 40);
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
            this.textadresar.Location = new System.Drawing.Point(144, 424);
            this.textadresar.Margin = new System.Windows.Forms.Padding(4);
            this.textadresar.Multiline = false;
            this.textadresar.Name = "textadresar";
            this.textadresar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textadresar.PasswordChar = false;
            this.textadresar.PlaceholderColor = System.Drawing.Color.Empty;
            this.textadresar.PlaceholderText = "";
            this.textadresar.Size = new System.Drawing.Size(250, 40);
            this.textadresar.TabIndex = 25;
            this.textadresar.UnderlinedStyle = false;
            // 
            // butonR1
            // 
            this.butonR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.butonR1.BorderRadius = 20;
            this.butonR1.BorderSize = 2;
            this.butonR1.FlatAppearance.BorderSize = 0;
            this.butonR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonR1.ForeColor = System.Drawing.Color.White;
            this.butonR1.Location = new System.Drawing.Point(910, 461);
            this.butonR1.Name = "butonR1";
            this.butonR1.Size = new System.Drawing.Size(250, 40);
            this.butonR1.TabIndex = 26;
            this.butonR1.Text = "Intra in cont";
            this.butonR1.TextColor = System.Drawing.Color.White;
            this.butonR1.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 233);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label6.Size = new System.Drawing.Size(96, 39);
            this.label6.TabIndex = 27;
            this.label6.Text = "Utilizator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 281);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label8.Size = new System.Drawing.Size(96, 39);
            this.label8.TabIndex = 28;
            this.label8.Text = "Utilizator";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 329);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label9.Size = new System.Drawing.Size(96, 39);
            this.label9.TabIndex = 29;
            this.label9.Text = "Utilizator";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 377);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label10.Size = new System.Drawing.Size(96, 39);
            this.label10.TabIndex = 30;
            this.label10.Text = "Utilizator";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 425);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.label11.Size = new System.Drawing.Size(96, 39);
            this.label11.TabIndex = 31;
            this.label11.Text = "Utilizator";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 553);
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
            this.Controls.Add(this.textadresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texttelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textprenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
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
        private System.Windows.Forms.TextBox textnume;
        private System.Windows.Forms.TextBox textprenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texttelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textadresa;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}