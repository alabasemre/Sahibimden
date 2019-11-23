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
            this.grpAraba = new System.Windows.Forms.GroupBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAciklama = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlAciklama = new System.Windows.Forms.Panel();
            this.richBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.gbxBilgi = new System.Windows.Forms.GroupBox();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.pnlBoxs = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabListe.SuspendLayout();
            this.grpAraba.SuspendLayout();
            this.gbxAciklama.SuspendLayout();
            this.pnlAciklama.SuspendLayout();
            this.gbxBilgi.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabListe
            // 
            this.tabListe.Controls.Add(this.grpAraba);
            this.tabListe.Controls.Add(this.gbxAciklama);
            this.tabListe.Controls.Add(this.gbxBilgi);
            this.tabListe.Location = new System.Drawing.Point(4, 22);
            this.tabListe.Name = "tabListe";
            this.tabListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabListe.Size = new System.Drawing.Size(606, 455);
            this.tabListe.TabIndex = 0;
            this.tabListe.Text = "Araç Listesi";
            this.tabListe.UseVisualStyleBackColor = true;
            // 
            // grpAraba
            // 
            this.grpAraba.BackColor = System.Drawing.Color.Gray;
            this.grpAraba.Controls.Add(this.cmbModel);
            this.grpAraba.Controls.Add(this.cmbSeri);
            this.grpAraba.Controls.Add(this.cmbMarka);
            this.grpAraba.Controls.Add(this.label3);
            this.grpAraba.Controls.Add(this.label2);
            this.grpAraba.Controls.Add(this.label1);
            this.grpAraba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAraba.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAraba.Location = new System.Drawing.Point(3, 3);
            this.grpAraba.Name = "grpAraba";
            this.grpAraba.Size = new System.Drawing.Size(308, 108);
            this.grpAraba.TabIndex = 8;
            this.grpAraba.TabStop = false;
            this.grpAraba.Text = "Araba Seçimi";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Enabled = false;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(71, 71);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(194, 24);
            this.cmbModel.TabIndex = 5;
            // 
            // cmbSeri
            // 
            this.cmbSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeri.Enabled = false;
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(71, 44);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(194, 24);
            this.cmbSeri.TabIndex = 4;
            this.cmbSeri.SelectedIndexChanged += new System.EventHandler(this.cmbSeri_SelectedIndexChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(71, 17);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(194, 24);
            this.cmbMarka.TabIndex = 3;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // gbxAciklama
            // 
            this.gbxAciklama.BackColor = System.Drawing.Color.DarkGray;
            this.gbxAciklama.Controls.Add(this.btnTemizle);
            this.gbxAciklama.Controls.Add(this.btnKaydet);
            this.gbxAciklama.Controls.Add(this.pnlAciklama);
            this.gbxAciklama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxAciklama.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAciklama.Location = new System.Drawing.Point(3, 111);
            this.gbxAciklama.Name = "gbxAciklama";
            this.gbxAciklama.Size = new System.Drawing.Size(308, 341);
            this.gbxAciklama.TabIndex = 7;
            this.gbxAciklama.TabStop = false;
            this.gbxAciklama.Text = "Açıklama";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(147, 300);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 36);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(45, 301);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 35);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "İlan Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pnlAciklama
            // 
            this.pnlAciklama.BackColor = System.Drawing.Color.Gray;
            this.pnlAciklama.Controls.Add(this.richBoxAciklama);
            this.pnlAciklama.Location = new System.Drawing.Point(3, 15);
            this.pnlAciklama.Name = "pnlAciklama";
            this.pnlAciklama.Size = new System.Drawing.Size(302, 279);
            this.pnlAciklama.TabIndex = 0;
            // 
            // richBoxAciklama
            // 
            this.richBoxAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richBoxAciklama.Location = new System.Drawing.Point(0, 0);
            this.richBoxAciklama.Name = "richBoxAciklama";
            this.richBoxAciklama.Size = new System.Drawing.Size(302, 279);
            this.richBoxAciklama.TabIndex = 0;
            this.richBoxAciklama.Text = "";
            // 
            // gbxBilgi
            // 
            this.gbxBilgi.Controls.Add(this.pnlLabel);
            this.gbxBilgi.Controls.Add(this.pnlBoxs);
            this.gbxBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxBilgi.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBilgi.Location = new System.Drawing.Point(311, 3);
            this.gbxBilgi.Name = "gbxBilgi";
            this.gbxBilgi.Size = new System.Drawing.Size(292, 449);
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
            this.pnlLabel.Size = new System.Drawing.Size(124, 427);
            this.pnlLabel.TabIndex = 3;
            // 
            // pnlBoxs
            // 
            this.pnlBoxs.BackColor = System.Drawing.Color.Gray;
            this.pnlBoxs.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBoxs.Location = new System.Drawing.Point(126, 19);
            this.pnlBoxs.Name = "pnlBoxs";
            this.pnlBoxs.Size = new System.Drawing.Size(163, 427);
            this.pnlBoxs.TabIndex = 4;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabListe);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(614, 481);
            this.tabMenu.TabIndex = 1;
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
            this.tabListe.ResumeLayout(false);
            this.grpAraba.ResumeLayout(false);
            this.grpAraba.PerformLayout();
            this.gbxAciklama.ResumeLayout(false);
            this.pnlAciklama.ResumeLayout(false);
            this.gbxBilgi.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabListe;
        private System.Windows.Forms.GroupBox gbxBilgi;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Panel pnlBoxs;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.GroupBox gbxAciklama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel pnlAciklama;
        private System.Windows.Forms.RichTextBox richBoxAciklama;
        private System.Windows.Forms.GroupBox grpAraba;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

