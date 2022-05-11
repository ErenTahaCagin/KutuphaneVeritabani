namespace KutuphaneVeritabani
{
    partial class Form1
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
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKTurGetir = new System.Windows.Forms.Button();
            this.btnIlkKGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cbKitapTuru = new System.Windows.Forms.ComboBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTumKitap = new System.Windows.Forms.Button();
            this.colKAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTur = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colRaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(12, 12);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(75, 23);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKTurGetir
            // 
            this.btnKTurGetir.Location = new System.Drawing.Point(93, 12);
            this.btnKTurGetir.Name = "btnKTurGetir";
            this.btnKTurGetir.Size = new System.Drawing.Size(118, 23);
            this.btnKTurGetir.TabIndex = 1;
            this.btnKTurGetir.Text = "Kitap Türlerini Getir";
            this.btnKTurGetir.UseVisualStyleBackColor = true;
            this.btnKTurGetir.Click += new System.EventHandler(this.btnKTurGetir_Click);
            // 
            // btnIlkKGetir
            // 
            this.btnIlkKGetir.Location = new System.Drawing.Point(217, 12);
            this.btnIlkKGetir.Name = "btnIlkKGetir";
            this.btnIlkKGetir.Size = new System.Drawing.Size(93, 23);
            this.btnIlkKGetir.TabIndex = 2;
            this.btnIlkKGetir.Text = "İlk Kayıtı Getir";
            this.btnIlkKGetir.UseVisualStyleBackColor = true;
            this.btnIlkKGetir.Click += new System.EventHandler(this.btnIlkKGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(70, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(176, 41);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(50, 20);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Turu:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(70, 65);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(156, 20);
            this.txtKitapAdi.TabIndex = 8;
            // 
            // cbKitapTuru
            // 
            this.cbKitapTuru.DisplayMember = "KitapTuru";
            this.cbKitapTuru.FormattingEnabled = true;
            this.cbKitapTuru.Location = new System.Drawing.Point(70, 97);
            this.cbKitapTuru.Name = "cbKitapTuru";
            this.cbKitapTuru.Size = new System.Drawing.Size(156, 21);
            this.cbKitapTuru.TabIndex = 9;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(70, 124);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(156, 20);
            this.txtYazar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Yazar:";
            // 
            // txtSSayisi
            // 
            this.txtSSayisi.Location = new System.Drawing.Point(70, 150);
            this.txtSSayisi.Name = "txtSSayisi";
            this.txtSSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSSayisi.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(70, 176);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(100, 20);
            this.txtBasimYili.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Basım Yılı:";
            // 
            // txtRaf
            // 
            this.txtRaf.Location = new System.Drawing.Point(70, 202);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(100, 20);
            this.txtRaf.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Raf No:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(70, 228);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adet:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKAdi,
            this.colYazar,
            this.ColTur,
            this.colRaf});
            this.dataGridView1.Location = new System.Drawing.Point(232, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 207);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // btnTumKitap
            // 
            this.btnTumKitap.Location = new System.Drawing.Point(602, 12);
            this.btnTumKitap.Name = "btnTumKitap";
            this.btnTumKitap.Size = new System.Drawing.Size(75, 23);
            this.btnTumKitap.TabIndex = 21;
            this.btnTumKitap.Text = "Tüm Kitaplar";
            this.btnTumKitap.UseVisualStyleBackColor = true;
            this.btnTumKitap.Click += new System.EventHandler(this.btnTumKitap_Click);
            // 
            // colKAdi
            // 
            this.colKAdi.DataPropertyName = "KitapAdi";
            this.colKAdi.HeaderText = "Kitap Adı";
            this.colKAdi.Name = "colKAdi";
            // 
            // colYazar
            // 
            this.colYazar.DataPropertyName = "Yazar";
            this.colYazar.HeaderText = "Yazar";
            this.colYazar.Name = "colYazar";
            // 
            // ColTur
            // 
            this.ColTur.DataPropertyName = "Turu";
            this.ColTur.HeaderText = "Kitap Türü";
            this.ColTur.Name = "ColTur";
            // 
            // colRaf
            // 
            this.colRaf.DataPropertyName = "RafNo";
            this.colRaf.HeaderText = "Raf No";
            this.colRaf.Name = "colRaf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 259);
            this.Controls.Add(this.btnTumKitap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKitapTuru);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIlkKGetir);
            this.Controls.Add(this.btnKTurGetir);
            this.Controls.Add(this.btnBaglan);
            this.Name = "Form1";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnKTurGetir;
        private System.Windows.Forms.Button btnIlkKGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cbKitapTuru;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTumKitap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYazar;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaf;
    }
}

