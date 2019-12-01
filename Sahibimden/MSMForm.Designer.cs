namespace Sahibimden
{
    partial class MSMForm
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
            this.pnlArkaPlan = new System.Windows.Forms.Panel();
            this.tabMSM = new System.Windows.Forms.TabControl();
            this.tabMarka = new System.Windows.Forms.TabPage();
            this.pnlMarkaListHolder = new System.Windows.Forms.Panel();
            this.gbxMarkaList = new System.Windows.Forms.GroupBox();
            this.dgvMarkaList = new System.Windows.Forms.DataGridView();
            this.pnlMarkaHolder = new System.Windows.Forms.Panel();
            this.gbxMarkaIslem = new System.Windows.Forms.GroupBox();
            this.btnMarkaVazgec = new System.Windows.Forms.Button();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.tabSeri = new System.Windows.Forms.TabPage();
            this.pnlSeriBG = new System.Windows.Forms.Panel();
            this.pnlSeriRight = new System.Windows.Forms.Panel();
            this.gbxSeriListe = new System.Windows.Forms.GroupBox();
            this.dgvSeriList = new System.Windows.Forms.DataGridView();
            this.pnlSeriLeft = new System.Windows.Forms.Panel();
            this.gbxSeriIslem = new System.Windows.Forms.GroupBox();
            this.btnSeriSil = new System.Windows.Forms.Button();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.lblSeri = new System.Windows.Forms.Label();
            this.btnSeriVazgec = new System.Windows.Forms.Button();
            this.btnSeriEkle = new System.Windows.Forms.Button();
            this.lblSMarka = new System.Windows.Forms.Label();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.pnlModelBG = new System.Windows.Forms.Panel();
            this.pnlModelRight = new System.Windows.Forms.Panel();
            this.gbxModelListe = new System.Windows.Forms.GroupBox();
            this.dgvModelListe = new System.Windows.Forms.DataGridView();
            this.pnlModelLeft = new System.Windows.Forms.Panel();
            this.gbxModelislem = new System.Windows.Forms.GroupBox();
            this.btnModelSil = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbSeri = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnModelTemizle = new System.Windows.Forms.Button();
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.lblMSeri = new System.Windows.Forms.Label();
            this.lblMarkaAra = new System.Windows.Forms.Label();
            this.txtMarkaAra = new System.Windows.Forms.TextBox();
            this.btnMarkaAra = new System.Windows.Forms.Button();
            this.pnlArkaPlan.SuspendLayout();
            this.tabMSM.SuspendLayout();
            this.tabMarka.SuspendLayout();
            this.pnlMarkaListHolder.SuspendLayout();
            this.gbxMarkaList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaList)).BeginInit();
            this.pnlMarkaHolder.SuspendLayout();
            this.gbxMarkaIslem.SuspendLayout();
            this.tabSeri.SuspendLayout();
            this.pnlSeriBG.SuspendLayout();
            this.pnlSeriRight.SuspendLayout();
            this.gbxSeriListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeriList)).BeginInit();
            this.pnlSeriLeft.SuspendLayout();
            this.gbxSeriIslem.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.pnlModelBG.SuspendLayout();
            this.pnlModelRight.SuspendLayout();
            this.gbxModelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelListe)).BeginInit();
            this.pnlModelLeft.SuspendLayout();
            this.gbxModelislem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArkaPlan
            // 
            this.pnlArkaPlan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlArkaPlan.Controls.Add(this.tabMSM);
            this.pnlArkaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlArkaPlan.Name = "pnlArkaPlan";
            this.pnlArkaPlan.Size = new System.Drawing.Size(509, 228);
            this.pnlArkaPlan.TabIndex = 0;
            // 
            // tabMSM
            // 
            this.tabMSM.Controls.Add(this.tabMarka);
            this.tabMSM.Controls.Add(this.tabSeri);
            this.tabMSM.Controls.Add(this.tabModel);
            this.tabMSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMSM.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabMSM.Location = new System.Drawing.Point(0, 0);
            this.tabMSM.Name = "tabMSM";
            this.tabMSM.SelectedIndex = 0;
            this.tabMSM.Size = new System.Drawing.Size(509, 228);
            this.tabMSM.TabIndex = 0;
            // 
            // tabMarka
            // 
            this.tabMarka.Controls.Add(this.pnlMarkaListHolder);
            this.tabMarka.Controls.Add(this.pnlMarkaHolder);
            this.tabMarka.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMarka.Location = new System.Drawing.Point(4, 23);
            this.tabMarka.Name = "tabMarka";
            this.tabMarka.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarka.Size = new System.Drawing.Size(501, 201);
            this.tabMarka.TabIndex = 0;
            this.tabMarka.Text = "Marka İslemleri";
            this.tabMarka.UseVisualStyleBackColor = true;
            // 
            // pnlMarkaListHolder
            // 
            this.pnlMarkaListHolder.BackColor = System.Drawing.Color.Gray;
            this.pnlMarkaListHolder.Controls.Add(this.gbxMarkaList);
            this.pnlMarkaListHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMarkaListHolder.Location = new System.Drawing.Point(181, 3);
            this.pnlMarkaListHolder.Name = "pnlMarkaListHolder";
            this.pnlMarkaListHolder.Size = new System.Drawing.Size(317, 195);
            this.pnlMarkaListHolder.TabIndex = 1;
            // 
            // gbxMarkaList
            // 
            this.gbxMarkaList.BackColor = System.Drawing.Color.Silver;
            this.gbxMarkaList.Controls.Add(this.dgvMarkaList);
            this.gbxMarkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMarkaList.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMarkaList.Location = new System.Drawing.Point(0, 0);
            this.gbxMarkaList.Name = "gbxMarkaList";
            this.gbxMarkaList.Size = new System.Drawing.Size(317, 195);
            this.gbxMarkaList.TabIndex = 0;
            this.gbxMarkaList.TabStop = false;
            this.gbxMarkaList.Text = "Marka Listesi";
            // 
            // dgvMarkaList
            // 
            this.dgvMarkaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarkaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarkaList.Location = new System.Drawing.Point(3, 18);
            this.dgvMarkaList.Name = "dgvMarkaList";
            this.dgvMarkaList.Size = new System.Drawing.Size(311, 174);
            this.dgvMarkaList.TabIndex = 0;
            this.dgvMarkaList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkaList_CellClick);
            // 
            // pnlMarkaHolder
            // 
            this.pnlMarkaHolder.BackColor = System.Drawing.Color.Aqua;
            this.pnlMarkaHolder.Controls.Add(this.gbxMarkaIslem);
            this.pnlMarkaHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarkaHolder.Location = new System.Drawing.Point(3, 3);
            this.pnlMarkaHolder.Name = "pnlMarkaHolder";
            this.pnlMarkaHolder.Size = new System.Drawing.Size(178, 195);
            this.pnlMarkaHolder.TabIndex = 0;
            // 
            // gbxMarkaIslem
            // 
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaAra);
            this.gbxMarkaIslem.Controls.Add(this.txtMarkaAra);
            this.gbxMarkaIslem.Controls.Add(this.lblMarkaAra);
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaVazgec);
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaSil);
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaEkle);
            this.gbxMarkaIslem.Controls.Add(this.lblMarka);
            this.gbxMarkaIslem.Controls.Add(this.txtMarka);
            this.gbxMarkaIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMarkaIslem.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxMarkaIslem.Location = new System.Drawing.Point(0, 0);
            this.gbxMarkaIslem.Name = "gbxMarkaIslem";
            this.gbxMarkaIslem.Size = new System.Drawing.Size(178, 195);
            this.gbxMarkaIslem.TabIndex = 0;
            this.gbxMarkaIslem.TabStop = false;
            this.gbxMarkaIslem.Text = "Marka İslemleri";
            // 
            // btnMarkaVazgec
            // 
            this.btnMarkaVazgec.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaVazgec.Location = new System.Drawing.Point(67, 77);
            this.btnMarkaVazgec.Name = "btnMarkaVazgec";
            this.btnMarkaVazgec.Size = new System.Drawing.Size(103, 24);
            this.btnMarkaVazgec.TabIndex = 8;
            this.btnMarkaVazgec.Text = "Temizle\\Vazgeç";
            this.btnMarkaVazgec.UseVisualStyleBackColor = true;
            this.btnMarkaVazgec.Click += new System.EventHandler(this.btnMarkaVazgec_Click);
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaSil.Location = new System.Drawing.Point(67, 106);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(103, 24);
            this.btnMarkaSil.TabIndex = 7;
            this.btnMarkaSil.Text = "Sil";
            this.btnMarkaSil.UseVisualStyleBackColor = true;
            this.btnMarkaSil.Visible = false;
            this.btnMarkaSil.Click += new System.EventHandler(this.btnMarkaSil_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(67, 48);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(103, 24);
            this.btnMarkaEkle.TabIndex = 6;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.BackColor = System.Drawing.Color.Transparent;
            this.lblMarka.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(6, 24);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(43, 14);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(55, 21);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(115, 22);
            this.txtMarka.TabIndex = 4;
            // 
            // tabSeri
            // 
            this.tabSeri.Controls.Add(this.pnlSeriBG);
            this.tabSeri.Location = new System.Drawing.Point(4, 23);
            this.tabSeri.Name = "tabSeri";
            this.tabSeri.Size = new System.Drawing.Size(501, 201);
            this.tabSeri.TabIndex = 1;
            this.tabSeri.Text = "Seri İslemleri";
            this.tabSeri.UseVisualStyleBackColor = true;
            // 
            // pnlSeriBG
            // 
            this.pnlSeriBG.BackColor = System.Drawing.Color.Aqua;
            this.pnlSeriBG.Controls.Add(this.pnlSeriRight);
            this.pnlSeriBG.Controls.Add(this.pnlSeriLeft);
            this.pnlSeriBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeriBG.Location = new System.Drawing.Point(0, 0);
            this.pnlSeriBG.Name = "pnlSeriBG";
            this.pnlSeriBG.Size = new System.Drawing.Size(501, 201);
            this.pnlSeriBG.TabIndex = 0;
            // 
            // pnlSeriRight
            // 
            this.pnlSeriRight.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlSeriRight.Controls.Add(this.gbxSeriListe);
            this.pnlSeriRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeriRight.Location = new System.Drawing.Point(185, 0);
            this.pnlSeriRight.Name = "pnlSeriRight";
            this.pnlSeriRight.Size = new System.Drawing.Size(316, 201);
            this.pnlSeriRight.TabIndex = 1;
            // 
            // gbxSeriListe
            // 
            this.gbxSeriListe.BackColor = System.Drawing.Color.Silver;
            this.gbxSeriListe.Controls.Add(this.dgvSeriList);
            this.gbxSeriListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSeriListe.Location = new System.Drawing.Point(0, 0);
            this.gbxSeriListe.Name = "gbxSeriListe";
            this.gbxSeriListe.Size = new System.Drawing.Size(316, 201);
            this.gbxSeriListe.TabIndex = 0;
            this.gbxSeriListe.TabStop = false;
            this.gbxSeriListe.Text = "Seri Listesi";
            // 
            // dgvSeriList
            // 
            this.dgvSeriList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeriList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeriList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeriList.Location = new System.Drawing.Point(3, 18);
            this.dgvSeriList.Name = "dgvSeriList";
            this.dgvSeriList.Size = new System.Drawing.Size(310, 180);
            this.dgvSeriList.TabIndex = 0;
            this.dgvSeriList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeriList_CellClick);
            // 
            // pnlSeriLeft
            // 
            this.pnlSeriLeft.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlSeriLeft.Controls.Add(this.gbxSeriIslem);
            this.pnlSeriLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSeriLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlSeriLeft.Name = "pnlSeriLeft";
            this.pnlSeriLeft.Size = new System.Drawing.Size(185, 201);
            this.pnlSeriLeft.TabIndex = 0;
            // 
            // gbxSeriIslem
            // 
            this.gbxSeriIslem.BackColor = System.Drawing.Color.Aqua;
            this.gbxSeriIslem.Controls.Add(this.btnSeriSil);
            this.gbxSeriIslem.Controls.Add(this.txtSeri);
            this.gbxSeriIslem.Controls.Add(this.cmbMarka);
            this.gbxSeriIslem.Controls.Add(this.lblSeri);
            this.gbxSeriIslem.Controls.Add(this.btnSeriVazgec);
            this.gbxSeriIslem.Controls.Add(this.btnSeriEkle);
            this.gbxSeriIslem.Controls.Add(this.lblSMarka);
            this.gbxSeriIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSeriIslem.Location = new System.Drawing.Point(0, 0);
            this.gbxSeriIslem.Name = "gbxSeriIslem";
            this.gbxSeriIslem.Size = new System.Drawing.Size(185, 201);
            this.gbxSeriIslem.TabIndex = 0;
            this.gbxSeriIslem.TabStop = false;
            this.gbxSeriIslem.Text = "Seri İşlemleri";
            // 
            // btnSeriSil
            // 
            this.btnSeriSil.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriSil.Location = new System.Drawing.Point(55, 151);
            this.btnSeriSil.Name = "btnSeriSil";
            this.btnSeriSil.Size = new System.Drawing.Size(124, 23);
            this.btnSeriSil.TabIndex = 6;
            this.btnSeriSil.Text = "Sil";
            this.btnSeriSil.UseVisualStyleBackColor = true;
            this.btnSeriSil.Visible = false;
            this.btnSeriSil.Click += new System.EventHandler(this.btnSeriSil_Click);
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(55, 64);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(124, 22);
            this.txtSeri.TabIndex = 3;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(55, 33);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(124, 22);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // lblSeri
            // 
            this.lblSeri.AutoSize = true;
            this.lblSeri.Location = new System.Drawing.Point(12, 71);
            this.lblSeri.Name = "lblSeri";
            this.lblSeri.Size = new System.Drawing.Size(27, 14);
            this.lblSeri.TabIndex = 2;
            this.lblSeri.Text = "Seri";
            // 
            // btnSeriVazgec
            // 
            this.btnSeriVazgec.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriVazgec.Location = new System.Drawing.Point(55, 122);
            this.btnSeriVazgec.Name = "btnSeriVazgec";
            this.btnSeriVazgec.Size = new System.Drawing.Size(124, 23);
            this.btnSeriVazgec.TabIndex = 5;
            this.btnSeriVazgec.Text = "Temizle\\Vazgeç";
            this.btnSeriVazgec.UseVisualStyleBackColor = true;
            this.btnSeriVazgec.Click += new System.EventHandler(this.btnSeriVazgec_Click);
            // 
            // btnSeriEkle
            // 
            this.btnSeriEkle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriEkle.Location = new System.Drawing.Point(55, 92);
            this.btnSeriEkle.Name = "btnSeriEkle";
            this.btnSeriEkle.Size = new System.Drawing.Size(124, 23);
            this.btnSeriEkle.TabIndex = 4;
            this.btnSeriEkle.Text = "Seri Ekle";
            this.btnSeriEkle.UseVisualStyleBackColor = true;
            this.btnSeriEkle.Click += new System.EventHandler(this.btnSeriEkle_Click);
            // 
            // lblSMarka
            // 
            this.lblSMarka.AutoSize = true;
            this.lblSMarka.Location = new System.Drawing.Point(9, 41);
            this.lblSMarka.Name = "lblSMarka";
            this.lblSMarka.Size = new System.Drawing.Size(40, 14);
            this.lblSMarka.TabIndex = 0;
            this.lblSMarka.Text = "Marka";
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.pnlModelBG);
            this.tabModel.Location = new System.Drawing.Point(4, 23);
            this.tabModel.Name = "tabModel";
            this.tabModel.Size = new System.Drawing.Size(501, 201);
            this.tabModel.TabIndex = 2;
            this.tabModel.Text = "Model İslemleri";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // pnlModelBG
            // 
            this.pnlModelBG.BackColor = System.Drawing.Color.Silver;
            this.pnlModelBG.Controls.Add(this.pnlModelRight);
            this.pnlModelBG.Controls.Add(this.pnlModelLeft);
            this.pnlModelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModelBG.Location = new System.Drawing.Point(0, 0);
            this.pnlModelBG.Name = "pnlModelBG";
            this.pnlModelBG.Size = new System.Drawing.Size(501, 201);
            this.pnlModelBG.TabIndex = 0;
            // 
            // pnlModelRight
            // 
            this.pnlModelRight.BackColor = System.Drawing.Color.LightGray;
            this.pnlModelRight.Controls.Add(this.gbxModelListe);
            this.pnlModelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModelRight.Location = new System.Drawing.Point(181, 0);
            this.pnlModelRight.Name = "pnlModelRight";
            this.pnlModelRight.Size = new System.Drawing.Size(320, 201);
            this.pnlModelRight.TabIndex = 1;
            // 
            // gbxModelListe
            // 
            this.gbxModelListe.BackColor = System.Drawing.Color.Silver;
            this.gbxModelListe.Controls.Add(this.dgvModelListe);
            this.gbxModelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxModelListe.Location = new System.Drawing.Point(0, 0);
            this.gbxModelListe.Name = "gbxModelListe";
            this.gbxModelListe.Size = new System.Drawing.Size(320, 201);
            this.gbxModelListe.TabIndex = 0;
            this.gbxModelListe.TabStop = false;
            this.gbxModelListe.Text = "Model Listesi";
            // 
            // dgvModelListe
            // 
            this.dgvModelListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelListe.Location = new System.Drawing.Point(3, 18);
            this.dgvModelListe.Name = "dgvModelListe";
            this.dgvModelListe.Size = new System.Drawing.Size(314, 180);
            this.dgvModelListe.TabIndex = 0;
            this.dgvModelListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelListe_CellClick);
            // 
            // pnlModelLeft
            // 
            this.pnlModelLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModelLeft.Controls.Add(this.gbxModelislem);
            this.pnlModelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlModelLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlModelLeft.Name = "pnlModelLeft";
            this.pnlModelLeft.Size = new System.Drawing.Size(181, 201);
            this.pnlModelLeft.TabIndex = 0;
            // 
            // gbxModelislem
            // 
            this.gbxModelislem.BackColor = System.Drawing.Color.Aqua;
            this.gbxModelislem.Controls.Add(this.btnModelSil);
            this.gbxModelislem.Controls.Add(this.txtModel);
            this.gbxModelislem.Controls.Add(this.cmbSeri);
            this.gbxModelislem.Controls.Add(this.lblModel);
            this.gbxModelislem.Controls.Add(this.btnModelTemizle);
            this.gbxModelislem.Controls.Add(this.btnModelEkle);
            this.gbxModelislem.Controls.Add(this.lblMSeri);
            this.gbxModelislem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxModelislem.Location = new System.Drawing.Point(0, 0);
            this.gbxModelislem.Name = "gbxModelislem";
            this.gbxModelislem.Size = new System.Drawing.Size(181, 201);
            this.gbxModelislem.TabIndex = 0;
            this.gbxModelislem.TabStop = false;
            this.gbxModelislem.Text = "Model İşlemleri";
            // 
            // btnModelSil
            // 
            this.btnModelSil.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelSil.Location = new System.Drawing.Point(51, 148);
            this.btnModelSil.Name = "btnModelSil";
            this.btnModelSil.Size = new System.Drawing.Size(124, 23);
            this.btnModelSil.TabIndex = 13;
            this.btnModelSil.Text = "Sil";
            this.btnModelSil.UseVisualStyleBackColor = true;
            this.btnModelSil.Visible = false;
            this.btnModelSil.Click += new System.EventHandler(this.btnModelSil_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(51, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(124, 22);
            this.txtModel.TabIndex = 10;
            // 
            // cmbSeri
            // 
            this.cmbSeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeri.FormattingEnabled = true;
            this.cmbSeri.Location = new System.Drawing.Point(51, 30);
            this.cmbSeri.Name = "cmbSeri";
            this.cmbSeri.Size = new System.Drawing.Size(124, 22);
            this.cmbSeri.TabIndex = 8;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(8, 68);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 14);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model";
            // 
            // btnModelTemizle
            // 
            this.btnModelTemizle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelTemizle.Location = new System.Drawing.Point(51, 119);
            this.btnModelTemizle.Name = "btnModelTemizle";
            this.btnModelTemizle.Size = new System.Drawing.Size(124, 23);
            this.btnModelTemizle.TabIndex = 12;
            this.btnModelTemizle.Text = "Temizle\\Vazgeç";
            this.btnModelTemizle.UseVisualStyleBackColor = true;
            this.btnModelTemizle.Click += new System.EventHandler(this.btnModelTemizle_Click);
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelEkle.Location = new System.Drawing.Point(51, 89);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(124, 23);
            this.btnModelEkle.TabIndex = 11;
            this.btnModelEkle.Text = "Model Ekle";
            this.btnModelEkle.UseVisualStyleBackColor = true;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // lblMSeri
            // 
            this.lblMSeri.AutoSize = true;
            this.lblMSeri.Location = new System.Drawing.Point(8, 38);
            this.lblMSeri.Name = "lblMSeri";
            this.lblMSeri.Size = new System.Drawing.Size(27, 14);
            this.lblMSeri.TabIndex = 7;
            this.lblMSeri.Text = "Seri";
            // 
            // lblMarkaAra
            // 
            this.lblMarkaAra.AutoSize = true;
            this.lblMarkaAra.Location = new System.Drawing.Point(9, 143);
            this.lblMarkaAra.Name = "lblMarkaAra";
            this.lblMarkaAra.Size = new System.Drawing.Size(28, 14);
            this.lblMarkaAra.TabIndex = 9;
            this.lblMarkaAra.Text = "Ara:";
            // 
            // txtMarkaAra
            // 
            this.txtMarkaAra.Location = new System.Drawing.Point(55, 136);
            this.txtMarkaAra.Name = "txtMarkaAra";
            this.txtMarkaAra.Size = new System.Drawing.Size(115, 22);
            this.txtMarkaAra.TabIndex = 10;
            // 
            // btnMarkaAra
            // 
            this.btnMarkaAra.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaAra.Location = new System.Drawing.Point(79, 165);
            this.btnMarkaAra.Name = "btnMarkaAra";
            this.btnMarkaAra.Size = new System.Drawing.Size(91, 23);
            this.btnMarkaAra.TabIndex = 11;
            this.btnMarkaAra.Text = "Marka Ara";
            this.btnMarkaAra.UseVisualStyleBackColor = true;
            this.btnMarkaAra.Click += new System.EventHandler(this.btnMarkaAra_Click);
            // 
            // MSMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(509, 228);
            this.Controls.Add(this.pnlArkaPlan);
            this.Name = "MSMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSMForm";
            this.Load += new System.EventHandler(this.MSMForm_Load);
            this.pnlArkaPlan.ResumeLayout(false);
            this.tabMSM.ResumeLayout(false);
            this.tabMarka.ResumeLayout(false);
            this.pnlMarkaListHolder.ResumeLayout(false);
            this.gbxMarkaList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaList)).EndInit();
            this.pnlMarkaHolder.ResumeLayout(false);
            this.gbxMarkaIslem.ResumeLayout(false);
            this.gbxMarkaIslem.PerformLayout();
            this.tabSeri.ResumeLayout(false);
            this.pnlSeriBG.ResumeLayout(false);
            this.pnlSeriRight.ResumeLayout(false);
            this.gbxSeriListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeriList)).EndInit();
            this.pnlSeriLeft.ResumeLayout(false);
            this.gbxSeriIslem.ResumeLayout(false);
            this.gbxSeriIslem.PerformLayout();
            this.tabModel.ResumeLayout(false);
            this.pnlModelBG.ResumeLayout(false);
            this.pnlModelRight.ResumeLayout(false);
            this.gbxModelListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelListe)).EndInit();
            this.pnlModelLeft.ResumeLayout(false);
            this.gbxModelislem.ResumeLayout(false);
            this.gbxModelislem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArkaPlan;
        private System.Windows.Forms.TabControl tabMSM;
        private System.Windows.Forms.TabPage tabMarka;
        private System.Windows.Forms.Panel pnlMarkaListHolder;
        private System.Windows.Forms.Panel pnlMarkaHolder;
        private System.Windows.Forms.GroupBox gbxMarkaIslem;
        private System.Windows.Forms.Button btnMarkaVazgec;
        private System.Windows.Forms.Button btnMarkaSil;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.GroupBox gbxMarkaList;
        private System.Windows.Forms.DataGridView dgvMarkaList;
        private System.Windows.Forms.TabPage tabSeri;
        private System.Windows.Forms.Panel pnlSeriBG;
        private System.Windows.Forms.Panel pnlSeriLeft;
        private System.Windows.Forms.Panel pnlSeriRight;
        private System.Windows.Forms.GroupBox gbxSeriListe;
        private System.Windows.Forms.GroupBox gbxSeriIslem;
        private System.Windows.Forms.Button btnSeriSil;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label lblSeri;
        private System.Windows.Forms.Button btnSeriVazgec;
        private System.Windows.Forms.Button btnSeriEkle;
        private System.Windows.Forms.Label lblSMarka;
        private System.Windows.Forms.DataGridView dgvSeriList;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.Panel pnlModelBG;
        private System.Windows.Forms.Panel pnlModelRight;
        private System.Windows.Forms.Panel pnlModelLeft;
        private System.Windows.Forms.GroupBox gbxModelislem;
        private System.Windows.Forms.GroupBox gbxModelListe;
        private System.Windows.Forms.DataGridView dgvModelListe;
        private System.Windows.Forms.Button btnModelSil;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbSeri;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnModelTemizle;
        private System.Windows.Forms.Button btnModelEkle;
        private System.Windows.Forms.Label lblMSeri;
        private System.Windows.Forms.Button btnMarkaAra;
        private System.Windows.Forms.TextBox txtMarkaAra;
        private System.Windows.Forms.Label lblMarkaAra;
    }
}