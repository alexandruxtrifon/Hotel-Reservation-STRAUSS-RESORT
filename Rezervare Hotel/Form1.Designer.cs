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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareConturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jkhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuarPrelucrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportCamereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportTipuriCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.situatiaCamerelorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(200, 553);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(200, 80);
            this.toolStripButton1.Text = "    Camere";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(200, 80);
            this.toolStripButton2.Text = "    Clienti";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(200, 80);
            this.toolStripButton3.Text = "    Rezervari";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(200, 80);
            this.toolStripButton5.Text = "    Rapoarte";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(298, 28);
            this.toolStripMenuItem1.Text = "Factura";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(298, 28);
            this.toolStripMenuItem2.Text = "Raport Utilizatori";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(298, 28);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(298, 28);
            this.toolStripMenuItem4.Text = "Formular Prelucrare";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(298, 28);
            this.toolStripMenuItem5.Text = "Raport Camere";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(298, 28);
            this.toolStripMenuItem6.Text = "Raport Tipuri Camere";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(198, 4);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // solidGauge1
            // 
            this.solidGauge1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solidGauge1.Location = new System.Drawing.Point(841, 398);
            this.solidGauge1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(259, 134);
            this.solidGauge1.TabIndex = 63;
            this.solidGauge1.Text = "solidGauge1";
            this.solidGauge1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.solidGauge1_ChildChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(784, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 66;
            this.label1.Text = "Situatia Ocuparii Hotelului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(243, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Pondere Tipuri de Camere Rezervate";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(309, 353);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(369, 201);
            this.chart1.TabIndex = 68;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(521, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 54);
            this.button1.TabIndex = 69;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(472, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Bine ai venit, ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem7});
            this.menuStrip1.Location = new System.Drawing.Point(180, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(999, 64);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem8.AutoSize = false;
            this.toolStripMenuItem8.Image = global::Rezervare_Hotel.Properties.Resources.logout;
            this.toolStripMenuItem8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 60);
            this.toolStripMenuItem8.Text = " Delogare";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem7.AutoSize = false;
            this.toolStripMenuItem7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrareConturiToolStripMenuItem});
            this.toolStripMenuItem7.Image = global::Rezervare_Hotel.Properties.Resources.setting;
            this.toolStripMenuItem7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.toolStripMenuItem7.Size = new System.Drawing.Size(122, 60);
            this.toolStripMenuItem7.Text = " Setari";
            // 
            // administrareConturiToolStripMenuItem
            // 
            this.administrareConturiToolStripMenuItem.Name = "administrareConturiToolStripMenuItem";
            this.administrareConturiToolStripMenuItem.Size = new System.Drawing.Size(292, 28);
            this.administrareConturiToolStripMenuItem.Text = "Administrare Conturi";
            this.administrareConturiToolStripMenuItem.Visible = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemImage,
            this.toolStripMenuItem9,
            this.clientiToolStripMenuItem,
            this.rezervariToolStripMenuItem,
            this.rapoarteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(180, 567);
            this.menuStrip2.TabIndex = 72;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItemImage
            // 
            this.ToolStripMenuItemImage.AutoSize = false;
            this.ToolStripMenuItemImage.Name = "ToolStripMenuItemImage";
            this.ToolStripMenuItemImage.Size = new System.Drawing.Size(180, 70);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.AutoSize = false;
            this.toolStripMenuItem9.Image = global::Rezervare_Hotel.Properties.Resources.bed;
            this.toolStripMenuItem9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 70);
            this.toolStripMenuItem9.Text = "  Camere";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.AutoSize = false;
            this.clientiToolStripMenuItem.Image = global::Rezervare_Hotel.Properties.Resources.add_user;
            this.clientiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(180, 70);
            this.clientiToolStripMenuItem.Text = "  Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // rezervariToolStripMenuItem
            // 
            this.rezervariToolStripMenuItem.AutoSize = false;
            this.rezervariToolStripMenuItem.Image = global::Rezervare_Hotel.Properties.Resources.booking;
            this.rezervariToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rezervariToolStripMenuItem.Name = "rezervariToolStripMenuItem";
            this.rezervariToolStripMenuItem.Size = new System.Drawing.Size(180, 70);
            this.rezervariToolStripMenuItem.Text = "  Rezervari";
            this.rezervariToolStripMenuItem.Click += new System.EventHandler(this.rezervariToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.AutoSize = false;
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.raportUtilizatoriToolStripMenuItem,
            this.jkhToolStripMenuItem,
            this.formuarPrelucrareToolStripMenuItem,
            this.raportCamereToolStripMenuItem,
            this.raportTipuriCameraToolStripMenuItem,
            this.situatiaCamerelorToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Image = global::Rezervare_Hotel.Properties.Resources.report;
            this.rapoarteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(180, 70);
            this.rapoarteToolStripMenuItem.Text = "  Rapoarte";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Image = global::Rezervare_Hotel.Properties.Resources.invoice;
            this.facturaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // raportUtilizatoriToolStripMenuItem
            // 
            this.raportUtilizatoriToolStripMenuItem.Image = global::Rezervare_Hotel.Properties.Resources.user;
            this.raportUtilizatoriToolStripMenuItem.Name = "raportUtilizatoriToolStripMenuItem";
            this.raportUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.raportUtilizatoriToolStripMenuItem.Text = "Raport Utilizatori";
            this.raportUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.raportUtilizatoriToolStripMenuItem_Click);
            // 
            // jkhToolStripMenuItem
            // 
            this.jkhToolStripMenuItem.Name = "jkhToolStripMenuItem";
            this.jkhToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.jkhToolStripMenuItem.Text = "jkh";
            // 
            // formuarPrelucrareToolStripMenuItem
            // 
            this.formuarPrelucrareToolStripMenuItem.Image = global::Rezervare_Hotel.Properties.Resources.requirement;
            this.formuarPrelucrareToolStripMenuItem.Name = "formuarPrelucrareToolStripMenuItem";
            this.formuarPrelucrareToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.formuarPrelucrareToolStripMenuItem.Text = "Formuar Prelucrare";
            this.formuarPrelucrareToolStripMenuItem.Click += new System.EventHandler(this.formuarPrelucrareToolStripMenuItem_Click);
            // 
            // raportCamereToolStripMenuItem
            // 
            this.raportCamereToolStripMenuItem.Name = "raportCamereToolStripMenuItem";
            this.raportCamereToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.raportCamereToolStripMenuItem.Text = "Raport Camere";
            // 
            // raportTipuriCameraToolStripMenuItem
            // 
            this.raportTipuriCameraToolStripMenuItem.Name = "raportTipuriCameraToolStripMenuItem";
            this.raportTipuriCameraToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.raportTipuriCameraToolStripMenuItem.Text = "Raport Tipuri Camera";
            this.raportTipuriCameraToolStripMenuItem.Click += new System.EventHandler(this.raportTipuriCameraToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // situatiaCamerelorToolStripMenuItem
            // 
            this.situatiaCamerelorToolStripMenuItem.Name = "situatiaCamerelorToolStripMenuItem";
            this.situatiaCamerelorToolStripMenuItem.Size = new System.Drawing.Size(310, 38);
            this.situatiaCamerelorToolStripMenuItem.Text = "Situatia Camerelor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jkhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuarPrelucrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportCamereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportTipuriCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrareConturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemImage;
        private System.Windows.Forms.ToolStripMenuItem situatiaCamerelorToolStripMenuItem;
    }
}

