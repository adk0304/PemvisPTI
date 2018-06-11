namespace WindowsFormsApplication4.form
{
    partial class adddarah
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.Namapen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btncari = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.goldar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TTL = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.bunifuCards2.Controls.Add(this.panel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(380, 247);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(321, 173);
            this.bunifuCards2.TabIndex = 1;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.bunifuCards3.Controls.Add(this.goldar);
            this.bunifuCards3.Controls.Add(this.btncari);
            this.bunifuCards3.Controls.Add(this.Namapen);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(49, 16);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(652, 225);
            this.bunifuCards3.TabIndex = 1;
            // 
            // Namapen
            // 
            this.Namapen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Namapen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Namapen.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Namapen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Namapen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Namapen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Namapen.HintForeColor = System.Drawing.Color.Empty;
            this.Namapen.HintText = "Masukkan Nama";
            this.Namapen.isPassword = false;
            this.Namapen.LineFocusedColor = System.Drawing.Color.Blue;
            this.Namapen.LineIdleColor = System.Drawing.Color.Gray;
            this.Namapen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Namapen.LineThickness = 3;
            this.Namapen.Location = new System.Drawing.Point(142, 62);
            this.Namapen.Margin = new System.Windows.Forms.Padding(4);
            this.Namapen.MaxLength = 32767;
            this.Namapen.Name = "Namapen";
            this.Namapen.Size = new System.Drawing.Size(379, 33);
            this.Namapen.TabIndex = 1;
            this.Namapen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btncari
            // 
            this.btncari.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncari.Location = new System.Drawing.Point(255, 143);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(135, 41);
            this.btncari.TabIndex = 4;
            this.btncari.Text = "Cari";
            this.btncari.UseVisualStyleBackColor = false;
            this.btncari.Click += new System.EventHandler(this.btambah_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apakah anda ingin mendonor darah ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(58, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iya";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(178, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tidak";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.bunifuCards1.Controls.Add(this.panel2);
            this.bunifuCards1.Controls.Add(this.panel3);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(49, 247);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(325, 173);
            this.bunifuCards1.TabIndex = 0;
            // 
            // goldar
            // 
            this.goldar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.goldar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.goldar.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.goldar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.goldar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.goldar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.goldar.HintForeColor = System.Drawing.Color.Empty;
            this.goldar.HintText = "Golongan Darah";
            this.goldar.isPassword = false;
            this.goldar.LineFocusedColor = System.Drawing.Color.Blue;
            this.goldar.LineIdleColor = System.Drawing.Color.Gray;
            this.goldar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.goldar.LineThickness = 3;
            this.goldar.Location = new System.Drawing.Point(142, 103);
            this.goldar.Margin = new System.Windows.Forms.Padding(4);
            this.goldar.MaxLength = 32767;
            this.goldar.Name = "goldar";
            this.goldar.Size = new System.Drawing.Size(379, 33);
            this.goldar.TabIndex = 5;
            this.goldar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TTL);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 165);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATA PENDONOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama                      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tanggal                   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Golongan darah      :";
            // 
            // TTL
            // 
            this.TTL.CustomFormat = "yyyy-MM-dd";
            this.TTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TTL.Location = new System.Drawing.Point(169, 113);
            this.TTL.Name = "TTL";
            this.TTL.Size = new System.Drawing.Size(123, 20);
            this.TTL.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 165);
            this.panel3.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data tidak ditemukan selahkan mendaftar";
            // 
            // adddarah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "adddarah";
            this.Size = new System.Drawing.Size(744, 451);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Namapen;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox goldar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TTL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;

    }
}
