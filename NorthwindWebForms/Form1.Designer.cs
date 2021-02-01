namespace NorthwindWebForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kategoritxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunaditxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ürüntxt = new System.Windows.Forms.TextBox();
            this.birimtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fiyattxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stoktxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ktgraddcb = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.ktggnc = new System.Windows.Forms.ComboBox();
            this.stokgnc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fiyatgnc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.birimgnc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.urunad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.silbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kategoritxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Göre Arama";
            // 
            // kategoritxt
            // 
            this.kategoritxt.FormattingEnabled = true;
            this.kategoritxt.Location = new System.Drawing.Point(81, 33);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.Size = new System.Drawing.Size(198, 21);
            this.kategoritxt.TabIndex = 1;
            this.kategoritxt.SelectedIndexChanged += new System.EventHandler(this.kategoritxt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urunaditxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Adına Göre Arama";
            // 
            // urunaditxt
            // 
            this.urunaditxt.Location = new System.Drawing.Point(81, 32);
            this.urunaditxt.Name = "urunaditxt";
            this.urunaditxt.Size = new System.Drawing.Size(198, 20);
            this.urunaditxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Controls.Add(this.ktgraddcb);
            this.groupBox3.Controls.Add(this.stoktxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.fiyattxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.birimtxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ürüntxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(25, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 173);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Ürün Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı: ";
            // 
            // ürüntxt
            // 
            this.ürüntxt.Location = new System.Drawing.Point(90, 31);
            this.ürüntxt.Name = "ürüntxt";
            this.ürüntxt.Size = new System.Drawing.Size(161, 20);
            this.ürüntxt.TabIndex = 1;
            // 
            // birimtxt
            // 
            this.birimtxt.Location = new System.Drawing.Point(363, 69);
            this.birimtxt.Name = "birimtxt";
            this.birimtxt.Size = new System.Drawing.Size(161, 20);
            this.birimtxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birim Adedi";
            // 
            // fiyattxt
            // 
            this.fiyattxt.Location = new System.Drawing.Point(90, 126);
            this.fiyattxt.Name = "fiyattxt";
            this.fiyattxt.Size = new System.Drawing.Size(161, 20);
            this.fiyattxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kategori: ";
            // 
            // stoktxt
            // 
            this.stoktxt.Location = new System.Drawing.Point(363, 31);
            this.stoktxt.Name = "stoktxt";
            this.stoktxt.Size = new System.Drawing.Size(161, 20);
            this.stoktxt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stok Adedi: ";
            // 
            // ktgraddcb
            // 
            this.ktgraddcb.FormattingEnabled = true;
            this.ktgraddcb.Location = new System.Drawing.Point(90, 76);
            this.ktgraddcb.Name = "ktgraddcb";
            this.ktgraddcb.Size = new System.Drawing.Size(161, 21);
            this.ktgraddcb.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(314, 111);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(196, 34);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Ekle";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.guncellebtn);
            this.groupBox4.Controls.Add(this.ktggnc);
            this.groupBox4.Controls.Add(this.stokgnc);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.fiyatgnc);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.birimgnc);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.urunad);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(27, 531);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 173);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Günceelle";
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(314, 111);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(196, 34);
            this.guncellebtn.TabIndex = 10;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // ktggnc
            // 
            this.ktggnc.FormattingEnabled = true;
            this.ktggnc.Location = new System.Drawing.Point(90, 76);
            this.ktggnc.Name = "ktggnc";
            this.ktggnc.Size = new System.Drawing.Size(161, 21);
            this.ktggnc.TabIndex = 4;
            // 
            // stokgnc
            // 
            this.stokgnc.Location = new System.Drawing.Point(363, 31);
            this.stokgnc.Name = "stokgnc";
            this.stokgnc.Size = new System.Drawing.Size(161, 20);
            this.stokgnc.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stok Adedi: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Kategori: ";
            // 
            // fiyatgnc
            // 
            this.fiyatgnc.Location = new System.Drawing.Point(90, 126);
            this.fiyatgnc.Name = "fiyatgnc";
            this.fiyatgnc.Size = new System.Drawing.Size(161, 20);
            this.fiyatgnc.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fiyat:";
            // 
            // birimgnc
            // 
            this.birimgnc.Location = new System.Drawing.Point(363, 69);
            this.birimgnc.Name = "birimgnc";
            this.birimgnc.Size = new System.Drawing.Size(161, 20);
            this.birimgnc.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Birim Adedi";
            // 
            // urunad
            // 
            this.urunad.Location = new System.Drawing.Point(90, 31);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(161, 20);
            this.urunad.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ürün Adı: ";
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(596, 351);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(176, 30);
            this.silbtn.TabIndex = 5;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 716);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox kategoritxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urunaditxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox ktgraddcb;
        private System.Windows.Forms.TextBox stoktxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fiyattxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birimtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ürüntxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.ComboBox ktggnc;
        private System.Windows.Forms.TextBox stokgnc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fiyatgnc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox birimgnc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox urunad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button silbtn;
    }
}

