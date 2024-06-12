namespace HastaneOtomasyonu
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaVeÖdemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatakYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ameliyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labaratuvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.doktorlarToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.faturaVeÖdemeToolStripMenuItem,
            this.yatakYönetimiToolStripMenuItem,
            this.ameliyatToolStripMenuItem,
            this.doktorEkranıToolStripMenuItem,
            this.labaratuvarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(795, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            this.hastalarToolStripMenuItem.Click += new System.EventHandler(this.hastalarToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // doktorlarToolStripMenuItem
            // 
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.doktorlarToolStripMenuItem.Text = "Doktorlar";
            this.doktorlarToolStripMenuItem.Click += new System.EventHandler(this.doktorlarToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // faturaVeÖdemeToolStripMenuItem
            // 
            this.faturaVeÖdemeToolStripMenuItem.Name = "faturaVeÖdemeToolStripMenuItem";
            this.faturaVeÖdemeToolStripMenuItem.Size = new System.Drawing.Size(109, 19);
            this.faturaVeÖdemeToolStripMenuItem.Text = "Fatura ve Ödeme";
            this.faturaVeÖdemeToolStripMenuItem.Click += new System.EventHandler(this.faturaVeÖdemeToolStripMenuItem_Click);
            // 
            // yatakYönetimiToolStripMenuItem
            // 
            this.yatakYönetimiToolStripMenuItem.Name = "yatakYönetimiToolStripMenuItem";
            this.yatakYönetimiToolStripMenuItem.Size = new System.Drawing.Size(97, 19);
            this.yatakYönetimiToolStripMenuItem.Text = "Yatak Yönetimi";
            this.yatakYönetimiToolStripMenuItem.Click += new System.EventHandler(this.yatakYönetimiToolStripMenuItem_Click);
            // 
            // ameliyatToolStripMenuItem
            // 
            this.ameliyatToolStripMenuItem.Name = "ameliyatToolStripMenuItem";
            this.ameliyatToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.ameliyatToolStripMenuItem.Text = "Ameliyat";
            this.ameliyatToolStripMenuItem.Click += new System.EventHandler(this.ameliyatToolStripMenuItem_Click);
            // 
            // doktorEkranıToolStripMenuItem
            // 
            this.doktorEkranıToolStripMenuItem.Name = "doktorEkranıToolStripMenuItem";
            this.doktorEkranıToolStripMenuItem.Size = new System.Drawing.Size(90, 19);
            this.doktorEkranıToolStripMenuItem.Text = "Doktor Ekranı";
            this.doktorEkranıToolStripMenuItem.Click += new System.EventHandler(this.doktorEkranıToolStripMenuItem_Click);
            // 
            // labaratuvarToolStripMenuItem
            // 
            this.labaratuvarToolStripMenuItem.Name = "labaratuvarToolStripMenuItem";
            this.labaratuvarToolStripMenuItem.Size = new System.Drawing.Size(81, 19);
            this.labaratuvarToolStripMenuItem.Text = "Labaratuvar";
            this.labaratuvarToolStripMenuItem.Click += new System.EventHandler(this.labaratuvarToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaVeÖdemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatakYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ameliyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labaratuvarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}