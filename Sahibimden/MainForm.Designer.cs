namespace Sahibimden
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAracEkle = new System.Windows.Forms.TabPage();
            this.pnlAciklamaHolder = new System.Windows.Forms.Panel();
            this.gbxAciklama = new System.Windows.Forms.GroupBox();
            this.pnlAciklama = new System.Windows.Forms.Panel();
            this.richBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.pnlArabaSecimi = new System.Windows.Forms.Panel();
            this.grpAraba = new System.Windows.Forms.GroupBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.picBoxAraba = new System.Windows.Forms.PictureBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.lblSeri = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.pnlAracBilgisi = new System.Windows.Forms.Panel();
            this.pnlBilgiUst = new System.Windows.Forms.Panel();
            this.gbxBilgi = new System.Windows.Forms.GroupBox();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.pnlBoxs = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabListe = new System.Windows.Forms.TabPage();
            this.pnlAracListesi = new System.Windows.Forms.Panel();
            this.dgvilan = new System.Windows.Forms.DataGridView();
            this.pnlCBoxs = new System.Windows.Forms.Panel();
            this.gbxChecks = new System.Windows.Forms.GroupBox();
            this.dialogResim = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMSMislem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOzellikIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAracEkle.SuspendLayout();
            this.pnlAciklamaHolder.SuspendLayout();
            this.gbxAciklama.SuspendLayout();
            this.pnlAciklama.SuspendLayout();
            this.pnlArabaSecimi.SuspendLayout();
            this.grpAraba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAraba)).BeginInit();
            this.pnlAracBilgisi.SuspendLayout();
            this.pnlBilgiUst.SuspendLayout();
            this.gbxBilgi.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabListe.SuspendLayout();
            this.pnlAracListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvilan)).BeginInit();
            this.pnlCBoxs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAracEkle
            // 
            this.tabAracEkle.Controls.Add(this.pnlAciklamaHolder);
            this.tabAracEkle.Controls.Add(this.pnlArabaSecimi);
            this.tabAracEkle.Controls.Add(this.pnlAracBilgisi);
            this.tabAracEkle.Location = new System.Drawing.Point(4, 22);
            this.tabAracEkle.Name = "tabAracEkle";
            this.tabAracEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabAracEkle.Size = new System.Drawing.Size(874, 463);
            this.tabAracEkle.TabIndex = 0;
            this.tabAracEkle.Text = "Araç Ekleme";
            this.tabAracEkle.UseVisualStyleBackColor = true;
            // 
            // pnlAciklamaHolder
            // 
            this.pnlAciklamaHolder.BackColor = System.Drawing.Color.DimGray;
            this.pnlAciklamaHolder.Controls.Add(this.gbxAciklama);
            this.pnlAciklamaHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAciklamaHolder.Location = new System.Drawing.Point(3, 153);
            this.pnlAciklamaHolder.Name = "pnlAciklamaHolder";
            this.pnlAciklamaHolder.Size = new System.Drawing.Size(576, 307);
            this.pnlAciklamaHolder.TabIndex = 11;
            // 
            // gbxAciklama
            // 
            this.gbxAciklama.BackColor = System.Drawing.Color.DarkGray;
            this.gbxAciklama.Controls.Add(this.pnlAciklama);
            this.gbxAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAciklama.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAciklama.Location = new System.Drawing.Point(0, 0);
            this.gbxAciklama.Name = "gbxAciklama";
            this.gbxAciklama.Size = new System.Drawing.Size(576, 307);
            this.gbxAciklama.TabIndex = 9;
            this.gbxAciklama.TabStop = false;
            this.gbxAciklama.Text = "Açıklama";
            // 
            // pnlAciklama
            // 
            this.pnlAciklama.BackColor = System.Drawing.Color.Gray;
            this.pnlAciklama.Controls.Add(this.richBoxAciklama);
            this.pnlAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAciklama.Location = new System.Drawing.Point(3, 19);
            this.pnlAciklama.Name = "pnlAciklama";
            this.pnlAciklama.Size = new System.Drawing.Size(570, 285);
            this.pnlAciklama.TabIndex = 0;
            // 
            // richBoxAciklama
            // 
            this.richBoxAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBoxAciklama.Location = new System.Drawing.Point(0, 0);
            this.richBoxAciklama.Name = "richBoxAciklama";
            this.richBoxAciklama.Size = new System.Drawing.Size(570, 285);
            this.richBoxAciklama.TabIndex = 0;
            this.richBoxAciklama.Text = "";
            // 
            // pnlArabaSecimi
            // 
            this.pnlArabaSecimi.BackColor = System.Drawing.Color.Gray;
            this.pnlArabaSecimi.Controls.Add(this.grpAraba);
            this.pnlArabaSecimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArabaSecimi.Location = new System.Drawing.Point(3, 3);
            this.pnlArabaSecimi.Name = "pnlArabaSecimi";
            this.pnlArabaSecimi.Size = new System.Drawing.Size(576, 150);
            this.pnlArabaSecimi.TabIndex = 10;
            // 
            // grpAraba
            // 
            this.grpAraba.BackColor = System.Drawing.Color.Gray;
            this.grpAraba.Controls.Add(this.btnResimEkle);
            this.grpAraba.Controls.Add(this.picBoxAraba);
            this.grpAraba.Controls.Add(this.cmbModel);
            this.grpAraba.Controls.Add(this.cmbSeri);
            this.grpAraba.Controls.Add(this.cmbMarka);
            this.grpAraba.Controls.Add(this.lblSeri);
            this.grpAraba.Controls.Add(this.lblModel);
            this.grpAraba.Controls.Add(this.lblMarka);
            this.grpAraba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAraba.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAraba.Location = new System.Drawing.Point(0, 0);
            this.grpAraba.Name = "grpAraba";
            this.grpAraba.Size = new System.Drawing.Size(576, 150);
            this.grpAraba.TabIndex = 8;
            this.grpAraba.TabStop = false;
            this.grpAraba.Text = "Araba Seçimi";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.Location = new System.Drawing.Point(166, 106);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(96, 28);
            this.btnResimEkle.TabIndex = 7;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // picBoxAraba
            // 
            this.picBoxAraba.BackColor = System.Drawing.Color.White;
            this.picBoxAraba.Location = new System.Drawing.Point(301, 11);
            this.picBoxAraba.Name = "picBoxAraba";
            this.picBoxAraba.Size = new System.Drawing.Size(272, 133);
            this.picBoxAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAraba.TabIndex = 6;
            this.picBoxAraba.TabStop = false;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Enabled = false;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(68, 76);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(194, 24);
            this.cmbModel.TabIndex = 5;
            // 
            // cmbSeri
            // 
            this.cmbSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeri.Enabled = false;
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(68, 49);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(194, 24);
            this.cmbSeri.TabIndex = 4;
            this.cmbSeri.SelectedIndexChanged += new System.EventHandler(this.cmbSeri_SelectedIndexChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(68, 22);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(194, 24);
            this.cmbMarka.TabIndex = 3;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Location = new System.Drawing.Point(19, 54);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(30, 16);
            this.lblSeri.TabIndex = 2;
            this.lblSeri.Text = "Seri";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(19, 79);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 16);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(19, 29);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(43, 16);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka";
            // 
            // pnlAracBilgisi
            // 
            this.pnlAracBilgisi.BackColor = System.Drawing.Color.DarkGray;
            this.pnlAracBilgisi.Controls.Add(this.pnlBilgiUst);
            this.pnlAracBilgisi.Controls.Add(this.pnlButtons);
            this.pnlAracBilgisi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAracBilgisi.Location = new System.Drawing.Point(579, 3);
            this.pnlAracBilgisi.Name = "pnlAracBilgisi";
            this.pnlAracBilgisi.Size = new System.Drawing.Size(292, 457);
            this.pnlAracBilgisi.TabIndex = 8;
            // 
            // pnlBilgiUst
            // 
            this.pnlBilgiUst.BackColor = System.Drawing.Color.DimGray;
            this.pnlBilgiUst.Controls.Add(this.gbxBilgi);
            this.pnlBilgiUst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBilgiUst.Location = new System.Drawing.Point(0, 0);
            this.pnlBilgiUst.Name = "pnlBilgiUst";
            this.pnlBilgiUst.Size = new System.Drawing.Size(292, 418);
            this.pnlBilgiUst.TabIndex = 8;
            // 
            // gbxBilgi
            // 
            this.gbxBilgi.BackColor = System.Drawing.Color.Silver;
            this.gbxBilgi.Controls.Add(this.pnlLabel);
            this.gbxBilgi.Controls.Add(this.pnlBoxs);
            this.gbxBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBilgi.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxBilgi.Location = new System.Drawing.Point(0, 0);
            this.gbxBilgi.Name = "gbxBilgi";
            this.gbxBilgi.Size = new System.Drawing.Size(292, 418);
            this.gbxBilgi.TabIndex = 6;
            this.gbxBilgi.TabStop = false;
            this.gbxBilgi.Text = "Araç Bilgisi";
            // 
            // pnlLabel
            // 
            this.pnlLabel.BackColor = System.Drawing.Color.Gray;
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLabel.Location = new System.Drawing.Point(3, 19);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(125, 396);
            this.pnlLabel.TabIndex = 3;
            // 
            // pnlBoxs
            // 
            this.pnlBoxs.BackColor = System.Drawing.Color.Gray;
            this.pnlBoxs.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBoxs.Location = new System.Drawing.Point(128, 19);
            this.pnlBoxs.Name = "pnlBoxs";
            this.pnlBoxs.Size = new System.Drawing.Size(161, 396);
            this.pnlBoxs.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnKaydet);
            this.pnlButtons.Controls.Add(this.btnTemizle);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 418);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(292, 39);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(152, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 31);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "İlan Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(50, 5);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 31);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabAracEkle);
            this.tabMenu.Controls.Add(this.tabListe);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 24);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(882, 489);
            this.tabMenu.TabIndex = 1;
            // 
            // tabListe
            // 
            this.tabListe.Controls.Add(this.pnlAracListesi);
            this.tabListe.Controls.Add(this.pnlCBoxs);
            this.tabListe.Location = new System.Drawing.Point(4, 22);
            this.tabListe.Name = "tabListe";
            this.tabListe.Size = new System.Drawing.Size(874, 463);
            this.tabListe.TabIndex = 1;
            this.tabListe.Text = "İlan Listesi";
            this.tabListe.UseVisualStyleBackColor = true;
            // 
            // pnlAracListesi
            // 
            this.pnlAracListesi.Controls.Add(this.dgvilan);
            this.pnlAracListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAracListesi.Location = new System.Drawing.Point(166, 0);
            this.pnlAracListesi.Name = "pnlAracListesi";
            this.pnlAracListesi.Size = new System.Drawing.Size(708, 463);
            this.pnlAracListesi.TabIndex = 4;
            // 
            // dgvilan
            // 
            this.dgvilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvilan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvilan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvilan.Location = new System.Drawing.Point(0, 0);
            this.dgvilan.Name = "dgvilan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvilan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvilan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvilan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvilan.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvilan.RowTemplate.Height = 75;
            this.dgvilan.RowTemplate.ReadOnly = true;
            this.dgvilan.Size = new System.Drawing.Size(708, 463);
            this.dgvilan.TabIndex = 1;
            // 
            // pnlCBoxs
            // 
            this.pnlCBoxs.Controls.Add(this.gbxChecks);
            this.pnlCBoxs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCBoxs.Location = new System.Drawing.Point(0, 0);
            this.pnlCBoxs.Name = "pnlCBoxs";
            this.pnlCBoxs.Size = new System.Drawing.Size(166, 463);
            this.pnlCBoxs.TabIndex = 3;
            // 
            // gbxChecks
            // 
            this.gbxChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxChecks.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChecks.Location = new System.Drawing.Point(0, 0);
            this.gbxChecks.Name = "gbxChecks";
            this.gbxChecks.Size = new System.Drawing.Size(166, 463);
            this.gbxChecks.TabIndex = 0;
            this.gbxChecks.TabStop = false;
            this.gbxChecks.Text = "Görüntülenen Özellikler";
            // 
            // dialogResim
            // 
            this.dialogResim.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDosya
            // 
            this.menuDosya.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMSMislem,
            this.menuOzellikIslem});
            this.menuDosya.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(52, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuMSMislem
            // 
            this.menuMSMislem.Name = "menuMSMislem";
            this.menuMSMislem.Size = new System.Drawing.Size(219, 22);
            this.menuMSMislem.Text = "Marka\\Seri\\Model İslemleri";
            this.menuMSMislem.Click += new System.EventHandler(this.menuMSMislem_Click);
            // 
            // menuOzellikIslem
            // 
            this.menuOzellikIslem.Name = "menuOzellikIslem";
            this.menuOzellikIslem.Size = new System.Drawing.Size(219, 22);
            this.menuOzellikIslem.Text = "Özellik İşlemleri";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 513);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabAracEkle.ResumeLayout(false);
            this.pnlAciklamaHolder.ResumeLayout(false);
            this.gbxAciklama.ResumeLayout(false);
            this.pnlAciklama.ResumeLayout(false);
            this.pnlArabaSecimi.ResumeLayout(false);
            this.grpAraba.ResumeLayout(false);
            this.grpAraba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAraba)).EndInit();
            this.pnlAracBilgisi.ResumeLayout(false);
            this.pnlBilgiUst.ResumeLayout(false);
            this.gbxBilgi.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabListe.ResumeLayout(false);
            this.pnlAracListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvilan)).EndInit();
            this.pnlCBoxs.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabAracEkle;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.GroupBox grpAraba;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.GroupBox gbxAciklama;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox picBoxAraba;
        private System.Windows.Forms.OpenFileDialog dialogResim;
        private System.Windows.Forms.TabPage tabListe;
        private System.Windows.Forms.Panel pnlCBoxs;
        private System.Windows.Forms.Panel pnlAracListesi;
        private System.Windows.Forms.DataGridView dgvilan;
        private System.Windows.Forms.GroupBox gbxChecks;
        private System.Windows.Forms.Panel pnlAciklamaHolder;
        private System.Windows.Forms.Panel pnlAciklama;
        private System.Windows.Forms.RichTextBox richBoxAciklama;
        private System.Windows.Forms.Panel pnlArabaSecimi;
        private System.Windows.Forms.Panel pnlAracBilgisi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox gbxBilgi;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Panel pnlBoxs;
        private System.Windows.Forms.Panel pnlBilgiUst;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuMSMislem;
        private System.Windows.Forms.ToolStripMenuItem menuOzellikIslem;
    }
}

