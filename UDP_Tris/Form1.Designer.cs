namespace UDP_Tris
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.cmbIP = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numAvvPort = new System.Windows.Forms.NumericUpDown();
            this.avvIP = new System.Windows.Forms.ComboBox();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvvPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.cmbIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giocatore Locale";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(336, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(62, 53);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(268, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(142, 28);
            this.numPort.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(120, 20);
            this.numPort.TabIndex = 1;
            this.numPort.Tag = "";
            this.numPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // cmbIP
            // 
            this.cmbIP.FormattingEnabled = true;
            this.cmbIP.Location = new System.Drawing.Point(6, 28);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(121, 21);
            this.cmbIP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numAvvPort);
            this.groupBox2.Controls.Add(this.avvIP);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avversario";
            // 
            // numAvvPort
            // 
            this.numAvvPort.Location = new System.Drawing.Point(142, 28);
            this.numAvvPort.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numAvvPort.Name = "numAvvPort";
            this.numAvvPort.Size = new System.Drawing.Size(120, 20);
            this.numAvvPort.TabIndex = 1;
            this.numAvvPort.Tag = "";
            this.numAvvPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // avvIP
            // 
            this.avvIP.FormattingEnabled = true;
            this.avvIP.Location = new System.Drawing.Point(6, 28);
            this.avvIP.Name = "avvIP";
            this.avvIP.Size = new System.Drawing.Size(121, 21);
            this.avvIP.TabIndex = 0;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(55, 180);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(84, 69);
            this.btn00.TabIndex = 4;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(235, 330);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(84, 69);
            this.btn22.TabIndex = 5;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(145, 330);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(84, 69);
            this.btn21.TabIndex = 6;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(55, 330);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(84, 69);
            this.btn20.TabIndex = 7;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(235, 255);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(84, 69);
            this.btn12.TabIndex = 8;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(145, 255);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(84, 69);
            this.btn11.TabIndex = 9;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(55, 255);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(84, 69);
            this.btn10.TabIndex = 10;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(235, 180);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(84, 69);
            this.btn02.TabIndex = 11;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(145, 180);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(84, 69);
            this.btn01.TabIndex = 12;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btnTrasmettiMossa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 418);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAvvPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numAvvPort;
        private System.Windows.Forms.ComboBox avvIP;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
    }
}

