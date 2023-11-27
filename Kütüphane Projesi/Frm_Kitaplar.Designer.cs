namespace Kütüphane_Projesi
{
    partial class Frm_Kitap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Kitap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tür = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapsayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitapyazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTürDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneVeriTabanıDataSet = new Kütüphane_Projesi.KütüphaneVeriTabanıDataSet();
            this.tbl_KitaplarTableAdapter = new Kütüphane_Projesi.KütüphaneVeriTabanıDataSetTableAdapters.Tbl_KitaplarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneVeriTabanıDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tür);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kitapsayfa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_kitapyazar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kitapadı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kitapid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(348, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // txt_tür
            // 
            this.txt_tür.Location = new System.Drawing.Point(175, 206);
            this.txt_tür.Name = "txt_tür";
            this.txt_tür.Size = new System.Drawing.Size(135, 36);
            this.txt_tür.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tür :";
            // 
            // txt_kitapsayfa
            // 
            this.txt_kitapsayfa.Location = new System.Drawing.Point(175, 164);
            this.txt_kitapsayfa.Name = "txt_kitapsayfa";
            this.txt_kitapsayfa.Size = new System.Drawing.Size(135, 36);
            this.txt_kitapsayfa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // txt_kitapyazar
            // 
            this.txt_kitapyazar.Location = new System.Drawing.Point(175, 122);
            this.txt_kitapyazar.Name = "txt_kitapyazar";
            this.txt_kitapyazar.Size = new System.Drawing.Size(135, 36);
            this.txt_kitapyazar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Yazarı :";
            // 
            // txt_kitapadı
            // 
            this.txt_kitapadı.Location = new System.Drawing.Point(175, 80);
            this.txt_kitapadı.Name = "txt_kitapadı";
            this.txt_kitapadı.Size = new System.Drawing.Size(135, 36);
            this.txt_kitapadı.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı :";
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Enabled = false;
            this.txt_kitapid.Location = new System.Drawing.Point(175, 38);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(135, 36);
            this.txt_kitapid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap İd :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_güncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.btn_listele);
            this.groupBox2.Location = new System.Drawing.Point(409, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(26, 180);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(165, 41);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(26, 133);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(165, 41);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(26, 86);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(165, 41);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(26, 39);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(165, 41);
            this.btn_listele.TabIndex = 0;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(20, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 266);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitaplar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapİdDataGridViewTextBoxColumn,
            this.kitapİsmiDataGridViewTextBoxColumn,
            this.kitapYazarDataGridViewTextBoxColumn,
            this.kitapSayfaDataGridViewTextBoxColumn,
            this.kitapTürDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKitaplarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kitapİdDataGridViewTextBoxColumn
            // 
            this.kitapİdDataGridViewTextBoxColumn.DataPropertyName = "Kitapİd";
            this.kitapİdDataGridViewTextBoxColumn.HeaderText = "Kitapİd";
            this.kitapİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapİdDataGridViewTextBoxColumn.Name = "kitapİdDataGridViewTextBoxColumn";
            this.kitapİdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapİsmiDataGridViewTextBoxColumn
            // 
            this.kitapİsmiDataGridViewTextBoxColumn.DataPropertyName = "Kitapİsmi";
            this.kitapİsmiDataGridViewTextBoxColumn.HeaderText = "Kitapİsmi";
            this.kitapİsmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapİsmiDataGridViewTextBoxColumn.Name = "kitapİsmiDataGridViewTextBoxColumn";
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            // 
            // kitapSayfaDataGridViewTextBoxColumn
            // 
            this.kitapSayfaDataGridViewTextBoxColumn.DataPropertyName = "KitapSayfa";
            this.kitapSayfaDataGridViewTextBoxColumn.HeaderText = "KitapSayfa";
            this.kitapSayfaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapSayfaDataGridViewTextBoxColumn.Name = "kitapSayfaDataGridViewTextBoxColumn";
            // 
            // kitapTürDataGridViewTextBoxColumn
            // 
            this.kitapTürDataGridViewTextBoxColumn.DataPropertyName = "KitapTür";
            this.kitapTürDataGridViewTextBoxColumn.HeaderText = "KitapTür";
            this.kitapTürDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapTürDataGridViewTextBoxColumn.Name = "kitapTürDataGridViewTextBoxColumn";
            // 
            // tblKitaplarBindingSource
            // 
            this.tblKitaplarBindingSource.DataMember = "Tbl_Kitaplar";
            this.tblKitaplarBindingSource.DataSource = this.kütüphaneVeriTabanıDataSet;
            // 
            // kütüphaneVeriTabanıDataSet
            // 
            this.kütüphaneVeriTabanıDataSet.DataSetName = "KütüphaneVeriTabanıDataSet";
            this.kütüphaneVeriTabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KitaplarTableAdapter
            // 
            this.tbl_KitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1026, 622);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Kitap";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneVeriTabanıDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tür;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapsayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kitapyazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneVeriTabanıDataSet kütüphaneVeriTabanıDataSet;
        private System.Windows.Forms.BindingSource tblKitaplarBindingSource;
        private KütüphaneVeriTabanıDataSetTableAdapters.Tbl_KitaplarTableAdapter tbl_KitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTürDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

