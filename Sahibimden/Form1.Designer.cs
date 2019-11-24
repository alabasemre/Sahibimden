﻿namespace Sahibimden
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
            this.tabAracEkle = new System.Windows.Forms.TabPage();
            this.gbxAciklama = new System.Windows.Forms.GroupBox();
            this.pnlAciklama = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.richBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.grpAraba = new System.Windows.Forms.GroupBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.picBoxAraba = new System.Windows.Forms.PictureBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBilgi = new System.Windows.Forms.GroupBox();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.pnlBoxs = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dialogResim = new System.Windows.Forms.OpenFileDialog();
            this.dgvilan = new System.Windows.Forms.DataGridView();
            this.cbKilometre = new System.Windows.Forms.CheckBox();
            this.cbFiyat = new System.Windows.Forms.CheckBox();
            this.tabAracEkle.SuspendLayout();
            this.gbxAciklama.SuspendLayout();
            this.pnlAciklama.SuspendLayout();
            this.grpAraba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAraba)).BeginInit();
            this.gbxBilgi.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvilan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAracEkle
            // 
            this.tabAracEkle.Controls.Add(this.gbxAciklama);
            this.tabAracEkle.Controls.Add(this.grpAraba);
            this.tabAracEkle.Controls.Add(this.gbxBilgi);
            this.tabAracEkle.Location = new System.Drawing.Point(4, 22);
            this.tabAracEkle.Name = "tabAracEkle";
            this.tabAracEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabAracEkle.Size = new System.Drawing.Size(810, 464);
            this.tabAracEkle.TabIndex = 0;
            this.tabAracEkle.Text = "Araç Ekleme";
            this.tabAracEkle.UseVisualStyleBackColor = true;
            // 
            // gbxAciklama
            // 
            this.gbxAciklama.BackColor = System.Drawing.Color.DarkGray;
            this.gbxAciklama.Controls.Add(this.pnlAciklama);
            this.gbxAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAciklama.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAciklama.Location = new System.Drawing.Point(3, 150);
            this.gbxAciklama.Name = "gbxAciklama";
            this.gbxAciklama.Size = new System.Drawing.Size(511, 311);
            this.gbxAciklama.TabIndex = 9;
            this.gbxAciklama.TabStop = false;
            this.gbxAciklama.Text = "Açıklama";
            // 
            // pnlAciklama
            // 
            this.pnlAciklama.BackColor = System.Drawing.Color.Gray;
            this.pnlAciklama.Controls.Add(this.btnKaydet);
            this.pnlAciklama.Controls.Add(this.btnTemizle);
            this.pnlAciklama.Controls.Add(this.richBoxAciklama);
            this.pnlAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAciklama.Location = new System.Drawing.Point(3, 19);
            this.pnlAciklama.Name = "pnlAciklama";
            this.pnlAciklama.Size = new System.Drawing.Size(505, 289);
            this.pnlAciklama.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(223, 256);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 28);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "İlan Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(110, 257);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 27);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // richBoxAciklama
            // 
            this.richBoxAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.richBoxAciklama.Location = new System.Drawing.Point(0, 0);
            this.richBoxAciklama.Name = "richBoxAciklama";
            this.richBoxAciklama.Size = new System.Drawing.Size(505, 251);
            this.richBoxAciklama.TabIndex = 0;
            this.richBoxAciklama.Text = "";
            // 
            // grpAraba
            // 
            this.grpAraba.BackColor = System.Drawing.Color.Gray;
            this.grpAraba.Controls.Add(this.btnResimEkle);
            this.grpAraba.Controls.Add(this.picBoxAraba);
            this.grpAraba.Controls.Add(this.cmbModel);
            this.grpAraba.Controls.Add(this.cmbSeri);
            this.grpAraba.Controls.Add(this.cmbMarka);
            this.grpAraba.Controls.Add(this.label3);
            this.grpAraba.Controls.Add(this.label2);
            this.grpAraba.Controls.Add(this.label1);
            this.grpAraba.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAraba.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAraba.Location = new System.Drawing.Point(3, 3);
            this.grpAraba.Name = "grpAraba";
            this.grpAraba.Size = new System.Drawing.Size(511, 147);
            this.grpAraba.TabIndex = 8;
            this.grpAraba.TabStop = false;
            this.grpAraba.Text = "Araba Seçimi";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.Location = new System.Drawing.Point(156, 104);
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
            this.picBoxAraba.Location = new System.Drawing.Point(258, 11);
            this.picBoxAraba.Name = "picBoxAraba";
            this.picBoxAraba.Size = new System.Drawing.Size(243, 130);
            this.picBoxAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAraba.TabIndex = 6;
            this.picBoxAraba.TabStop = false;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Enabled = false;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(58, 74);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(194, 24);
            this.cmbModel.TabIndex = 5;
            // 
            // cmbSeri
            // 
            this.cmbSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeri.Enabled = false;
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(58, 47);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(194, 24);
            this.cmbSeri.TabIndex = 4;
            this.cmbSeri.SelectedIndexChanged += new System.EventHandler(this.cmbSeri_SelectedIndexChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(58, 20);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(194, 24);
            this.cmbMarka.TabIndex = 3;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // gbxBilgi
            // 
            this.gbxBilgi.Controls.Add(this.pnlLabel);
            this.gbxBilgi.Controls.Add(this.pnlBoxs);
            this.gbxBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxBilgi.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBilgi.Location = new System.Drawing.Point(514, 3);
            this.gbxBilgi.Name = "gbxBilgi";
            this.gbxBilgi.Size = new System.Drawing.Size(293, 458);
            this.gbxBilgi.TabIndex = 5;
            this.gbxBilgi.TabStop = false;
            this.gbxBilgi.Text = "Araç Bilgisi";
            // 
            // pnlLabel
            // 
            this.pnlLabel.BackColor = System.Drawing.Color.Gray;
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLabel.Location = new System.Drawing.Point(3, 19);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(124, 436);
            this.pnlLabel.TabIndex = 3;
            // 
            // pnlBoxs
            // 
            this.pnlBoxs.BackColor = System.Drawing.Color.Gray;
            this.pnlBoxs.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBoxs.Location = new System.Drawing.Point(127, 19);
            this.pnlBoxs.Name = "pnlBoxs";
            this.pnlBoxs.Size = new System.Drawing.Size(163, 436);
            this.pnlBoxs.TabIndex = 4;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabAracEkle);
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(818, 490);
            this.tabMenu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbFiyat);
            this.tabPage1.Controls.Add(this.cbKilometre);
            this.tabPage1.Controls.Add(this.dgvilan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(810, 464);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "İlan Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dialogResim
            // 
            this.dialogResim.FileName = "openFileDialog1";
            // 
            // dgvilan
            // 
            this.dgvilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvilan.Location = new System.Drawing.Point(208, 3);
            this.dgvilan.Name = "dgvilan";
            this.dgvilan.RowTemplate.Height = 75;
            this.dgvilan.Size = new System.Drawing.Size(594, 238);
            this.dgvilan.TabIndex = 0;
            // 
            // cbKilometre
            // 
            this.cbKilometre.AutoSize = true;
            this.cbKilometre.Location = new System.Drawing.Point(40, 27);
            this.cbKilometre.Name = "cbKilometre";
            this.cbKilometre.Size = new System.Drawing.Size(69, 17);
            this.cbKilometre.TabIndex = 1;
            this.cbKilometre.Text = "Kilometre";
            this.cbKilometre.UseVisualStyleBackColor = true;
            // 
            // cbFiyat
            // 
            this.cbFiyat.AutoSize = true;
            this.cbFiyat.Location = new System.Drawing.Point(40, 51);
            this.cbFiyat.Name = "cbFiyat";
            this.cbFiyat.Size = new System.Drawing.Size(48, 17);
            this.cbFiyat.TabIndex = 2;
            this.cbFiyat.Text = "Fiyat";
            this.cbFiyat.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 490);
            this.Controls.Add(this.tabMenu);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAracEkle.ResumeLayout(false);
            this.gbxAciklama.ResumeLayout(false);
            this.pnlAciklama.ResumeLayout(false);
            this.grpAraba.ResumeLayout(false);
            this.grpAraba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAraba)).EndInit();
            this.gbxBilgi.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvilan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAracEkle;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.GroupBox grpAraba;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAciklama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel pnlAciklama;
        private System.Windows.Forms.RichTextBox richBoxAciklama;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox picBoxAraba;
        private System.Windows.Forms.GroupBox gbxBilgi;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Panel pnlBoxs;
        private System.Windows.Forms.OpenFileDialog dialogResim;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbFiyat;
        private System.Windows.Forms.CheckBox cbKilometre;
        private System.Windows.Forms.DataGridView dgvilan;
    }
}

