namespace Sahibimden
{
    partial class OzellikForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUstKategori = new System.Windows.Forms.TabPage();
            this.tabSecenekEkle = new System.Windows.Forms.TabPage();
            this.pnlBg = new System.Windows.Forms.Panel();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtUstKategori = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvUstKategori = new System.Windows.Forms.DataGridView();
            this.clmKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKategoriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSecenekBg = new System.Windows.Forms.Panel();
            this.dgvSecenek = new System.Windows.Forms.DataGridView();
            this.cmbUstKategori = new System.Windows.Forms.ComboBox();
            this.lblCmbKategori = new System.Windows.Forms.Label();
            this.txtSecenek = new System.Windows.Forms.TextBox();
            this.lblSecenek = new System.Windows.Forms.Label();
            this.btnSecenekEkle = new System.Windows.Forms.Button();
            this.btnSecenekVazgec = new System.Windows.Forms.Button();
            this.btnSecenekSil = new System.Windows.Forms.Button();
            this.clmAltKategoriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecenek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabUstKategori.SuspendLayout();
            this.tabSecenekEkle.SuspendLayout();
            this.pnlBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUstKategori)).BeginInit();
            this.pnlSecenekBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecenek)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUstKategori);
            this.tabControl1.Controls.Add(this.tabSecenekEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUstKategori
            // 
            this.tabUstKategori.Controls.Add(this.pnlBg);
            this.tabUstKategori.Location = new System.Drawing.Point(4, 21);
            this.tabUstKategori.Name = "tabUstKategori";
            this.tabUstKategori.Padding = new System.Windows.Forms.Padding(3);
            this.tabUstKategori.Size = new System.Drawing.Size(475, 162);
            this.tabUstKategori.TabIndex = 0;
            this.tabUstKategori.Text = "Üst Kategori ";
            this.tabUstKategori.UseVisualStyleBackColor = true;
            // 
            // tabSecenekEkle
            // 
            this.tabSecenekEkle.Controls.Add(this.pnlSecenekBg);
            this.tabSecenekEkle.Location = new System.Drawing.Point(4, 21);
            this.tabSecenekEkle.Name = "tabSecenekEkle";
            this.tabSecenekEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecenekEkle.Size = new System.Drawing.Size(475, 162);
            this.tabSecenekEkle.TabIndex = 1;
            this.tabSecenekEkle.Text = "Seçenek Ekle";
            this.tabSecenekEkle.UseVisualStyleBackColor = true;
            // 
            // pnlBg
            // 
            this.pnlBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBg.Controls.Add(this.btnVazgec);
            this.pnlBg.Controls.Add(this.btnSil);
            this.pnlBg.Controls.Add(this.lblKategori);
            this.pnlBg.Controls.Add(this.txtUstKategori);
            this.pnlBg.Controls.Add(this.btnEkle);
            this.pnlBg.Controls.Add(this.dgvUstKategori);
            this.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBg.Location = new System.Drawing.Point(3, 3);
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Size = new System.Drawing.Size(469, 156);
            this.pnlBg.TabIndex = 2;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Location = new System.Drawing.Point(93, 79);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Temizle";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(93, 108);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(12, 27);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(57, 14);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori:";
            // 
            // txtUstKategori
            // 
            this.txtUstKategori.Location = new System.Drawing.Point(75, 24);
            this.txtUstKategori.Name = "txtUstKategori";
            this.txtUstKategori.Size = new System.Drawing.Size(120, 20);
            this.txtUstKategori.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(93, 50);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvUstKategori
            // 
            this.dgvUstKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUstKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUstKategori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKategori,
            this.clmKategoriId});
            this.dgvUstKategori.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUstKategori.Location = new System.Drawing.Point(205, 0);
            this.dgvUstKategori.Name = "dgvUstKategori";
            this.dgvUstKategori.Size = new System.Drawing.Size(264, 156);
            this.dgvUstKategori.TabIndex = 0;
            this.dgvUstKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUstKategori_CellClick);
            // 
            // clmKategori
            // 
            this.clmKategori.DataPropertyName = "ad";
            this.clmKategori.HeaderText = "Kategori Adı";
            this.clmKategori.Name = "clmKategori";
            this.clmKategori.ReadOnly = true;
            // 
            // clmKategoriId
            // 
            this.clmKategoriId.DataPropertyName = "kategori_id";
            this.clmKategoriId.HeaderText = "KategoriId";
            this.clmKategoriId.Name = "clmKategoriId";
            this.clmKategoriId.Visible = false;
            // 
            // pnlSecenekBg
            // 
            this.pnlSecenekBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSecenekBg.Controls.Add(this.btnSecenekSil);
            this.pnlSecenekBg.Controls.Add(this.btnSecenekVazgec);
            this.pnlSecenekBg.Controls.Add(this.btnSecenekEkle);
            this.pnlSecenekBg.Controls.Add(this.lblSecenek);
            this.pnlSecenekBg.Controls.Add(this.txtSecenek);
            this.pnlSecenekBg.Controls.Add(this.lblCmbKategori);
            this.pnlSecenekBg.Controls.Add(this.cmbUstKategori);
            this.pnlSecenekBg.Controls.Add(this.dgvSecenek);
            this.pnlSecenekBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecenekBg.Location = new System.Drawing.Point(3, 3);
            this.pnlSecenekBg.Name = "pnlSecenekBg";
            this.pnlSecenekBg.Size = new System.Drawing.Size(469, 156);
            this.pnlSecenekBg.TabIndex = 0;
            // 
            // dgvSecenek
            // 
            this.dgvSecenek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecenek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecenek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAltKategoriId,
            this.clmSecenek});
            this.dgvSecenek.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvSecenek.Location = new System.Drawing.Point(217, 0);
            this.dgvSecenek.Name = "dgvSecenek";
            this.dgvSecenek.Size = new System.Drawing.Size(252, 156);
            this.dgvSecenek.TabIndex = 0;
            this.dgvSecenek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecenek_CellClick);
            // 
            // cmbUstKategori
            // 
            this.cmbUstKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUstKategori.FormattingEnabled = true;
            this.cmbUstKategori.Location = new System.Drawing.Point(77, 12);
            this.cmbUstKategori.Name = "cmbUstKategori";
            this.cmbUstKategori.Size = new System.Drawing.Size(134, 20);
            this.cmbUstKategori.TabIndex = 1;
            this.cmbUstKategori.SelectedIndexChanged += new System.EventHandler(this.cmbUstKategori_SelectedIndexChanged);
            // 
            // lblCmbKategori
            // 
            this.lblCmbKategori.AutoSize = true;
            this.lblCmbKategori.Location = new System.Drawing.Point(5, 15);
            this.lblCmbKategori.Name = "lblCmbKategori";
            this.lblCmbKategori.Size = new System.Drawing.Size(66, 12);
            this.lblCmbKategori.TabIndex = 2;
            this.lblCmbKategori.Text = "Üst Kategori";
            // 
            // txtSecenek
            // 
            this.txtSecenek.Location = new System.Drawing.Point(77, 38);
            this.txtSecenek.Name = "txtSecenek";
            this.txtSecenek.Size = new System.Drawing.Size(114, 20);
            this.txtSecenek.TabIndex = 3;
            // 
            // lblSecenek
            // 
            this.lblSecenek.AutoSize = true;
            this.lblSecenek.Location = new System.Drawing.Point(7, 44);
            this.lblSecenek.Name = "lblSecenek";
            this.lblSecenek.Size = new System.Drawing.Size(48, 12);
            this.lblSecenek.TabIndex = 4;
            this.lblSecenek.Text = "Seçenek";
            // 
            // btnSecenekEkle
            // 
            this.btnSecenekEkle.Location = new System.Drawing.Point(77, 65);
            this.btnSecenekEkle.Name = "btnSecenekEkle";
            this.btnSecenekEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSecenekEkle.TabIndex = 5;
            this.btnSecenekEkle.Text = "Ekle";
            this.btnSecenekEkle.UseVisualStyleBackColor = true;
            this.btnSecenekEkle.Click += new System.EventHandler(this.btnSecenekEkle_Click);
            // 
            // btnSecenekVazgec
            // 
            this.btnSecenekVazgec.Location = new System.Drawing.Point(77, 95);
            this.btnSecenekVazgec.Name = "btnSecenekVazgec";
            this.btnSecenekVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnSecenekVazgec.TabIndex = 6;
            this.btnSecenekVazgec.Text = "Vazgec";
            this.btnSecenekVazgec.UseVisualStyleBackColor = true;
            this.btnSecenekVazgec.Click += new System.EventHandler(this.btnSecenekVazgec_Click);
            // 
            // btnSecenekSil
            // 
            this.btnSecenekSil.Location = new System.Drawing.Point(77, 125);
            this.btnSecenekSil.Name = "btnSecenekSil";
            this.btnSecenekSil.Size = new System.Drawing.Size(75, 23);
            this.btnSecenekSil.TabIndex = 7;
            this.btnSecenekSil.Text = "Sil";
            this.btnSecenekSil.UseVisualStyleBackColor = true;
            this.btnSecenekSil.Visible = false;
            this.btnSecenekSil.Click += new System.EventHandler(this.btnSecenekSil_Click);
            // 
            // clmAltKategoriId
            // 
            this.clmAltKategoriId.DataPropertyName = "kategori_id";
            this.clmAltKategoriId.HeaderText = "Kategori Id";
            this.clmAltKategoriId.Name = "clmAltKategoriId";
            this.clmAltKategoriId.Visible = false;
            // 
            // clmSecenek
            // 
            this.clmSecenek.DataPropertyName = "ad";
            this.clmSecenek.HeaderText = "Seçenek";
            this.clmSecenek.Name = "clmSecenek";
            this.clmSecenek.ReadOnly = true;
            // 
            // OzellikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 187);
            this.Controls.Add(this.tabControl1);
            this.Name = "OzellikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OzellikForm";
            this.Load += new System.EventHandler(this.OzellikForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabUstKategori.ResumeLayout(false);
            this.tabSecenekEkle.ResumeLayout(false);
            this.pnlBg.ResumeLayout(false);
            this.pnlBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUstKategori)).EndInit();
            this.pnlSecenekBg.ResumeLayout(false);
            this.pnlSecenekBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecenek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUstKategori;
        private System.Windows.Forms.Panel pnlBg;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtUstKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvUstKategori;
        private System.Windows.Forms.TabPage tabSecenekEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKategoriId;
        private System.Windows.Forms.Panel pnlSecenekBg;
        private System.Windows.Forms.Button btnSecenekSil;
        private System.Windows.Forms.Button btnSecenekVazgec;
        private System.Windows.Forms.Button btnSecenekEkle;
        private System.Windows.Forms.Label lblSecenek;
        private System.Windows.Forms.TextBox txtSecenek;
        private System.Windows.Forms.Label lblCmbKategori;
        private System.Windows.Forms.ComboBox cmbUstKategori;
        private System.Windows.Forms.DataGridView dgvSecenek;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAltKategoriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecenek;
    }
}