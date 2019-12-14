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
            this.dgvAracDetay = new System.Windows.Forms.DataGridView();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAracDetay
            // 
            this.dgvAracDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAracDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAracDetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmDeger});
            this.dgvAracDetay.Location = new System.Drawing.Point(12, 12);
            this.dgvAracDetay.Name = "dgvAracDetay";
            this.dgvAracDetay.Size = new System.Drawing.Size(297, 303);
            this.dgvAracDetay.TabIndex = 0;
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "ad";
            this.clmAd.HeaderText = "Kategori";
            this.clmAd.Name = "clmAd";
            this.clmAd.ReadOnly = true;
            // 
            // clmDeger
            // 
            this.clmDeger.DataPropertyName = "deger";
            this.clmDeger.HeaderText = "Deger";
            this.clmDeger.Name = "clmDeger";
            this.clmDeger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDeger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AracDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 338);
            this.Controls.Add(this.dgvAracDetay);
            this.Name = "AracDetay";
            this.Text = "ArabaDetay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAracDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeger;
    }
}