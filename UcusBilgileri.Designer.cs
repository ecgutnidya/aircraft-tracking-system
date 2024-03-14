namespace stajproje1
{
    partial class UcusBilgileri
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 239);
            this.dataGridView1.TabIndex = 0;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(830, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "veriEKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Planlanan Saat/Tahmini Saat";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hava Yolu";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ucus No";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(32, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Varış";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(32, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(419, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Check-in Kontuar";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(405, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(401, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kapı";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(405, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(211, 22);
            this.textBox7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(401, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Durumu";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(405, 145);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(211, 22);
            this.textBox8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(401, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tip";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(405, 193);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(211, 22);
            this.textBox9.TabIndex = 19;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // UcusBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 582);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcusBilgileri";
            this.Text = "UcusBilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UcusBilgileri_FormClosed);
            this.Load += new System.EventHandler(this.UcusBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}