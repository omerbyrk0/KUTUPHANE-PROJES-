namespace Kütüphane_Projesi
{
    partial class Frm_Üyekayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_uyead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uyesoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uyesıfre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Adı :";
            // 
            // txt_uyead
            // 
            this.txt_uyead.Location = new System.Drawing.Point(148, 69);
            this.txt_uyead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_uyead.Name = "txt_uyead";
            this.txt_uyead.Size = new System.Drawing.Size(136, 28);
            this.txt_uyead.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Üye Soyadı :";
            // 
            // txt_uyesoyad
            // 
            this.txt_uyesoyad.Location = new System.Drawing.Point(148, 119);
            this.txt_uyesoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uyesoyad.Name = "txt_uyesoyad";
            this.txt_uyesoyad.Size = new System.Drawing.Size(136, 28);
            this.txt_uyesoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Üye TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Üye Şifre :";
            // 
            // txt_uyesıfre
            // 
            this.txt_uyesıfre.Location = new System.Drawing.Point(148, 219);
            this.txt_uyesıfre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uyesıfre.Name = "txt_uyesıfre";
            this.txt_uyesıfre.Size = new System.Drawing.Size(136, 28);
            this.txt_uyesıfre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(148, 173);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(136, 28);
            this.msktc.TabIndex = 2;
            this.msktc.ValidatingType = typeof(int);
            // 
            // Frm_Üyekayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(316, 393);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_uyesıfre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_uyesoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_uyead);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Üyekayıt";
            this.Text = "Frm_Üyekayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_uyead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_uyesoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uyesıfre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msktc;
    }
}