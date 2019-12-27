namespace Sahibimden
{
    partial class AracDetay
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
            this.tabBilgi = new System.Windows.Forms.TabPage();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblSeri = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarkatxt = new System.Windows.Forms.Label();
            this.lblSeritxt = new System.Windows.Forms.Label();
            this.lblModeltxt = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTarihtxt = new System.Windows.Forms.Label();
            this.picAraba = new System.Windows.Forms.PictureBox();
            this.pnlOzellik = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.dgvAracDetay = new System.Windows.Forms.DataGridView();
            this.clmKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAciklama = new System.Windows.Forms.TabPage();
            this.rcTxtAciklama = new System.Windows.Forms.RichTextBox();
            this.tabBilgi.SuspendLayout();
            this.pnlBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAraba)).BeginInit();
            this.pnlOzellik.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracDetay)).BeginInit();
            this.tabAciklama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBilgi
            // 
            this.tabBilgi.Controls.Add(this.pnlOzellik);
            this.tabBilgi.Controls.Add(this.pnlBilgi);
            this.tabBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabBilgi.Location = new System.Drawing.Point(4, 25);
            this.tabBilgi.Name = "tabBilgi";
            this.tabBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tabBilgi.Size = new System.Drawing.Size(537, 311);
            this.tabBilgi.TabIndex = 0;
            this.tabBilgi.Text = "Bilgi";
            this.tabBilgi.UseVisualStyleBackColor = true;
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBilgi.Controls.Add(this.picAraba);
            this.pnlBilgi.Controls.Add(this.lblTarihtxt);
            this.pnlBilgi.Controls.Add(this.lblTarih);
            this.pnlBilgi.Controls.Add(this.btnSil);
            this.pnlBilgi.Controls.Add(this.btnGüncelle);
            this.pnlBilgi.Controls.Add(this.lblModeltxt);
            this.pnlBilgi.Controls.Add(this.lblSeritxt);
            this.pnlBilgi.Controls.Add(this.lblMarkatxt);
            this.pnlBilgi.Controls.Add(this.lblModel);
            this.pnlBilgi.Controls.Add(this.lblSeri);
            this.pnlBilgi.Controls.Add(this.lblMarka);
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBilgi.Location = new System.Drawing.Point(288, 3);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(246, 305);
            this.pnlBilgi.TabIndex = 3;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(39, 154);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(50, 15);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka:";
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeri.Location = new System.Drawing.Point(39, 178);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(35, 15);
            this.lblSeri.TabIndex = 1;
            this.lblSeri.Text = "Seri:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(39, 202);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // lblMarkatxt
            // 
            this.lblMarkatxt.AutoSize = true;
            this.lblMarkatxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarkatxt.Location = new System.Drawing.Point(96, 154);
            this.lblMarkatxt.Name = "lblMarkatxt";
            this.lblMarkatxt.Size = new System.Drawing.Size(16, 15);
            this.lblMarkatxt.TabIndex = 3;
            this.lblMarkatxt.Text = "...";
            // 
            // lblSeritxt
            // 
            this.lblSeritxt.AutoSize = true;
            this.lblSeritxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeritxt.Location = new System.Drawing.Point(96, 178);
            this.lblSeritxt.Name = "lblSeritxt";
            this.lblSeritxt.Size = new System.Drawing.Size(16, 15);
            this.lblSeritxt.TabIndex = 4;
            this.lblSeritxt.Text = "...";
            // 
            // lblModeltxt
            // 
            this.lblModeltxt.AutoSize = true;
            this.lblModeltxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModeltxt.Location = new System.Drawing.Point(96, 202);
            this.lblModeltxt.Name = "lblModeltxt";
            this.lblModeltxt.Size = new System.Drawing.Size(16, 15);
            this.lblModeltxt.TabIndex = 5;
            this.lblModeltxt.Text = "...";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(137, 249);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(137, 278);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(13, 227);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(74, 15);
            this.lblTarih.TabIndex = 8;
            this.lblTarih.Text = "İlan Tarihi:";
            // 
            // lblTarihtxt
            // 
            this.lblTarihtxt.AutoSize = true;
            this.lblTarihtxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihtxt.Location = new System.Drawing.Point(96, 227);
            this.lblTarihtxt.Name = "lblTarihtxt";
            this.lblTarihtxt.Size = new System.Drawing.Size(16, 15);
            this.lblTarihtxt.TabIndex = 9;
            this.lblTarihtxt.Text = "...";
            // 
            // picAraba
            // 
            this.picAraba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAraba.Location = new System.Drawing.Point(16, 10);
            this.picAraba.Name = "picAraba";
            this.picAraba.Size = new System.Drawing.Size(217, 134);
            this.picAraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAraba.TabIndex = 10;
            this.picAraba.TabStop = false;
            // 
            // pnlOzellik
            // 
            this.pnlOzellik.Controls.Add(this.groupBox1);
            this.pnlOzellik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOzellik.Location = new System.Drawing.Point(3, 3);
            this.pnlOzellik.Name = "pnlOzellik";
            this.pnlOzellik.Size = new System.Drawing.Size(285, 305);
            this.pnlOzellik.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.dgvAracDetay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özellikler";
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabBilgi);
            this.tabMenu.Controls.Add(this.tabAciklama);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(545, 340);
            this.tabMenu.TabIndex = 4;
            // 
            // dgvAracDetay
            // 
            this.dgvAracDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAracDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAracDetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKategori,
            this.clmDeger});
            this.dgvAracDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAracDetay.Location = new System.Drawing.Point(3, 17);
            this.dgvAracDetay.Name = "dgvAracDetay";
            this.dgvAracDetay.Size = new System.Drawing.Size(279, 285);
            this.dgvAracDetay.TabIndex = 0;
            // 
            // clmKategori
            // 
            this.clmKategori.DataPropertyName = "ad";
            this.clmKategori.HeaderText = "Kategori";
            this.clmKategori.Name = "clmKategori";
            this.clmKategori.ReadOnly = true;
            // 
            // clmDeger
            // 
            this.clmDeger.DataPropertyName = "deger";
            this.clmDeger.HeaderText = "Deger";
            this.clmDeger.Name = "clmDeger";
            this.clmDeger.ReadOnly = true;
            // 
            // tabAciklama
            // 
            this.tabAciklama.Controls.Add(this.rcTxtAciklama);
            this.tabAciklama.Location = new System.Drawing.Point(4, 25);
            this.tabAciklama.Name = "tabAciklama";
            this.tabAciklama.Padding = new System.Windows.Forms.Padding(3);
            this.tabAciklama.Size = new System.Drawing.Size(537, 311);
            this.tabAciklama.TabIndex = 1;
            this.tabAciklama.Text = "Açıklama";
            this.tabAciklama.UseVisualStyleBackColor = true;
            // 
            // rcTxtAciklama
            // 
            this.rcTxtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcTxtAciklama.Enabled = false;
            this.rcTxtAciklama.Location = new System.Drawing.Point(3, 3);
            this.rcTxtAciklama.Name = "rcTxtAciklama";
            this.rcTxtAciklama.Size = new System.Drawing.Size(531, 305);
            this.rcTxtAciklama.TabIndex = 0;
            this.rcTxtAciklama.Text = "";
            // 
            // AracDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 340);
            this.Controls.Add(this.tabMenu);
            this.Name = "AracDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArabaDetay";
            this.tabBilgi.ResumeLayout(false);
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAraba)).EndInit();
            this.pnlOzellik.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracDetay)).EndInit();
            this.tabAciklama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabBilgi;
        private System.Windows.Forms.Panel pnlOzellik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.PictureBox picAraba;
        private System.Windows.Forms.Label lblTarihtxt;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblModeltxt;
        private System.Windows.Forms.Label lblSeritxt;
        private System.Windows.Forms.Label lblMarkatxt;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.DataGridView dgvAracDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeger;
        private System.Windows.Forms.TabPage tabAciklama;
        private System.Windows.Forms.RichTextBox rcTxtAciklama;
    }
}