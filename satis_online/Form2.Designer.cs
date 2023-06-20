namespace satis_online
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._SATIŞ_MERKEZ_ONLİNE_DataSet2 = new satis_online._SATIŞ_MERKEZ_ONLİNE_DataSet2();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.urunlerTableAdapter = new satis_online._SATIŞ_MERKEZ_ONLİNE_DataSet2TableAdapters.urunlerTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SATIŞ_MERKEZ_ONLİNE_DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 44);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "m_isim ile arama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Arama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 239);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "id ile arama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "sipariş ID ile arama";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(357, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "siparisler Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "urun alan kişiler_GÖSTER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 43);
            this.button5.TabIndex = 10;
            this.button5.Text = "indirimli ekleme ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "başla tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "başla tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(141, 181);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1029, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 357);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "indirim ekle";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.urunlerBindingSource;
            this.comboBox1.DisplayMember = "urun_id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "urun_id";
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this._SATIŞ_MERKEZ_ONLİNE_DataSet2;
            // 
            // _SATIŞ_MERKEZ_ONLİNE_DataSet2
            // 
            this._SATIŞ_MERKEZ_ONLİNE_DataSet2.DataSetName = "_SATIŞ_MERKEZ_ONLİNE_DataSet2";
            this._SATIŞ_MERKEZ_ONLİNE_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(82, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 43);
            this.button6.TabIndex = 18;
            this.button6.Text = "indirimlier goster";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 227);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 35);
            this.textBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "indirim oranı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "urun id";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(673, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 43);
            this.button7.TabIndex = 16;
            this.button7.Text = "toplam_satis_GÖSTER";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(27, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "AŞADAKİ TEXT BOX (OSAMA) YAZABİLİRSİNİZ ÖRNEK OLARAK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(642, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "AŞADAKİ BUTUNLER SADECE TIKLA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(27, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(582, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "AŞADAKİ  BUTUN SONUCU GÖRMEK İÇİN ÖNCE GİRDVİEW DA BİR SATIRA YE TIKLAYIN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 518);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SATIŞ_MERKEZ_ONLİNE_DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private _SATIŞ_MERKEZ_ONLİNE_DataSet2 _SATIŞ_MERKEZ_ONLİNE_DataSet2;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private _SATIŞ_MERKEZ_ONLİNE_DataSet2TableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}