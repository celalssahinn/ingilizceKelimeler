namespace İngilizce_Kelimeler
{
    partial class menuSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuSecim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.turkce = new Bunifu.Framework.UI.BunifuTileButton();
            this.ingilizce = new Bunifu.Framework.UI.BunifuTileButton();
            this.abcdSor = new Bunifu.Framework.UI.BunifuTileButton();
            this.addButton = new ns1.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.soruSecimCBox = new System.Windows.Forms.ComboBox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 467);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(387, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 467);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 10);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çıkış yapmak için bu kısma tıklayınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // turkce
            // 
            this.turkce.BackColor = System.Drawing.Color.SeaGreen;
            this.turkce.color = System.Drawing.Color.SeaGreen;
            this.turkce.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.turkce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turkce.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.turkce.ForeColor = System.Drawing.Color.White;
            this.turkce.Image = ((System.Drawing.Image)(resources.GetObject("turkce.Image")));
            this.turkce.ImagePosition = 20;
            this.turkce.ImageZoom = 50;
            this.turkce.LabelPosition = 41;
            this.turkce.LabelText = "Türkçe Sor";
            this.turkce.Location = new System.Drawing.Point(32, 54);
            this.turkce.Margin = new System.Windows.Forms.Padding(6);
            this.turkce.Name = "turkce";
            this.turkce.Size = new System.Drawing.Size(146, 139);
            this.turkce.TabIndex = 4;
            this.turkce.Click += new System.EventHandler(this.turkce_Click);
            // 
            // ingilizce
            // 
            this.ingilizce.BackColor = System.Drawing.Color.SeaGreen;
            this.ingilizce.color = System.Drawing.Color.SeaGreen;
            this.ingilizce.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.ingilizce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingilizce.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ingilizce.ForeColor = System.Drawing.Color.White;
            this.ingilizce.Image = ((System.Drawing.Image)(resources.GetObject("ingilizce.Image")));
            this.ingilizce.ImagePosition = 20;
            this.ingilizce.ImageZoom = 50;
            this.ingilizce.LabelPosition = 39;
            this.ingilizce.LabelText = "İngilizce Sor";
            this.ingilizce.Location = new System.Drawing.Point(222, 54);
            this.ingilizce.Margin = new System.Windows.Forms.Padding(6);
            this.ingilizce.Name = "ingilizce";
            this.ingilizce.Size = new System.Drawing.Size(146, 139);
            this.ingilizce.TabIndex = 5;
            // 
            // abcdSor
            // 
            this.abcdSor.BackColor = System.Drawing.Color.SeaGreen;
            this.abcdSor.color = System.Drawing.Color.SeaGreen;
            this.abcdSor.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.abcdSor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abcdSor.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.abcdSor.ForeColor = System.Drawing.Color.White;
            this.abcdSor.Image = ((System.Drawing.Image)(resources.GetObject("abcdSor.Image")));
            this.abcdSor.ImagePosition = 20;
            this.abcdSor.ImageZoom = 50;
            this.abcdSor.LabelPosition = 41;
            this.abcdSor.LabelText = "Şıklı Sor";
            this.abcdSor.Location = new System.Drawing.Point(124, 226);
            this.abcdSor.Margin = new System.Windows.Forms.Padding(6);
            this.abcdSor.Name = "abcdSor";
            this.abcdSor.Size = new System.Drawing.Size(146, 139);
            this.abcdSor.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.addButton.BackColor = System.Drawing.Color.SkyBlue;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.BorderRadius = 0;
            this.addButton.ButtonText = "Kelime Ekle";
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.DisabledColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addButton.Iconimage = null;
            this.addButton.Iconimage_right = null;
            this.addButton.Iconimage_right_Selected = null;
            this.addButton.Iconimage_Selected = null;
            this.addButton.IconMarginLeft = 0;
            this.addButton.IconMarginRight = 0;
            this.addButton.IconRightVisible = true;
            this.addButton.IconRightZoom = 0D;
            this.addButton.IconVisible = true;
            this.addButton.IconZoom = 90D;
            this.addButton.IsTab = false;
            this.addButton.Location = new System.Drawing.Point(141, 403);
            this.addButton.Name = "addButton";
            this.addButton.Normalcolor = System.Drawing.Color.SkyBlue;
            this.addButton.OnHovercolor = System.Drawing.Color.Cyan;
            this.addButton.OnHoverTextColor = System.Drawing.Color.White;
            this.addButton.selected = false;
            this.addButton.Size = new System.Drawing.Size(113, 38);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Kelime Ekle";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.Textcolor = System.Drawing.Color.White;
            this.addButton.TextFont = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.abcdSor;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.ingilizce;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.turkce;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this.addButton;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(377, 10);
            this.panel4.TabIndex = 3;
            // 
            // soruSecimCBox
            // 
            this.soruSecimCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soruSecimCBox.FormattingEnabled = true;
            this.soruSecimCBox.Location = new System.Drawing.Point(222, 16);
            this.soruSecimCBox.Name = "soruSecimCBox";
            this.soruSecimCBox.Size = new System.Drawing.Size(146, 21);
            this.soruSecimCBox.TabIndex = 9;
            this.soruSecimCBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "?";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(16, 421);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(39, 30);
            this.bunifuFlatButton1.TabIndex = 35;
            this.bunifuFlatButton1.Text = "?";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(154, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Soru Verbs :";
            // 
            // menuSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(397, 467);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.soruSecimCBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.abcdSor);
            this.Controls.Add(this.ingilizce);
            this.Controls.Add(this.turkce);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuSecim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuSecim";
            this.Load += new System.EventHandler(this.menuSecim_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton abcdSor;
        private Bunifu.Framework.UI.BunifuTileButton ingilizce;
        private Bunifu.Framework.UI.BunifuTileButton turkce;
        private ns1.BunifuFlatButton addButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox soruSecimCBox;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label3;
    }
}