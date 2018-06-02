namespace WindowsFormsApplication4
{
    partial class fregis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fregis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.readdpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbuatacc = new System.Windows.Forms.Button();
            this.baruuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.canceel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.canceel);
            this.panel1.Controls.Add(this.baruuser);
            this.panel1.Controls.Add(this.btnbuatacc);
            this.panel1.Controls.Add(this.readdpass);
            this.panel1.Controls.Add(this.addpassword);
            this.panel1.Location = new System.Drawing.Point(139, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 254);
            this.panel1.TabIndex = 0;
            // 
            // readdpass
            // 
            this.readdpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.readdpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.readdpass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.readdpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.readdpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.readdpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.readdpass.HintForeColor = System.Drawing.Color.Empty;
            this.readdpass.HintText = "Confirm Password";
            this.readdpass.isPassword = false;
            this.readdpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.readdpass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.readdpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.readdpass.LineThickness = 3;
            this.readdpass.Location = new System.Drawing.Point(54, 118);
            this.readdpass.Margin = new System.Windows.Forms.Padding(4);
            this.readdpass.MaxLength = 32767;
            this.readdpass.Name = "readdpass";
            this.readdpass.Size = new System.Drawing.Size(202, 33);
            this.readdpass.TabIndex = 4;
            this.readdpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.readdpass.OnValueChanged += new System.EventHandler(this.readdpass_OnValueChanged);
            // 
            // addpassword
            // 
            this.addpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.addpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.addpassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.addpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addpassword.HintForeColor = System.Drawing.Color.Empty;
            this.addpassword.HintText = "Password";
            this.addpassword.isPassword = false;
            this.addpassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.addpassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.addpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.addpassword.LineThickness = 3;
            this.addpassword.Location = new System.Drawing.Point(54, 77);
            this.addpassword.Margin = new System.Windows.Forms.Padding(4);
            this.addpassword.MaxLength = 32767;
            this.addpassword.Name = "addpassword";
            this.addpassword.Size = new System.Drawing.Size(202, 33);
            this.addpassword.TabIndex = 2;
            this.addpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addpassword.OnValueChanged += new System.EventHandler(this.addpassword_OnValueChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(571, 251);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(238, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Donor Darah ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.medical;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(219, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnbuatacc
            // 
            this.btnbuatacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.btnbuatacc.FlatAppearance.BorderSize = 0;
            this.btnbuatacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuatacc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuatacc.Location = new System.Drawing.Point(54, 177);
            this.btnbuatacc.Name = "btnbuatacc";
            this.btnbuatacc.Size = new System.Drawing.Size(202, 26);
            this.btnbuatacc.TabIndex = 5;
            this.btnbuatacc.Text = "Create Account";
            this.btnbuatacc.UseVisualStyleBackColor = false;
            // 
            // baruuser
            // 
            this.baruuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.baruuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.baruuser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.baruuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.baruuser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.baruuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.baruuser.HintForeColor = System.Drawing.Color.Empty;
            this.baruuser.HintText = "Username";
            this.baruuser.isPassword = false;
            this.baruuser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.baruuser.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.baruuser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.baruuser.LineThickness = 3;
            this.baruuser.Location = new System.Drawing.Point(54, 36);
            this.baruuser.Margin = new System.Windows.Forms.Padding(4);
            this.baruuser.MaxLength = 32767;
            this.baruuser.Name = "baruuser";
            this.baruuser.Size = new System.Drawing.Size(202, 33);
            this.baruuser.TabIndex = 2;
            this.baruuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baruuser.OnValueChanged += new System.EventHandler(this.baruuser_OnValueChanged);
            // 
            // canceel
            // 
            this.canceel.AutoSize = true;
            this.canceel.BackColor = System.Drawing.Color.Transparent;
            this.canceel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.canceel.Location = new System.Drawing.Point(125, 212);
            this.canceel.Name = "canceel";
            this.canceel.Size = new System.Drawing.Size(46, 13);
            this.canceel.TabIndex = 6;
            this.canceel.Text = "Cancel";
            this.canceel.Click += new System.EventHandler(this.canceel_Click);
            // 
            // fregis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fregis";
            this.Text = "fregis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
       
        private Bunifu.Framework.UI.BunifuMaterialTextbox addpassword;
      
        
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox readdpass;
  
        private System.Windows.Forms.Button btnbuatacc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox baruuser;
        private System.Windows.Forms.Label canceel;

    }
}