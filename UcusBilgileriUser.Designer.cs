namespace stajproje1
{
    partial class UcusBilgileriUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HYolu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UcusNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CinKontuar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.pst,
            this.HYolu,
            this.UcusNo,
            this.Varis,
            this.CinKontuar,
            this.Kapi,
            this.Durumu,
            this.Tip});
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 428);
            this.dataGridView1.TabIndex = 1;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 125;
            // 
            // pst
            // 
            this.pst.HeaderText = "Planlanan Saat / Tahmini Saat";
            this.pst.MinimumWidth = 6;
            this.pst.Name = "pst";
            this.pst.Width = 125;
            // 
            // HYolu
            // 
            this.HYolu.HeaderText = "Hava Yolu";
            this.HYolu.MinimumWidth = 6;
            this.HYolu.Name = "HYolu";
            this.HYolu.Width = 125;
            // 
            // UcusNo
            // 
            this.UcusNo.HeaderText = "Uçuş No";
            this.UcusNo.MinimumWidth = 6;
            this.UcusNo.Name = "UcusNo";
            this.UcusNo.Width = 125;
            // 
            // Varis
            // 
            this.Varis.HeaderText = "Varış";
            this.Varis.MinimumWidth = 6;
            this.Varis.Name = "Varis";
            this.Varis.Width = 125;
            // 
            // CinKontuar
            // 
            this.CinKontuar.HeaderText = "Check-in Kontuar";
            this.CinKontuar.MinimumWidth = 6;
            this.CinKontuar.Name = "CinKontuar";
            this.CinKontuar.Width = 125;
            // 
            // Kapi
            // 
            this.Kapi.HeaderText = "Kapı";
            this.Kapi.MinimumWidth = 6;
            this.Kapi.Name = "Kapi";
            this.Kapi.Width = 125;
            // 
            // Durumu
            // 
            this.Durumu.HeaderText = "Durumu";
            this.Durumu.MinimumWidth = 6;
            this.Durumu.Name = "Durumu";
            this.Durumu.Width = 125;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.MinimumWidth = 6;
            this.Tip.Name = "Tip";
            this.Tip.Width = 125;
            // 
            // UcusBilgileriUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 463);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcusBilgileriUser";
            this.Text = "UcusBilgileriUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn pst;
        private System.Windows.Forms.DataGridViewTextBoxColumn HYolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcusNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinKontuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
    }
}