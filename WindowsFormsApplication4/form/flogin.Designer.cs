namespace WindowsFormsApplication4
{
    partial class flogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.passlog = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buatac = new System.Windows.Forms.Label();
            this.addpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userlogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginn = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.passlog);
            this.panel1.Controls.Add(this.buatac);
            this.panel1.Controls.Add(this.addpassword);
            this.panel1.Controls.Add(this.userlogin);
            this.panel1.Controls.Add(this.loginn);
            this.panel1.Location = new System.Drawing.Point(139, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 225);
            this.panel1.TabIndex = 0;
            // 
            // passlog
            // 
            this.passlog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passlog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passlog.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passlog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passlog.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passlog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passlog.HintForeColor = System.Drawing.Color.Empty;
            this.passlog.HintText = "Password";
            this.passlog.isPassword = false;
            this.passlog.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.passlog.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.passlog.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.passlog.LineThickness = 3;
            this.passlog.Location = new System.Drawing.Point(54, 77);
            this.passlog.Margin = new System.Windows.Forms.Padding(4);
            this.passlog.MaxLength = 32767;
            this.passlog.Name = "passlog";
            this.passlog.Size = new System.Drawing.Size(202, 33);
            this.passlog.TabIndex = 3;
            this.passlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passlog.OnValueChanged += new System.EventHandler(this.passlog_OnValueChanged);
            // 
            // buatac
            // 
            this.buatac.AutoSize = true;
            this.buatac.BackColor = System.Drawing.Color.Transparent;
            this.buatac.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buatac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.buatac.Location = new System.Drawing.Point(110, 180);
            this.buatac.Name = "buatac";
            this.buatac.Size = new System.Drawing.Size(80, 13);
            this.buatac.TabIndex = 3;
            this.buatac.Text = "Create Account";
            this.buatac.Click += new System.EventHandler(this.buatac_Click);
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
            // 
            // userlogin
            // 
            this.userlogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userlogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userlogin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userlogin.HintForeColor = System.Drawing.Color.Empty;
            this.userlogin.HintText = "Username";
            this.userlogin.isPassword = false;
            this.userlogin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.userlogin.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.userlogin.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.userlogin.LineThickness = 3;
            this.userlogin.Location = new System.Drawing.Point(54, 36);
            this.userlogin.Margin = new System.Windows.Forms.Padding(4);
            this.userlogin.MaxLength = 32767;
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(202, 33);
            this.userlogin.TabIndex = 1;
            this.userlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userlogin.OnValueChanged += new System.EventHandler(this.userlogin_OnValueChanged);
            // 
            // loginn
            // 
            this.loginn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.loginn.FlatAppearance.BorderSize = 0;
            this.loginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginn.Location = new System.Drawing.Point(54, 145);
            this.loginn.Name = "loginn";
            this.loginn.Size = new System.Drawing.Size(202, 32);
            this.loginn.TabIndex = 0;
            this.loginn.Text = "LOGIN";
            this.loginn.UseVisualStyleBackColor = false;
            this.loginn.Click += new System.EventHandler(this.loginn_Click);
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
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "flogin";
            this.Text = "flogin";
            this.Load += new System.EventHandler(this.flogin_Load);
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
        private System.Windows.Forms.Label buatac;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addpassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userlogin;
        private System.Windows.Forms.Button loginn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passlog;

    }
}