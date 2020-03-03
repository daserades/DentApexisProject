namespace DentApexis.WinUI.Forms
{
    partial class DoktorTedavi
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
            this.lblDok = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOdenme = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.lblMenuBaslık2 = new System.Windows.Forms.Label();
            this.lblMenuBaslık = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDok
            // 
            this.lblDok.Location = new System.Drawing.Point(183, 197);
            this.lblDok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDok.Name = "lblDok";
            this.lblDok.Size = new System.Drawing.Size(104, 17);
            this.lblDok.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(41, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Hoşgeldiniz";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(985, 390);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 260);
            this.listBox1.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(1212, 390);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(156, 260);
            this.listBox2.TabIndex = 16;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1138, 431);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(56, 57);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "-->";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(1138, 518);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(56, 57);
            this.btnCikar.TabIndex = 17;
            this.btnCikar.Text = "<--";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1411, 390);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(341, 115);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(1212, 697);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 17);
            this.lbltotal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1048, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ödenecek Tutar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1411, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Onay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Doktor Mesaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hasta Adı:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(540, 217);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(0, 17);
            this.lblHastaAd.TabIndex = 20;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(526, 88);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(419, 116);
            this.listBox3.TabIndex = 23;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1005, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ödendin mi=";
            // 
            // lblOdenme
            // 
            this.lblOdenme.AutoSize = true;
            this.lblOdenme.Location = new System.Drawing.Point(1099, 105);
            this.lblOdenme.Name = "lblOdenme";
            this.lblOdenme.Size = new System.Drawing.Size(73, 17);
            this.lblOdenme.TabIndex = 24;
            this.lblOdenme.Text = "Ödenmedi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 496);
            this.dataGridView1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDok);
            this.panel1.Controls.Add(this.btnDoktor);
            this.panel1.Controls.Add(this.lblMenuBaslık2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblMenuBaslık);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 1041);
            this.panel1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(174, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hoşgeldiniz";
            // 
            // btnDoktor
            // 
            this.btnDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoktor.Location = new System.Drawing.Point(13, 429);
            this.btnDoktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(376, 57);
            this.btnDoktor.TabIndex = 7;
            this.btnDoktor.Text = "DOKTOR TEDAVI PLANLAMA";
            this.btnDoktor.UseVisualStyleBackColor = true;
            // 
            // lblMenuBaslık2
            // 
            this.lblMenuBaslık2.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuBaslık2.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuBaslık2.Location = new System.Drawing.Point(33, 98);
            this.lblMenuBaslık2.Name = "lblMenuBaslık2";
            this.lblMenuBaslık2.Size = new System.Drawing.Size(315, 44);
            this.lblMenuBaslık2.TabIndex = 6;
            this.lblMenuBaslık2.Text = "Herkes aynı dilde gülümser";
            this.lblMenuBaslık2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenuBaslık
            // 
            this.lblMenuBaslık.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuBaslık.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuBaslık.Location = new System.Drawing.Point(33, 31);
            this.lblMenuBaslık.Name = "lblMenuBaslık";
            this.lblMenuBaslık.Size = new System.Drawing.Size(315, 66);
            this.lblMenuBaslık.TabIndex = 5;
            this.lblMenuBaslık.Text = "DENT APEXIS";
            this.lblMenuBaslık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoktorTedavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblOdenme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHastaAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "DoktorTedavi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DoktorTedavi";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoktorTedavi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Label lblDok;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOdenme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Label lblMenuBaslık2;
        private System.Windows.Forms.Label lblMenuBaslık;
    }
}