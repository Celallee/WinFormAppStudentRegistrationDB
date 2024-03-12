namespace WinFormAppStudentRegistrationDB
{
    partial class frm_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oGRENCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciKayitFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oGRENCİToolStripMenuItem,
            this.dERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oGRENCİToolStripMenuItem
            // 
            this.oGRENCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciKayitFormuToolStripMenuItem});
            this.oGRENCİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.oGRENCİToolStripMenuItem.Name = "oGRENCİToolStripMenuItem";
            this.oGRENCİToolStripMenuItem.Size = new System.Drawing.Size(132, 25);
            this.oGRENCİToolStripMenuItem.Text = "ÖĞRENCİ KAYIT";
            // 
            // ogrenciKayitFormuToolStripMenuItem
            // 
            this.ogrenciKayitFormuToolStripMenuItem.Name = "ogrenciKayitFormuToolStripMenuItem";
            this.ogrenciKayitFormuToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.ogrenciKayitFormuToolStripMenuItem.Text = "Öğrenci Kayıt Formu";
            this.ogrenciKayitFormuToolStripMenuItem.Click += new System.EventHandler(this.ogrenciKayitFormuToolStripMenuItem_Click);
            // 
            // dERSToolStripMenuItem
            // 
            this.dERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dERSToolStripMenuItem.Name = "dERSToolStripMenuItem";
            this.dERSToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.dERSToolStripMenuItem.Text = "KAYIT LİSTELE/SİL";
            this.dERSToolStripMenuItem.Click += new System.EventHandler(this.KayitListeleToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 162);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "frm_menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oGRENCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciKayitFormuToolStripMenuItem;
    }
}