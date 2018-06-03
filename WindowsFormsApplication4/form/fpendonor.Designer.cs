namespace WindowsFormsApplication4.form
{
    partial class Fpendonor
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
            this.tbriwayat = new System.Windows.Forms.TextBox();
            this.tbgoldar = new System.Windows.Forms.TextBox();
            this.tbberatbadan = new System.Windows.Forms.TextBox();
            this.TTL = new System.Windows.Forms.DateTimePicker();
            this.tbumur = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.lriwayat = new System.Windows.Forms.Label();
            this.lgoldar = new System.Windows.Forms.Label();
            this.lberatbadan = new System.Windows.Forms.Label();
            this.ltanggallahir = new System.Windows.Forms.Label();
            this.lumur = new System.Windows.Forms.Label();
            this.lalamat = new System.Windows.Forms.Label();
            this.lnama = new System.Windows.Forms.Label();
            this.btambah = new System.Windows.Forms.Button();
            this.bsimpan = new System.Windows.Forms.Button();
            this.bhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbriwayat
            // 
            this.tbriwayat.Location = new System.Drawing.Point(192, 198);
            this.tbriwayat.Name = "tbriwayat";
            this.tbriwayat.Size = new System.Drawing.Size(100, 20);
            this.tbriwayat.TabIndex = 32;
            // 
            // tbgoldar
            // 
            this.tbgoldar.Location = new System.Drawing.Point(192, 165);
            this.tbgoldar.Name = "tbgoldar";
            this.tbgoldar.Size = new System.Drawing.Size(100, 20);
            this.tbgoldar.TabIndex = 31;
            // 
            // tbberatbadan
            // 
            this.tbberatbadan.Location = new System.Drawing.Point(192, 137);
            this.tbberatbadan.Name = "tbberatbadan";
            this.tbberatbadan.Size = new System.Drawing.Size(100, 20);
            this.tbberatbadan.TabIndex = 30;
            // 
            // TTL
            // 
            this.TTL.CustomFormat = "yyyy-MM-dd";
            this.TTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TTL.Location = new System.Drawing.Point(192, 109);
            this.TTL.Name = "TTL";
            this.TTL.Size = new System.Drawing.Size(100, 20);
            this.TTL.TabIndex = 29;
            this.TTL.Value = new System.DateTime(2018, 6, 3, 0, 0, 0, 0);
            this.TTL.ValueChanged += new System.EventHandler(this.TTL_ValueChanged);
            // 
            // tbumur
            // 
            this.tbumur.Location = new System.Drawing.Point(192, 78);
            this.tbumur.Name = "tbumur";
            this.tbumur.Size = new System.Drawing.Size(100, 20);
            this.tbumur.TabIndex = 28;
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(192, 49);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(100, 20);
            this.tbalamat.TabIndex = 27;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(192, 19);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(100, 20);
            this.tbnama.TabIndex = 26;
            // 
            // lriwayat
            // 
            this.lriwayat.AutoSize = true;
            this.lriwayat.Location = new System.Drawing.Point(54, 198);
            this.lriwayat.Name = "lriwayat";
            this.lriwayat.Size = new System.Drawing.Size(89, 13);
            this.lriwayat.TabIndex = 25;
            this.lriwayat.Text = "Riwayat Penyakit";
            // 
            // lgoldar
            // 
            this.lgoldar.AutoSize = true;
            this.lgoldar.Location = new System.Drawing.Point(54, 165);
            this.lgoldar.Name = "lgoldar";
            this.lgoldar.Size = new System.Drawing.Size(85, 13);
            this.lgoldar.TabIndex = 24;
            this.lgoldar.Text = "Golongan Darah";
            // 
            // lberatbadan
            // 
            this.lberatbadan.AutoSize = true;
            this.lberatbadan.Location = new System.Drawing.Point(54, 137);
            this.lberatbadan.Name = "lberatbadan";
            this.lberatbadan.Size = new System.Drawing.Size(66, 13);
            this.lberatbadan.TabIndex = 23;
            this.lberatbadan.Text = "Berat Badan";
            // 
            // ltanggallahir
            // 
            this.ltanggallahir.AutoSize = true;
            this.ltanggallahir.Location = new System.Drawing.Point(54, 109);
            this.ltanggallahir.Name = "ltanggallahir";
            this.ltanggallahir.Size = new System.Drawing.Size(72, 13);
            this.ltanggallahir.TabIndex = 22;
            this.ltanggallahir.Text = "Tanggal Lahir";
            // 
            // lumur
            // 
            this.lumur.AutoSize = true;
            this.lumur.Location = new System.Drawing.Point(54, 78);
            this.lumur.Name = "lumur";
            this.lumur.Size = new System.Drawing.Size(32, 13);
            this.lumur.TabIndex = 21;
            this.lumur.Text = "Umur";
            // 
            // lalamat
            // 
            this.lalamat.AutoSize = true;
            this.lalamat.Location = new System.Drawing.Point(54, 49);
            this.lalamat.Name = "lalamat";
            this.lalamat.Size = new System.Drawing.Size(39, 13);
            this.lalamat.TabIndex = 20;
            this.lalamat.Text = "Alamat";
            // 
            // lnama
            // 
            this.lnama.AutoSize = true;
            this.lnama.Location = new System.Drawing.Point(54, 19);
            this.lnama.Name = "lnama";
            this.lnama.Size = new System.Drawing.Size(84, 13);
            this.lnama.TabIndex = 19;
            this.lnama.Text = "Nama Pendonor";
            // 
            // btambah
            // 
            this.btambah.Location = new System.Drawing.Point(119, 240);
            this.btambah.Name = "btambah";
            this.btambah.Size = new System.Drawing.Size(75, 23);
            this.btambah.TabIndex = 18;
            this.btambah.Text = "tambah";
            this.btambah.UseVisualStyleBackColor = true;
            this.btambah.Click += new System.EventHandler(this.btambah_Click);
            // 
            // bsimpan
            // 
            this.bsimpan.Location = new System.Drawing.Point(237, 240);
            this.bsimpan.Name = "bsimpan";
            this.bsimpan.Size = new System.Drawing.Size(75, 23);
            this.bsimpan.TabIndex = 17;
            this.bsimpan.Text = "simpan";
            this.bsimpan.UseVisualStyleBackColor = true;
            this.bsimpan.Click += new System.EventHandler(this.bsimpan_Click);
            // 
            // bhome
            // 
            this.bhome.Location = new System.Drawing.Point(341, 240);
            this.bhome.Name = "bhome";
            this.bhome.Size = new System.Drawing.Size(75, 23);
            this.bhome.TabIndex = 33;
            this.bhome.Text = "Home";
            this.bhome.UseVisualStyleBackColor = true;
            this.bhome.Click += new System.EventHandler(this.bhome_Click);
            // 
            // Fpendonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 341);
            this.Controls.Add(this.bhome);
            this.Controls.Add(this.tbriwayat);
            this.Controls.Add(this.tbgoldar);
            this.Controls.Add(this.tbberatbadan);
            this.Controls.Add(this.TTL);
            this.Controls.Add(this.tbumur);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.lriwayat);
            this.Controls.Add(this.lgoldar);
            this.Controls.Add(this.lberatbadan);
            this.Controls.Add(this.ltanggallahir);
            this.Controls.Add(this.lumur);
            this.Controls.Add(this.lalamat);
            this.Controls.Add(this.lnama);
            this.Controls.Add(this.btambah);
            this.Controls.Add(this.bsimpan);
            this.Location = new System.Drawing.Point(54, 36);
            this.Name = "Fpendonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fpendonor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbriwayat;
        private System.Windows.Forms.TextBox tbgoldar;
        private System.Windows.Forms.TextBox tbberatbadan;
        private System.Windows.Forms.DateTimePicker TTL;
        private System.Windows.Forms.TextBox tbumur;
        private System.Windows.Forms.TextBox tbalamat;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label lriwayat;
        private System.Windows.Forms.Label lgoldar;
        private System.Windows.Forms.Label lberatbadan;
        private System.Windows.Forms.Label ltanggallahir;
        private System.Windows.Forms.Label lumur;
        private System.Windows.Forms.Label lalamat;
        private System.Windows.Forms.Label lnama;
        private System.Windows.Forms.Button btambah;
        private System.Windows.Forms.Button bsimpan;
        private System.Windows.Forms.Button bhome;
    }
}