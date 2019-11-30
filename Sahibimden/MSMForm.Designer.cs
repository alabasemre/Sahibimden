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
            this.pnlMarkaHolder = new System.Windows.Forms.Panel();
            this.gbxMarkaIslem = new System.Windows.Forms.GroupBox();
            this.btnMarkaVazgec = new System.Windows.Forms.Button();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.gbxMarkaList = new System.Windows.Forms.GroupBox();
            this.dgvMarkaList = new System.Windows.Forms.DataGridView();
            this.tabSeri = new System.Windows.Forms.TabPage();
            this.pnlArkaPlan.SuspendLayout();
            this.tabMSM.SuspendLayout();
            this.tabMarka.SuspendLayout();
            this.pnlMarkaListHolder.SuspendLayout();
            this.pnlMarkaHolder.SuspendLayout();
            this.gbxMarkaIslem.SuspendLayout();
            this.gbxMarkaList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArkaPlan
            // 
            this.pnlArkaPlan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlArkaPlan.Controls.Add(this.tabMSM);
            this.pnlArkaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlArkaPlan.Name = "pnlArkaPlan";
            this.pnlArkaPlan.Size = new System.Drawing.Size(517, 199);
            this.pnlArkaPlan.TabIndex = 0;
            // 
            // tabMSM
            // 
            this.tabMSM.Controls.Add(this.tabMarka);
            this.tabMSM.Controls.Add(this.tabSeri);
            this.tabMSM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMSM.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMSM.Location = new System.Drawing.Point(0, 0);
            this.tabMSM.Name = "tabMSM";
            this.tabMSM.SelectedIndex = 0;
            this.tabMSM.Size = new System.Drawing.Size(517, 199);
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
            this.tabMarka.Size = new System.Drawing.Size(509, 172);
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
            this.pnlMarkaListHolder.Size = new System.Drawing.Size(325, 166);
            this.pnlMarkaListHolder.TabIndex = 1;
            // 
            // pnlMarkaHolder
            // 
            this.pnlMarkaHolder.BackColor = System.Drawing.Color.Aqua;
            this.pnlMarkaHolder.Controls.Add(this.gbxMarkaIslem);
            this.pnlMarkaHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarkaHolder.Location = new System.Drawing.Point(3, 3);
            this.pnlMarkaHolder.Name = "pnlMarkaHolder";
            this.pnlMarkaHolder.Size = new System.Drawing.Size(178, 166);
            this.pnlMarkaHolder.TabIndex = 0;
            // 
            // gbxMarkaIslem
            // 
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaVazgec);
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaSil);
            this.gbxMarkaIslem.Controls.Add(this.btnMarkaEkle);
            this.gbxMarkaIslem.Controls.Add(this.lblMarka);
            this.gbxMarkaIslem.Controls.Add(this.txtMarka);
            this.gbxMarkaIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMarkaIslem.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMarkaIslem.Location = new System.Drawing.Point(0, 0);
            this.gbxMarkaIslem.Name = "gbxMarkaIslem";
            this.gbxMarkaIslem.Size = new System.Drawing.Size(178, 166);
            this.gbxMarkaIslem.TabIndex = 0;
            this.gbxMarkaIslem.TabStop = false;
            this.gbxMarkaIslem.Text = "Marka İslemleri";
            // 
            // btnMarkaVazgec
            // 
            this.btnMarkaVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkaVazgec.Location = new System.Drawing.Point(53, 82);
            this.btnMarkaVazgec.Name = "btnMarkaVazgec";
            this.btnMarkaVazgec.Size = new System.Drawing.Size(115, 23);
            this.btnMarkaVazgec.TabIndex = 8;
            this.btnMarkaVazgec.Text = "Temizle\\Vazgeç";
            this.btnMarkaVazgec.UseVisualStyleBackColor = true;
            this.btnMarkaVazgec.Click += new System.EventHandler(this.btnMarkaVazgec_Click);
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkaSil.Location = new System.Drawing.Point(53, 111);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(115, 23);
            this.btnMarkaSil.TabIndex = 7;
            this.btnMarkaSil.Text = "Sil";
            this.btnMarkaSil.UseVisualStyleBackColor = true;
            this.btnMarkaSil.Visible = false;
            this.btnMarkaSil.Click += new System.EventHandler(this.btnMarkaSil_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(53, 53);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(115, 23);
            this.btnMarkaEkle.TabIndex = 6;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.BackColor = System.Drawing.Color.Transparent;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarka.Location = new System.Drawing.Point(4, 30);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(43, 14);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(53, 27);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(115, 21);
            this.txtMarka.TabIndex = 4;
            // 
            // gbxMarkaList
            // 
            this.gbxMarkaList.Controls.Add(this.dgvMarkaList);
            this.gbxMarkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMarkaList.Location = new System.Drawing.Point(0, 0);
            this.gbxMarkaList.Name = "gbxMarkaList";
            this.gbxMarkaList.Size = new System.Drawing.Size(325, 166);
            this.gbxMarkaList.TabIndex = 0;
            this.gbxMarkaList.TabStop = false;
            this.gbxMarkaList.Text = "Marka Listesi";
            // 
            // dgvMarkaList
            // 
            this.dgvMarkaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarkaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarkaList.Location = new System.Drawing.Point(3, 17);
            this.dgvMarkaList.Name = "dgvMarkaList";
            this.dgvMarkaList.Size = new System.Drawing.Size(319, 146);
            this.dgvMarkaList.TabIndex = 0;
            this.dgvMarkaList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkaList_CellClick);
            // 
            // tabSeri
            // 
            this.tabSeri.Location = new System.Drawing.Point(4, 23);
            this.tabSeri.Name = "tabSeri";
            this.tabSeri.Size = new System.Drawing.Size(509, 172);
            this.tabSeri.TabIndex = 1;
            this.tabSeri.Text = "Seri İslemleri";
            this.tabSeri.UseVisualStyleBackColor = true;
            // 
            // MSMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 199);
            this.Controls.Add(this.pnlArkaPlan);
            this.Name = "MSMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSMForm";
            this.Load += new System.EventHandler(this.MSMForm_Load);
            this.pnlArkaPlan.ResumeLayout(false);
            this.tabMSM.ResumeLayout(false);
            this.tabMarka.ResumeLayout(false);
            this.pnlMarkaListHolder.ResumeLayout(false);
            this.pnlMarkaHolder.ResumeLayout(false);
            this.gbxMarkaIslem.ResumeLayout(false);
            this.gbxMarkaIslem.PerformLayout();
            this.gbxMarkaList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaList)).EndInit();
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
    }
}