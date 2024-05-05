namespace ThuatToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtlbK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bangro = new System.Windows.Forms.TextBox();
            this.txt_khoak1 = new System.Windows.Forms.TextBox();
            this.txt_khoak2 = new System.Windows.Forms.TextBox();
            this.txt_nhapm = new System.Windows.Forms.TextBox();
            this.txt_bangma = new System.Windows.Forms.TextBox();
            this.rdb_Ceasar = new System.Windows.Forms.RadioButton();
            this.rdb_Affine = new System.Windows.Forms.RadioButton();
            this.rdb_Vigenere = new System.Windows.Forms.RadioButton();
            this.btn_mahoa = new System.Windows.Forms.Button();
            this.btn_giaima = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập bản rõ P:";
            // 
            // txtlbK
            // 
            this.txtlbK.AutoSize = true;
            this.txtlbK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlbK.Location = new System.Drawing.Point(82, 210);
            this.txtlbK.Name = "txtlbK";
            this.txtlbK.Size = new System.Drawing.Size(118, 20);
            this.txtlbK.TabIndex = 0;
            this.txtlbK.Text = "Nhập khóa k:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập m:";
            // 
            // txt_bangro
            // 
            this.txt_bangro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bangro.Location = new System.Drawing.Point(261, 77);
            this.txt_bangro.Name = "txt_bangro";
            this.txt_bangro.Size = new System.Drawing.Size(224, 22);
            this.txt_bangro.TabIndex = 1;
            // 
            // txt_khoak1
            // 
            this.txt_khoak1.Location = new System.Drawing.Point(261, 210);
            this.txt_khoak1.Name = "txt_khoak1";
            this.txt_khoak1.Size = new System.Drawing.Size(100, 22);
            this.txt_khoak1.TabIndex = 1;
            // 
            // txt_khoak2
            // 
            this.txt_khoak2.Location = new System.Drawing.Point(385, 210);
            this.txt_khoak2.Name = "txt_khoak2";
            this.txt_khoak2.Size = new System.Drawing.Size(100, 22);
            this.txt_khoak2.TabIndex = 1;
            // 
            // txt_nhapm
            // 
            this.txt_nhapm.Location = new System.Drawing.Point(261, 254);
            this.txt_nhapm.Name = "txt_nhapm";
            this.txt_nhapm.Size = new System.Drawing.Size(100, 22);
            this.txt_nhapm.TabIndex = 1;
            // 
            // txt_bangma
            // 
            this.txt_bangma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bangma.Location = new System.Drawing.Point(261, 293);
            this.txt_bangma.Name = "txt_bangma";
            this.txt_bangma.Size = new System.Drawing.Size(224, 22);
            this.txt_bangma.TabIndex = 1;
            // 
            // rdb_Ceasar
            // 
            this.rdb_Ceasar.AutoSize = true;
            this.rdb_Ceasar.BackColor = System.Drawing.SystemColors.Info;
            this.rdb_Ceasar.Location = new System.Drawing.Point(16, 36);
            this.rdb_Ceasar.Name = "rdb_Ceasar";
            this.rdb_Ceasar.Size = new System.Drawing.Size(90, 24);
            this.rdb_Ceasar.TabIndex = 2;
            this.rdb_Ceasar.TabStop = true;
            this.rdb_Ceasar.Text = "Ceasar";
            this.rdb_Ceasar.UseVisualStyleBackColor = false;
            this.rdb_Ceasar.CheckedChanged += new System.EventHandler(this.rdb_Ceasar_CheckedChanged);
            // 
            // rdb_Affine
            // 
            this.rdb_Affine.AutoSize = true;
            this.rdb_Affine.BackColor = System.Drawing.SystemColors.Info;
            this.rdb_Affine.Location = new System.Drawing.Point(140, 36);
            this.rdb_Affine.Name = "rdb_Affine";
            this.rdb_Affine.Size = new System.Drawing.Size(79, 24);
            this.rdb_Affine.TabIndex = 2;
            this.rdb_Affine.TabStop = true;
            this.rdb_Affine.Text = "Affine";
            this.rdb_Affine.UseVisualStyleBackColor = false;
            this.rdb_Affine.CheckedChanged += new System.EventHandler(this.rdb_Affine_CheckedChanged);
            // 
            // rdb_Vigenere
            // 
            this.rdb_Vigenere.AutoSize = true;
            this.rdb_Vigenere.BackColor = System.Drawing.SystemColors.Info;
            this.rdb_Vigenere.Location = new System.Drawing.Point(258, 36);
            this.rdb_Vigenere.Name = "rdb_Vigenere";
            this.rdb_Vigenere.Size = new System.Drawing.Size(104, 24);
            this.rdb_Vigenere.TabIndex = 2;
            this.rdb_Vigenere.TabStop = true;
            this.rdb_Vigenere.Text = "Vigenere";
            this.rdb_Vigenere.UseVisualStyleBackColor = false;
            this.rdb_Vigenere.CheckedChanged += new System.EventHandler(this.rdb_Vigenere_CheckedChanged);
            // 
            // btn_mahoa
            // 
            this.btn_mahoa.Location = new System.Drawing.Point(83, 359);
            this.btn_mahoa.Name = "btn_mahoa";
            this.btn_mahoa.Size = new System.Drawing.Size(75, 44);
            this.btn_mahoa.TabIndex = 3;
            this.btn_mahoa.Text = "Mã hóa";
            this.btn_mahoa.UseVisualStyleBackColor = true;
            this.btn_mahoa.Click += new System.EventHandler(this.btn_mahoa_Click_1);
            this.btn_mahoa.MouseHover += new System.EventHandler(this.btn_mahoa_MouseHover);
            // 
            // btn_giaima
            // 
            this.btn_giaima.Location = new System.Drawing.Point(206, 359);
            this.btn_giaima.Name = "btn_giaima";
            this.btn_giaima.Size = new System.Drawing.Size(75, 44);
            this.btn_giaima.TabIndex = 3;
            this.btn_giaima.Text = "Giải mã";
            this.btn_giaima.UseVisualStyleBackColor = true;
            this.btn_giaima.Click += new System.EventHandler(this.btn_giaima_Click_1);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Location = new System.Drawing.Point(324, 359);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(75, 44);
            this.btn_nhaplai.TabIndex = 3;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click_1);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(454, 359);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 44);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bản Mã:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Ceasar);
            this.groupBox1.Controls.Add(this.rdb_Affine);
            this.groupBox1.Controls.Add(this.rdb_Vigenere);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn hệ mã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_giaima);
            this.Controls.Add(this.btn_mahoa);
            this.Controls.Add(this.txt_khoak2);
            this.Controls.Add(this.txt_bangma);
            this.Controls.Add(this.txt_nhapm);
            this.Controls.Add(this.txt_khoak1);
            this.Controls.Add(this.txt_bangro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlbK);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtlbK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bangro;
        private System.Windows.Forms.TextBox txt_khoak1;
        private System.Windows.Forms.TextBox txt_khoak2;
        private System.Windows.Forms.TextBox txt_nhapm;
        private System.Windows.Forms.TextBox txt_bangma;
        private System.Windows.Forms.RadioButton rdb_Ceasar;
        private System.Windows.Forms.RadioButton rdb_Affine;
        private System.Windows.Forms.RadioButton rdb_Vigenere;
        private System.Windows.Forms.Button btn_mahoa;
        private System.Windows.Forms.Button btn_giaima;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

