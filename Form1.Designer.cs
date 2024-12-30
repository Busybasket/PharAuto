namespace PharAuto
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
            this.referanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.login1 = new PharAuto.login();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // referanslarToolStripMenuItem
            // 
            this.referanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıTanımlamaToolStripMenuItem,
            this.poliklinikTanımlamaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.referanslarToolStripMenuItem.Name = "referanslarToolStripMenuItem";
            this.referanslarToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.referanslarToolStripMenuItem.Text = "Referanslar";
            // 
            // kullanıcıTanımlamaToolStripMenuItem
            // 
            this.kullanıcıTanımlamaToolStripMenuItem.Name = "kullanıcıTanımlamaToolStripMenuItem";
            this.kullanıcıTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.kullanıcıTanımlamaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            this.kullanıcıTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanımlamaToolStripMenuItem_Click);
            // 
            // poliklinikTanımlamaToolStripMenuItem
            // 
            this.poliklinikTanımlamaToolStripMenuItem.Name = "poliklinikTanımlamaToolStripMenuItem";
            this.poliklinikTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.poliklinikTanımlamaToolStripMenuItem.Text = "Poliklinik Tanıtma";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hastaKabulToolStripMenuItem
            // 
            this.hastaKabulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.hastaKabulToolStripMenuItem.Name = "hastaKabulToolStripMenuItem";
            this.hastaKabulToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.hastaKabulToolStripMenuItem.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referanslarToolStripMenuItem,
            this.hastaKabulToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login1.Location = new System.Drawing.Point(359, 191);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(265, 237);
            this.login1.TabIndex = 0;
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PharAuto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private login login1;
        private System.Windows.Forms.ToolStripMenuItem referanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKabulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

