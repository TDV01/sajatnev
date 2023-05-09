namespace sajatnevGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vásárlásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxnyvek = new System.Windows.Forms.ListBox();
            this.listboxvasarlok = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.megveszem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konyvToolStripMenuItem,
            this.vásárlóToolStripMenuItem,
            this.vásárlásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konyvToolStripMenuItem
            // 
            this.konyvToolStripMenuItem.Name = "konyvToolStripMenuItem";
            this.konyvToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.konyvToolStripMenuItem.Text = "Konyv";
            this.konyvToolStripMenuItem.Click += new System.EventHandler(this.konyvToolStripMenuItem_Click);
            // 
            // vásárlóToolStripMenuItem
            // 
            this.vásárlóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosítToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.vásárlóToolStripMenuItem.Name = "vásárlóToolStripMenuItem";
            this.vásárlóToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vásárlóToolStripMenuItem.Text = "Vásárló";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // módosítToolStripMenuItem
            // 
            this.módosítToolStripMenuItem.Name = "módosítToolStripMenuItem";
            this.módosítToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosítToolStripMenuItem.Text = "Módosít";
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törölToolStripMenuItem.Text = "Töröl";
            // 
            // vásárlásToolStripMenuItem
            // 
            this.vásárlásToolStripMenuItem.Name = "vásárlásToolStripMenuItem";
            this.vásárlásToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vásárlásToolStripMenuItem.Text = "Vásárlás";
            // 
            // listboxnyvek
            // 
            this.listboxnyvek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listboxnyvek.FormattingEnabled = true;
            this.listboxnyvek.Location = new System.Drawing.Point(0, 24);
            this.listboxnyvek.Name = "listboxnyvek";
            this.listboxnyvek.Size = new System.Drawing.Size(257, 426);
            this.listboxnyvek.TabIndex = 1;
            // 
            // listboxvasarlok
            // 
            this.listboxvasarlok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listboxvasarlok.FormattingEnabled = true;
            this.listboxvasarlok.Location = new System.Drawing.Point(543, 24);
            this.listboxvasarlok.Name = "listboxvasarlok";
            this.listboxvasarlok.Size = new System.Drawing.Size(257, 426);
            this.listboxvasarlok.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Location = new System.Drawing.Point(257, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(286, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // megveszem
            // 
            this.megveszem.Location = new System.Drawing.Point(356, 130);
            this.megveszem.Name = "megveszem";
            this.megveszem.Size = new System.Drawing.Size(75, 23);
            this.megveszem.TabIndex = 4;
            this.megveszem.Text = "Megveszem";
            this.megveszem.UseVisualStyleBackColor = true;
            this.megveszem.Click += new System.EventHandler(this.megveszem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.megveszem);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listboxvasarlok);
            this.Controls.Add(this.listboxnyvek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konyvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vásárlásToolStripMenuItem;
        private System.Windows.Forms.ListBox listboxnyvek;
        private System.Windows.Forms.ListBox listboxvasarlok;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button megveszem;
    }
}

