namespace Sahibimden
{
    partial class MenuForm
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
            this.tabListe = new System.Windows.Forms.TabPage();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabEkle = new System.Windows.Forms.TabPage();
            this.gbxAciklama = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.gbxBilgi = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMotorHacmi = new System.Windows.Forms.TextBox();
            this.txtMotorGucu = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.cbRenk = new System.Windows.Forms.ComboBox();
            this.cbKasaTipi = new System.Windows.Forms.ComboBox();
            this.cbYakit = new System.Windows.Forms.ComboBox();
            this.cbVites = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbSeri = new System.Windows.Forms.ComboBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.lblMotorGucu = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblSeri = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblMotorHacmi = new System.Windows.Forms.Label();
            this.lblYakit = new System.Windows.Forms.Label();
            this.lblVites = new System.Windows.Forms.Label();
            this.lblKasaTipi = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabEkle.SuspendLayout();
            this.gbxAciklama.SuspendLayout();
            this.gbxBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabListe
            // 
            this.tabListe.Location = new System.Drawing.Point(4, 22);
            this.tabListe.Name = "tabListe";
            this.tabListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabListe.Size = new System.Drawing.Size(606, 455);
            this.tabListe.TabIndex = 0;
            this.tabListe.Text = "Araç Listesi";
            this.tabListe.UseVisualStyleBackColor = true;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabListe);
            this.tabMenu.Controls.Add(this.tabEkle);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(614, 481);
            this.tabMenu.TabIndex = 1;
            // 
            // tabEkle
            // 
            this.tabEkle.Controls.Add(this.gbxAciklama);
            this.tabEkle.Controls.Add(this.gbxBilgi);
            this.tabEkle.Location = new System.Drawing.Point(4, 22);
            this.tabEkle.Name = "tabEkle";
            this.tabEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabEkle.Size = new System.Drawing.Size(606, 455);
            this.tabEkle.TabIndex = 1;
            this.tabEkle.Text = "Araç Ekleme";
            this.tabEkle.UseVisualStyleBackColor = true;
            // 
            // gbxAciklama
            // 
            this.gbxAciklama.BackColor = System.Drawing.Color.DimGray;
            this.gbxAciklama.Controls.Add(this.txtAciklama);
            this.gbxAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAciklama.Location = new System.Drawing.Point(294, 3);
            this.gbxAciklama.Name = "gbxAciklama";
            this.gbxAciklama.Size = new System.Drawing.Size(309, 449);
            this.gbxAciklama.TabIndex = 15;
            this.gbxAciklama.TabStop = false;
            this.gbxAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 20);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(297, 423);
            this.txtAciklama.TabIndex = 0;
            this.txtAciklama.Text = "";
            // 
            // gbxBilgi
            // 
            this.gbxBilgi.BackColor = System.Drawing.Color.Silver;
            this.gbxBilgi.Controls.Add(this.btnKaydet);
            this.gbxBilgi.Controls.Add(this.cbDurum);
            this.gbxBilgi.Controls.Add(this.txtFiyat);
            this.gbxBilgi.Controls.Add(this.txtMotorHacmi);
            this.gbxBilgi.Controls.Add(this.txtMotorGucu);
            this.gbxBilgi.Controls.Add(this.txtKM);
            this.gbxBilgi.Controls.Add(this.txtYil);
            this.gbxBilgi.Controls.Add(this.cbRenk);
            this.gbxBilgi.Controls.Add(this.cbKasaTipi);
            this.gbxBilgi.Controls.Add(this.cbYakit);
            this.gbxBilgi.Controls.Add(this.cbVites);
            this.gbxBilgi.Controls.Add(this.cbModel);
            this.gbxBilgi.Controls.Add(this.cbSeri);
            this.gbxBilgi.Controls.Add(this.cbMarka);
            this.gbxBilgi.Controls.Add(this.lblMotorGucu);
            this.gbxBilgi.Controls.Add(this.lblMarka);
            this.gbxBilgi.Controls.Add(this.lblFiyat);
            this.gbxBilgi.Controls.Add(this.lblSeri);
            this.gbxBilgi.Controls.Add(this.lblDurum);
            this.gbxBilgi.Controls.Add(this.lblModel);
            this.gbxBilgi.Controls.Add(this.lblRenk);
            this.gbxBilgi.Controls.Add(this.lblYil);
            this.gbxBilgi.Controls.Add(this.lblMotorHacmi);
            this.gbxBilgi.Controls.Add(this.lblYakit);
            this.gbxBilgi.Controls.Add(this.lblVites);
            this.gbxBilgi.Controls.Add(this.lblKasaTipi);
            this.gbxBilgi.Controls.Add(this.lblKM);
            this.gbxBilgi.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxBilgi.Location = new System.Drawing.Point(3, 3);
            this.gbxBilgi.Name = "gbxBilgi";
            this.gbxBilgi.Size = new System.Drawing.Size(291, 449);
            this.gbxBilgi.TabIndex = 14;
            this.gbxBilgi.TabStop = false;
            this.gbxBilgi.Text = "Araç Bilgisi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(140, 397);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 46);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbDurum
            // 
            this.cbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "Sıfır",
            "2.El"});
            this.cbDurum.Location = new System.Drawing.Point(140, 368);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(121, 23);
            this.cbDurum.TabIndex = 25;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(140, 341);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 21);
            this.txtFiyat.TabIndex = 24;
            // 
            // txtMotorHacmi
            // 
            this.txtMotorHacmi.Location = new System.Drawing.Point(140, 285);
            this.txtMotorHacmi.Name = "txtMotorHacmi";
            this.txtMotorHacmi.Size = new System.Drawing.Size(121, 21);
            this.txtMotorHacmi.TabIndex = 23;
            // 
            // txtMotorGucu
            // 
            this.txtMotorGucu.Location = new System.Drawing.Point(140, 258);
            this.txtMotorGucu.Name = "txtMotorGucu";
            this.txtMotorGucu.Size = new System.Drawing.Size(121, 21);
            this.txtMotorGucu.TabIndex = 22;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(140, 202);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(121, 21);
            this.txtKM.TabIndex = 21;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(140, 117);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(121, 21);
            this.txtYil.TabIndex = 20;
            // 
            // cbRenk
            // 
            this.cbRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenk.FormattingEnabled = true;
            this.cbRenk.Items.AddRange(new object[] {
            "Mavi",
            "Beyaz",
            "Kırmızı"});
            this.cbRenk.Location = new System.Drawing.Point(140, 312);
            this.cbRenk.Name = "cbRenk";
            this.cbRenk.Size = new System.Drawing.Size(121, 23);
            this.cbRenk.TabIndex = 19;
            // 
            // cbKasaTipi
            // 
            this.cbKasaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKasaTipi.FormattingEnabled = true;
            this.cbKasaTipi.Items.AddRange(new object[] {
            "Sedan",
            "Cabrio",
            "Coupe",
            "Station Wagon"});
            this.cbKasaTipi.Location = new System.Drawing.Point(140, 229);
            this.cbKasaTipi.Name = "cbKasaTipi";
            this.cbKasaTipi.Size = new System.Drawing.Size(121, 23);
            this.cbKasaTipi.TabIndex = 18;
            // 
            // cbYakit
            // 
            this.cbYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYakit.FormattingEnabled = true;
            this.cbYakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Benzin-LPG",
            "Hybrid",
            "Elektrik"});
            this.cbYakit.Location = new System.Drawing.Point(140, 144);
            this.cbYakit.Name = "cbYakit";
            this.cbYakit.Size = new System.Drawing.Size(121, 23);
            this.cbYakit.TabIndex = 17;
            // 
            // cbVites
            // 
            this.cbVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVites.FormattingEnabled = true;
            this.cbVites.Items.AddRange(new object[] {
            "Otomatik",
            "Yarı Otomatik",
            "Manuel"});
            this.cbVites.Location = new System.Drawing.Point(140, 173);
            this.cbVites.Name = "cbVites";
            this.cbVites.Size = new System.Drawing.Size(121, 23);
            this.cbVites.TabIndex = 16;
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "116d",
            "116d ED",
            "116i",
            "118d",
            "118i",
            "120d",
            "120i"});
            this.cbModel.Location = new System.Drawing.Point(140, 88);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 23);
            this.cbModel.TabIndex = 15;
            // 
            // cbSeri
            // 
            this.cbSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeri.FormattingEnabled = true;
            this.cbSeri.Items.AddRange(new object[] {
            "1 Serisi"});
            this.cbSeri.Location = new System.Drawing.Point(140, 59);
            this.cbSeri.Name = "cbSeri";
            this.cbSeri.Size = new System.Drawing.Size(121, 23);
            this.cbSeri.TabIndex = 14;
            // 
            // cbMarka
            // 
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Items.AddRange(new object[] {
            "BMW"});
            this.cbMarka.Location = new System.Drawing.Point(140, 30);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(121, 23);
            this.cbMarka.TabIndex = 13;
            // 
            // lblMotorGucu
            // 
            this.lblMotorGucu.AutoSize = true;
            this.lblMotorGucu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorGucu.Location = new System.Drawing.Point(15, 263);
            this.lblMotorGucu.Name = "lblMotorGucu";
            this.lblMotorGucu.Size = new System.Drawing.Size(81, 16);
            this.lblMotorGucu.TabIndex = 8;
            this.lblMotorGucu.Text = "Motor Gücü";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarka.Location = new System.Drawing.Point(15, 37);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(46, 16);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyat.Location = new System.Drawing.Point(15, 346);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 16);
            this.lblFiyat.TabIndex = 12;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeri.Location = new System.Drawing.Point(15, 66);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(31, 16);
            this.lblSeri.TabIndex = 1;
            this.lblSeri.Text = "Seri";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.Location = new System.Drawing.Point(15, 375);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(51, 16);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "Durum";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(15, 95);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(47, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenk.Location = new System.Drawing.Point(15, 319);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(38, 16);
            this.lblRenk.TabIndex = 10;
            this.lblRenk.Text = "Renk";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYil.Location = new System.Drawing.Point(15, 122);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(24, 16);
            this.lblYil.TabIndex = 3;
            this.lblYil.Text = "Yıl";
            // 
            // lblMotorHacmi
            // 
            this.lblMotorHacmi.AutoSize = true;
            this.lblMotorHacmi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorHacmi.Location = new System.Drawing.Point(15, 290);
            this.lblMotorHacmi.Name = "lblMotorHacmi";
            this.lblMotorHacmi.Size = new System.Drawing.Size(89, 16);
            this.lblMotorHacmi.TabIndex = 9;
            this.lblMotorHacmi.Text = "Motor Hacmi";
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYakit.Location = new System.Drawing.Point(15, 151);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(39, 16);
            this.lblYakit.TabIndex = 4;
            this.lblYakit.Text = "Yakıt";
            // 
            // lblVites
            // 
            this.lblVites.AutoSize = true;
            this.lblVites.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVites.Location = new System.Drawing.Point(15, 180);
            this.lblVites.Name = "lblVites";
            this.lblVites.Size = new System.Drawing.Size(39, 16);
            this.lblVites.TabIndex = 5;
            this.lblVites.Text = "Vites";
            // 
            // lblKasaTipi
            // 
            this.lblKasaTipi.AutoSize = true;
            this.lblKasaTipi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKasaTipi.Location = new System.Drawing.Point(15, 236);
            this.lblKasaTipi.Name = "lblKasaTipi";
            this.lblKasaTipi.Size = new System.Drawing.Size(64, 16);
            this.lblKasaTipi.TabIndex = 7;
            this.lblKasaTipi.Text = "Kasa Tipi";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(15, 207);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(28, 16);
            this.lblKM.TabIndex = 6;
            this.lblKM.Text = "KM";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 481);
            this.Controls.Add(this.tabMenu);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabEkle.ResumeLayout(false);
            this.gbxAciklama.ResumeLayout(false);
            this.gbxBilgi.ResumeLayout(false);
            this.gbxBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabListe;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabEkle;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblMotorHacmi;
        private System.Windows.Forms.Label lblMotorGucu;
        private System.Windows.Forms.Label lblKasaTipi;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblVites;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.GroupBox gbxBilgi;
        private System.Windows.Forms.ComboBox cbDurum;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMotorHacmi;
        private System.Windows.Forms.TextBox txtMotorGucu;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.ComboBox cbRenk;
        private System.Windows.Forms.ComboBox cbKasaTipi;
        private System.Windows.Forms.ComboBox cbYakit;
        private System.Windows.Forms.ComboBox cbVites;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbSeri;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.GroupBox gbxAciklama;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
    }
}

