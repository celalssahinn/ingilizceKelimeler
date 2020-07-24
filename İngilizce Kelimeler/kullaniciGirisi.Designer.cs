namespace İngilizce_Kelimeler
{
    partial class kullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciGirisi));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.girisPaneli = new ns1.BunifuGradientPanel();
            this.bekleyiniz = new System.Windows.Forms.Label();
            this.kullaniciAdi = new ns1.BunifuTextbox();
            this.parola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.girisButon = new ns1.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse4 = new ns1.BunifuElipse(this.components);
            this.girisPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.girisPaneli;
            this.bunifuDragControl1.Vertical = true;
            // 
            // girisPaneli
            // 
            this.girisPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(67)))), ((int)(((byte)(174)))));
            this.girisPaneli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisPaneli.BackgroundImage")));
            this.girisPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisPaneli.Controls.Add(this.bekleyiniz);
            this.girisPaneli.Controls.Add(this.kullaniciAdi);
            this.girisPaneli.Controls.Add(this.parola);
            this.girisPaneli.Controls.Add(this.label7);
            this.girisPaneli.Controls.Add(this.bunifuImageButton1);
            this.girisPaneli.Controls.Add(this.girisButon);
            this.girisPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.girisPaneli.GradientBottomLeft = System.Drawing.Color.Orchid;
            this.girisPaneli.GradientBottomRight = System.Drawing.Color.Turquoise;
            this.girisPaneli.GradientTopLeft = System.Drawing.Color.DarkGreen;
            this.girisPaneli.GradientTopRight = System.Drawing.Color.Violet;
            this.girisPaneli.Location = new System.Drawing.Point(0, 0);
            this.girisPaneli.Name = "girisPaneli";
            this.girisPaneli.Quality = 10;
            this.girisPaneli.Size = new System.Drawing.Size(302, 424);
            this.girisPaneli.TabIndex = 2;
            this.girisPaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.girisPaneli_Paint_1);
            // 
            // bekleyiniz
            // 
            this.bekleyiniz.AutoSize = true;
            this.bekleyiniz.BackColor = System.Drawing.Color.Transparent;
            this.bekleyiniz.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bekleyiniz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bekleyiniz.Location = new System.Drawing.Point(23, 387);
            this.bekleyiniz.Name = "bekleyiniz";
            this.bekleyiniz.Size = new System.Drawing.Size(267, 28);
            this.bekleyiniz.TabIndex = 17;
            this.bekleyiniz.Text = "Lütfen bekleyiniz...";
            this.bekleyiniz.Visible = false;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.BackColor = System.Drawing.Color.Snow;
            this.kullaniciAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kullaniciAdi.BackgroundImage")));
            this.kullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.kullaniciAdi.Icon = ((System.Drawing.Image)(resources.GetObject("kullaniciAdi.Icon")));
            this.kullaniciAdi.Location = new System.Drawing.Point(16, 223);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(274, 42);
            this.kullaniciAdi.TabIndex = 16;
            this.kullaniciAdi.text = "";
            // 
            // parola
            // 
            this.parola.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.parola.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.parola.BackColor = System.Drawing.Color.Snow;
            this.parola.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parola.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.parola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parola.HintForeColor = System.Drawing.Color.Empty;
            this.parola.HintText = "";
            this.parola.isPassword = true;
            this.parola.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.parola.LineIdleColor = System.Drawing.SystemColors.ControlDarkDark;
            this.parola.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.parola.LineThickness = 3;
            this.parola.Location = new System.Drawing.Point(68, 283);
            this.parola.Margin = new System.Windows.Forms.Padding(4);
            this.parola.MaxLength = 32767;
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(222, 33);
            this.parola.TabIndex = 15;
            this.parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parola :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(98, 51);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(112, 117);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // girisButon
            // 
            this.girisButon.Activecolor = System.Drawing.Color.White;
            this.girisButon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.girisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisButon.BorderRadius = 1;
            this.girisButon.ButtonText = "Giriş";
            this.girisButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisButon.DisabledColor = System.Drawing.SystemColors.HighlightText;
            this.girisButon.ForeColor = System.Drawing.Color.White;
            this.girisButon.Iconcolor = System.Drawing.Color.Transparent;
            this.girisButon.Iconimage = null;
            this.girisButon.Iconimage_right = null;
            this.girisButon.Iconimage_right_Selected = null;
            this.girisButon.Iconimage_Selected = null;
            this.girisButon.IconMarginLeft = 1;
            this.girisButon.IconMarginRight = 0;
            this.girisButon.IconRightVisible = true;
            this.girisButon.IconRightZoom = 0D;
            this.girisButon.IconVisible = true;
            this.girisButon.IconZoom = 90D;
            this.girisButon.IsTab = false;
            this.girisButon.Location = new System.Drawing.Point(13, 340);
            this.girisButon.Name = "girisButon";
            this.girisButon.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.girisButon.OnHovercolor = System.Drawing.Color.White;
            this.girisButon.OnHoverTextColor = System.Drawing.Color.Black;
            this.girisButon.selected = false;
            this.girisButon.Size = new System.Drawing.Size(277, 36);
            this.girisButon.TabIndex = 2;
            this.girisButon.Text = "Giriş";
            this.girisButon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.girisButon.Textcolor = System.Drawing.Color.Black;
            this.girisButon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.girisButon;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 0;
            this.bunifuElipse3.TargetControl = this.parola;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 7;
            this.bunifuElipse4.TargetControl = this.kullaniciAdi;
            // 
            // kullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 424);
            this.Controls.Add(this.girisPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciGirisi";
            this.girisPaneli.ResumeLayout(false);
            this.girisPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuGradientPanel girisPaneli;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuFlatButton girisButon;
        private System.Windows.Forms.Label label7;
        private ns1.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox parola;
        private ns1.BunifuTextbox kullaniciAdi;
        private ns1.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Label bekleyiniz;
    }
}