namespace Kütüphane_Projesi
{
    partial class Frm_Üyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Üyeler));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.üyeİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üyeAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üyeSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üyeTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.üyeSıfreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblÜyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneVeriTabanıDataSet1 = new Kütüphane_Projesi.KütüphaneVeriTabanıDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_üyesifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_üyetc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_üyesoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_üyead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_üyeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_ÜyeTableAdapter = new Kütüphane_Projesi.KütüphaneVeriTabanıDataSet1TableAdapters.Tbl_ÜyeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneVeriTabanıDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(20, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Üyeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.üyeİdDataGridViewTextBoxColumn,
            this.üyeAdıDataGridViewTextBoxColumn,
            this.üyeSoyadıDataGridViewTextBoxColumn,
            this.üyeTcDataGridViewTextBoxColumn,
            this.üyeSıfreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblÜyeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // üyeİdDataGridViewTextBoxColumn
            // 
            this.üyeİdDataGridViewTextBoxColumn.DataPropertyName = "Üyeİd";
            this.üyeİdDataGridViewTextBoxColumn.HeaderText = "Üyeİd";
            this.üyeİdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üyeİdDataGridViewTextBoxColumn.Name = "üyeİdDataGridViewTextBoxColumn";
            this.üyeİdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // üyeAdıDataGridViewTextBoxColumn
            // 
            this.üyeAdıDataGridViewTextBoxColumn.DataPropertyName = "ÜyeAdı";
            this.üyeAdıDataGridViewTextBoxColumn.HeaderText = "ÜyeAdı";
            this.üyeAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üyeAdıDataGridViewTextBoxColumn.Name = "üyeAdıDataGridViewTextBoxColumn";
            // 
            // üyeSoyadıDataGridViewTextBoxColumn
            // 
            this.üyeSoyadıDataGridViewTextBoxColumn.DataPropertyName = "ÜyeSoyadı";
            this.üyeSoyadıDataGridViewTextBoxColumn.HeaderText = "ÜyeSoyadı";
            this.üyeSoyadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üyeSoyadıDataGridViewTextBoxColumn.Name = "üyeSoyadıDataGridViewTextBoxColumn";
            // 
            // üyeTcDataGridViewTextBoxColumn
            // 
            this.üyeTcDataGridViewTextBoxColumn.DataPropertyName = "ÜyeTc";
            this.üyeTcDataGridViewTextBoxColumn.HeaderText = "ÜyeTc";
            this.üyeTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üyeTcDataGridViewTextBoxColumn.Name = "üyeTcDataGridViewTextBoxColumn";
            // 
            // üyeSıfreDataGridViewTextBoxColumn
            // 
            this.üyeSıfreDataGridViewTextBoxColumn.DataPropertyName = "ÜyeSıfre";
            this.üyeSıfreDataGridViewTextBoxColumn.HeaderText = "ÜyeSıfre";
            this.üyeSıfreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üyeSıfreDataGridViewTextBoxColumn.Name = "üyeSıfreDataGridViewTextBoxColumn";
            // 
            // tblÜyeBindingSource
            // 
            this.tblÜyeBindingSource.DataMember = "Tbl_Üye";
            this.tblÜyeBindingSource.DataSource = this.kütüphaneVeriTabanıDataSet1;
            // 
            // kütüphaneVeriTabanıDataSet1
            // 
            this.kütüphaneVeriTabanıDataSet1.DataSetName = "KütüphaneVeriTabanıDataSet1";
            this.kütüphaneVeriTabanıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_güncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.btn_listele);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(409, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(26, 178);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(165, 41);
            this.btn_güncelle.TabIndex = 3;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(26, 131);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(165, 41);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(26, 84);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_üyesifre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_üyetc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_üyesoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_üyead);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_üyeid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(348, 298);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // txt_üyesifre
            // 
            this.txt_üyesifre.Location = new System.Drawing.Point(175, 206);
            this.txt_üyesifre.Name = "txt_üyesifre";
            this.txt_üyesifre.Size = new System.Drawing.Size(166, 38);
            this.txt_üyesifre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Üye Şifre :";
            // 
            // txt_üyetc
            // 
            this.txt_üyetc.Location = new System.Drawing.Point(175, 164);
            this.txt_üyetc.Name = "txt_üyetc";
            this.txt_üyetc.Size = new System.Drawing.Size(166, 38);
            this.txt_üyetc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Üye TC :";
            // 
            // txt_üyesoyad
            // 
            this.txt_üyesoyad.Location = new System.Drawing.Point(175, 122);
            this.txt_üyesoyad.Name = "txt_üyesoyad";
            this.txt_üyesoyad.Size = new System.Drawing.Size(166, 38);
            this.txt_üyesoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Üye Soyadı :";
            // 
            // txt_üyead
            // 
            this.txt_üyead.Location = new System.Drawing.Point(175, 80);
            this.txt_üyead.Name = "txt_üyead";
            this.txt_üyead.Size = new System.Drawing.Size(166, 38);
            this.txt_üyead.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üye Adı :";
            // 
            // txt_üyeid
            // 
            this.txt_üyeid.Enabled = false;
            this.txt_üyeid.Location = new System.Drawing.Point(175, 38);
            this.txt_üyeid.Name = "txt_üyeid";
            this.txt_üyeid.Size = new System.Drawing.Size(166, 38);
            this.txt_üyeid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye İd :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_ÜyeTableAdapter
            // 
            this.tbl_ÜyeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Üyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1017, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Üyeler";
            this.Text = "Frm_Üyeler";
            this.Load += new System.EventHandler(this.Frm_Üyeler_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneVeriTabanıDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_üyesifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_üyetc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_üyesoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_üyead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_üyeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KütüphaneVeriTabanıDataSet1 kütüphaneVeriTabanıDataSet1;
        private System.Windows.Forms.BindingSource tblÜyeBindingSource;
        private KütüphaneVeriTabanıDataSet1TableAdapters.Tbl_ÜyeTableAdapter tbl_ÜyeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeSıfreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}