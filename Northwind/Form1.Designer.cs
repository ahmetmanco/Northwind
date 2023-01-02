namespace Northwind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.dtIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBolge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitleOfCoursy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalisanId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnCalisanEkle);
            this.groupBox1.Controls.Add(this.dtIseBaslamaTarihi);
            this.groupBox1.Controls.Add(this.dtDogumTarihi);
            this.groupBox1.Controls.Add(this.txtUlke);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBolge);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSehir);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTitleOfCoursy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCalisanId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1807, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 855);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Ekle";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(419, 768);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 64);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Çalışan Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(225, 768);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(131, 64);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(33, 768);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(131, 64);
            this.btnCalisanEkle.TabIndex = 24;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // dtIseBaslamaTarihi
            // 
            this.dtIseBaslamaTarihi.Location = new System.Drawing.Point(246, 421);
            this.dtIseBaslamaTarihi.Name = "dtIseBaslamaTarihi";
            this.dtIseBaslamaTarihi.Size = new System.Drawing.Size(304, 35);
            this.dtIseBaslamaTarihi.TabIndex = 23;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(246, 346);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(304, 35);
            this.dtDogumTarihi.TabIndex = 22;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(246, 685);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(304, 35);
            this.txtUlke.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 688);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ülke :";
            // 
            // txtBolge
            // 
            this.txtBolge.Location = new System.Drawing.Point(246, 618);
            this.txtBolge.Name = "txtBolge";
            this.txtBolge.Size = new System.Drawing.Size(304, 35);
            this.txtBolge.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 621);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Bölge :";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(246, 554);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(304, 35);
            this.txtSehir.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Şehir :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(246, 482);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(304, 35);
            this.txtAdres.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "İşe Başlama Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // txtTitleOfCoursy
            // 
            this.txtTitleOfCoursy.Location = new System.Drawing.Point(246, 287);
            this.txtTitleOfCoursy.Name = "txtTitleOfCoursy";
            this.txtTitleOfCoursy.Size = new System.Drawing.Size(304, 35);
            this.txtTitleOfCoursy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Title Of Coursy :";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(246, 229);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(304, 35);
            this.txtTitle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title :";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(246, 170);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(304, 35);
            this.txtSoyadi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(246, 115);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(304, 35);
            this.txtAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı :";
            // 
            // txtCalisanId
            // 
            this.txtCalisanId.Location = new System.Drawing.Point(246, 57);
            this.txtCalisanId.Name = "txtCalisanId";
            this.txtCalisanId.ReadOnly = true;
            this.txtCalisanId.Size = new System.Drawing.Size(304, 35);
            this.txtCalisanId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1772, 851);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2375, 874);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCalisanId;
        private Label label1;
        private TextBox txtSehir;
        private Label label9;
        private TextBox txtAdres;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtTitleOfCoursy;
        private Label label5;
        private TextBox txtTitle;
        private Label label4;
        private TextBox txtSoyadi;
        private Label label3;
        private TextBox txtAdi;
        private Label label2;
        private TextBox txtUlke;
        private Label label11;
        private TextBox txtBolge;
        private Label label10;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnCalisanEkle;
        private DateTimePicker dtIseBaslamaTarihi;
        private DateTimePicker dtDogumTarihi;
        private DataGridView dataGridView1;
    }
}