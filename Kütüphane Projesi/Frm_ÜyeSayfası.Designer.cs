namespace Kütüphane_Projesi
{
    partial class Frm_ÜyeSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ÜyeSayfası));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapTürDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneVeriTabanıDataSet2 = new Kütüphane_Projesi.KütüphaneVeriTabanıDataSet2();
            this.tbl_KitaplarTableAdapter = new Kütüphane_Projesi.KütüphaneVeriTabanıDataSet2TableAdapters.Tbl_KitaplarTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneVeriTabanıDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 233);
            this.dataGridView1.TabIndex = 0;
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
            this.tblKitaplarBindingSource.DataSource = this.kütüphaneVeriTabanıDataSet2;
            // 
            // kütüphaneVeriTabanıDataSet2
            // 
            this.kütüphaneVeriTabanıDataSet2.DataSetName = "KütüphaneVeriTabanıDataSet2";
            this.kütüphaneVeriTabanıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KitaplarTableAdapter
            // 
            this.tbl_KitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(769, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİTAPLAR";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(15, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 43);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(71, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 43);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_ÜyeSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(802, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ÜyeSayfası";
            this.Text = "Frm_ÜyeSayfası";
            this.Load += new System.EventHandler(this.Frm_ÜyeSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneVeriTabanıDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneVeriTabanıDataSet2 kütüphaneVeriTabanıDataSet2;
        private System.Windows.Forms.BindingSource tblKitaplarBindingSource;
        private KütüphaneVeriTabanıDataSet2TableAdapters.Tbl_KitaplarTableAdapter tbl_KitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapTürDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}