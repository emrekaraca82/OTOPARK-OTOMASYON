namespace OtoPark
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_seri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_marka = new System.Windows.Forms.Button();
            this.btn_satis = new System.Windows.Forms.Button();
            this.btn_oto_yer = new System.Windows.Forms.Button();
            this.btn_arac_oto_cikis = new System.Windows.Forms.Button();
            this.btn_arac_oto_giris = new System.Windows.Forms.Button();
            this.btn_müs_listele = new System.Windows.Forms.Button();
            this.btn_müs_ekle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müsterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.seriTool = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkısToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_seri);
            this.panel1.Controls.Add(this.btn_marka);
            this.panel1.Controls.Add(this.btn_satis);
            this.panel1.Controls.Add(this.btn_oto_yer);
            this.panel1.Controls.Add(this.btn_arac_oto_cikis);
            this.panel1.Controls.Add(this.btn_arac_oto_giris);
            this.panel1.Controls.Add(this.btn_müs_listele);
            this.panel1.Controls.Add(this.btn_müs_ekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 100);
            this.panel1.TabIndex = 1;
            // 
            // btn_seri
            // 
            this.btn_seri.FlatAppearance.BorderSize = 0;
            this.btn_seri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_seri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_seri.ImageKey = "9.jpg";
            this.btn_seri.ImageList = this.ımageList1;
            this.btn_seri.Location = new System.Drawing.Point(810, 24);
            this.btn_seri.Name = "btn_seri";
            this.btn_seri.Size = new System.Drawing.Size(105, 59);
            this.btn_seri.TabIndex = 7;
            this.btn_seri.Text = "Seri";
            this.btn_seri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_seri.UseVisualStyleBackColor = true;
            this.btn_seri.Click += new System.EventHandler(this.btn_seri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1.png");
            this.ımageList1.Images.SetKeyName(1, "5.jpg");
            this.ımageList1.Images.SetKeyName(2, "7.png");
            this.ımageList1.Images.SetKeyName(3, "8.jpg");
            this.ımageList1.Images.SetKeyName(4, "9.jpg");
            this.ımageList1.Images.SetKeyName(5, "6.jpg");
            this.ımageList1.Images.SetKeyName(6, "2.png");
            this.ımageList1.Images.SetKeyName(7, "3.png");
            this.ımageList1.Images.SetKeyName(8, "4.jpg");
            // 
            // btn_marka
            // 
            this.btn_marka.FlatAppearance.BorderSize = 0;
            this.btn_marka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_marka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marka.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_marka.ImageKey = "8.jpg";
            this.btn_marka.ImageList = this.ımageList1;
            this.btn_marka.Location = new System.Drawing.Point(692, 24);
            this.btn_marka.Name = "btn_marka";
            this.btn_marka.Size = new System.Drawing.Size(112, 59);
            this.btn_marka.TabIndex = 6;
            this.btn_marka.Text = "Marka";
            this.btn_marka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_marka.UseVisualStyleBackColor = true;
            this.btn_marka.Click += new System.EventHandler(this.btn_marka_Click);
            // 
            // btn_satis
            // 
            this.btn_satis.FlatAppearance.BorderSize = 0;
            this.btn_satis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_satis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_satis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_satis.ImageKey = "6.jpg";
            this.btn_satis.ImageList = this.ımageList1;
            this.btn_satis.Location = new System.Drawing.Point(581, 24);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(105, 59);
            this.btn_satis.TabIndex = 5;
            this.btn_satis.Text = "Satış";
            this.btn_satis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_satis.UseVisualStyleBackColor = true;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // btn_oto_yer
            // 
            this.btn_oto_yer.FlatAppearance.BorderSize = 0;
            this.btn_oto_yer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_oto_yer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oto_yer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_oto_yer.ImageKey = "5.jpg";
            this.btn_oto_yer.ImageList = this.ımageList1;
            this.btn_oto_yer.Location = new System.Drawing.Point(467, 24);
            this.btn_oto_yer.Name = "btn_oto_yer";
            this.btn_oto_yer.Size = new System.Drawing.Size(108, 59);
            this.btn_oto_yer.TabIndex = 4;
            this.btn_oto_yer.Text = "Otopark Yerleri";
            this.btn_oto_yer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_oto_yer.UseVisualStyleBackColor = true;
            this.btn_oto_yer.Click += new System.EventHandler(this.btn_oto_yer_Click);
            // 
            // btn_arac_oto_cikis
            // 
            this.btn_arac_oto_cikis.FlatAppearance.BorderSize = 0;
            this.btn_arac_oto_cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_arac_oto_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arac_oto_cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_arac_oto_cikis.ImageKey = "4.jpg";
            this.btn_arac_oto_cikis.ImageList = this.ımageList1;
            this.btn_arac_oto_cikis.Location = new System.Drawing.Point(353, 24);
            this.btn_arac_oto_cikis.Name = "btn_arac_oto_cikis";
            this.btn_arac_oto_cikis.Size = new System.Drawing.Size(108, 59);
            this.btn_arac_oto_cikis.TabIndex = 3;
            this.btn_arac_oto_cikis.Text = "Araç Otopark Çıkışı";
            this.btn_arac_oto_cikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_arac_oto_cikis.UseVisualStyleBackColor = true;
            this.btn_arac_oto_cikis.Click += new System.EventHandler(this.btn_arac_oto_cikis_Click);
            // 
            // btn_arac_oto_giris
            // 
            this.btn_arac_oto_giris.FlatAppearance.BorderSize = 0;
            this.btn_arac_oto_giris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_arac_oto_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arac_oto_giris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_arac_oto_giris.ImageKey = "3.png";
            this.btn_arac_oto_giris.ImageList = this.ımageList1;
            this.btn_arac_oto_giris.Location = new System.Drawing.Point(239, 24);
            this.btn_arac_oto_giris.Name = "btn_arac_oto_giris";
            this.btn_arac_oto_giris.Size = new System.Drawing.Size(108, 59);
            this.btn_arac_oto_giris.TabIndex = 2;
            this.btn_arac_oto_giris.Text = "Araç Otopark Girişi";
            this.btn_arac_oto_giris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_arac_oto_giris.UseVisualStyleBackColor = true;
            this.btn_arac_oto_giris.Click += new System.EventHandler(this.btn_arac_oto_giris_Click);
            // 
            // btn_müs_listele
            // 
            this.btn_müs_listele.FlatAppearance.BorderSize = 0;
            this.btn_müs_listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_müs_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_müs_listele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_müs_listele.ImageKey = "2.png";
            this.btn_müs_listele.ImageList = this.ımageList1;
            this.btn_müs_listele.Location = new System.Drawing.Point(125, 24);
            this.btn_müs_listele.Name = "btn_müs_listele";
            this.btn_müs_listele.Size = new System.Drawing.Size(108, 59);
            this.btn_müs_listele.TabIndex = 1;
            this.btn_müs_listele.Text = "Müşteri Listele";
            this.btn_müs_listele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_müs_listele.UseVisualStyleBackColor = true;
            this.btn_müs_listele.Click += new System.EventHandler(this.btn_müs_listele_Click);
            // 
            // btn_müs_ekle
            // 
            this.btn_müs_ekle.FlatAppearance.BorderSize = 0;
            this.btn_müs_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_müs_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_müs_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_müs_ekle.ImageKey = "1.png";
            this.btn_müs_ekle.ImageList = this.ımageList1;
            this.btn_müs_ekle.Location = new System.Drawing.Point(11, 24);
            this.btn_müs_ekle.Name = "btn_müs_ekle";
            this.btn_müs_ekle.Size = new System.Drawing.Size(108, 59);
            this.btn_müs_ekle.TabIndex = 0;
            this.btn_müs_ekle.Text = "Müşteri Ekle";
            this.btn_müs_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_müs_ekle.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsterilerToolStripMenuItem,
            this.araçİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.otoparkToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.ayarlarToolStripMenuItem1,
            this.çıkısToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müsterilerToolStripMenuItem
            // 
            this.müsterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriDüzenleToolStripMenuItem});
            this.müsterilerToolStripMenuItem.Name = "müsterilerToolStripMenuItem";
            this.müsterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müsterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            // 
            // müşteriDüzenleToolStripMenuItem
            // 
            this.müşteriDüzenleToolStripMenuItem.Name = "müşteriDüzenleToolStripMenuItem";
            this.müşteriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.müşteriDüzenleToolStripMenuItem.Text = "Müşteri Düzenle";
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçOtoparkGirişToolStripMenuItem,
            this.araçOtoparkÇıkışToolStripMenuItem});
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // araçOtoparkGirişToolStripMenuItem
            // 
            this.araçOtoparkGirişToolStripMenuItem.Name = "araçOtoparkGirişToolStripMenuItem";
            this.araçOtoparkGirişToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.araçOtoparkGirişToolStripMenuItem.Text = "Araç Otopark Giriş";
            // 
            // araçOtoparkÇıkışToolStripMenuItem
            // 
            this.araçOtoparkÇıkışToolStripMenuItem.Name = "araçOtoparkÇıkışToolStripMenuItem";
            this.araçOtoparkÇıkışToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.araçOtoparkÇıkışToolStripMenuItem.Text = "Araç Otopark Çıkış";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaTool,
            this.seriTool});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // markaTool
            // 
            this.markaTool.Name = "markaTool";
            this.markaTool.Size = new System.Drawing.Size(107, 22);
            this.markaTool.Text = "Marka";
            this.markaTool.Click += new System.EventHandler(this.markaTool_Click);
            // 
            // seriTool
            // 
            this.seriTool.Name = "seriTool";
            this.seriTool.Size = new System.Drawing.Size(107, 22);
            this.seriTool.Text = "Seri";
            this.seriTool.Click += new System.EventHandler(this.seriTool_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // otoparkToolStripMenuItem
            // 
            this.otoparkToolStripMenuItem.Name = "otoparkToolStripMenuItem";
            this.otoparkToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.otoparkToolStripMenuItem.Text = "Otopark";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // ayarlarToolStripMenuItem1
            // 
            this.ayarlarToolStripMenuItem1.Name = "ayarlarToolStripMenuItem1";
            this.ayarlarToolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // çıkısToolStripMenuItem
            // 
            this.çıkısToolStripMenuItem.Name = "çıkısToolStripMenuItem";
            this.çıkısToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkısToolStripMenuItem.Text = "Çıkış";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.Text = "OTOPARK KİRALAMA OTOMASYON";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müsterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkısToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkÇıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaTool;
        private System.Windows.Forms.ToolStripMenuItem seriTool;
        private System.Windows.Forms.Button btn_seri;
        private System.Windows.Forms.Button btn_marka;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.Button btn_oto_yer;
        private System.Windows.Forms.Button btn_arac_oto_cikis;
        private System.Windows.Forms.Button btn_arac_oto_giris;
        private System.Windows.Forms.Button btn_müs_listele;
        private System.Windows.Forms.Button btn_müs_ekle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

