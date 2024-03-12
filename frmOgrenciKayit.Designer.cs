namespace WinFormAppStudentRegistrationDB
{
    partial class frmOgrenciKayıt
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Ad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_soyad = new System.Windows.Forms.TextBox();
			this.txt_telefon = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_yas = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(228, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(335, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "ÖĞRENCİ KAYIT FORMU";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(229, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "AD";
			// 
			// txt_Ad
			// 
			this.txt_Ad.Location = new System.Drawing.Point(296, 96);
			this.txt_Ad.MaxLength = 30;
			this.txt_Ad.Name = "txt_Ad";
			this.txt_Ad.Size = new System.Drawing.Size(199, 20);
			this.txt_Ad.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(197, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "SOYAD";
			// 
			// txt_soyad
			// 
			this.txt_soyad.Location = new System.Drawing.Point(296, 142);
			this.txt_soyad.MaxLength = 20;
			this.txt_soyad.Name = "txt_soyad";
			this.txt_soyad.Size = new System.Drawing.Size(199, 20);
			this.txt_soyad.TabIndex = 4;
			// 
			// txt_telefon
			// 
			this.txt_telefon.Location = new System.Drawing.Point(296, 186);
			this.txt_telefon.MaxLength = 30;
			this.txt_telefon.Name = "txt_telefon";
			this.txt_telefon.Size = new System.Drawing.Size(199, 20);
			this.txt_telefon.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(176, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "TELEFON";
			// 
			// txt_yas
			// 
			this.txt_yas.Location = new System.Drawing.Point(296, 230);
			this.txt_yas.MaxLength = 30;
			this.txt_yas.Name = "txt_yas";
			this.txt_yas.Size = new System.Drawing.Size(76, 20);
			this.txt_yas.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(216, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "YAŞ";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(280, 310);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 53);
			this.button1.TabIndex = 9;
			this.button1.Text = "KAYDET";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmOgrenciKayıt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_yas);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_telefon);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_soyad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_Ad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmOgrenciKayıt";
			this.Text = "Öğrenci Kayıt";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}