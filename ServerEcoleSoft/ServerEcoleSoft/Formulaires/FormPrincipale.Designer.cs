namespace ServerEcoleSoft.Formulaires
{
    partial class FormPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.messagerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmissionMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecrireMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegardeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegardeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messagerieToolStripMenuItem,
            this.sauvegardeToolStripMenuItem,
            this.outilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // messagerieToolStripMenuItem
            // 
            this.messagerieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transmissionMessagesToolStripMenuItem,
            this.ecrireMessageToolStripMenuItem});
            this.messagerieToolStripMenuItem.Name = "messagerieToolStripMenuItem";
            this.messagerieToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.messagerieToolStripMenuItem.Text = "Acceuil";
            // 
            // transmissionMessagesToolStripMenuItem
            // 
            this.transmissionMessagesToolStripMenuItem.Name = "transmissionMessagesToolStripMenuItem";
            this.transmissionMessagesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.transmissionMessagesToolStripMenuItem.Text = "Transmission Messages";
            this.transmissionMessagesToolStripMenuItem.Click += new System.EventHandler(this.transmissionMessagesToolStripMenuItem_Click);
            // 
            // ecrireMessageToolStripMenuItem
            // 
            this.ecrireMessageToolStripMenuItem.Name = "ecrireMessageToolStripMenuItem";
            this.ecrireMessageToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ecrireMessageToolStripMenuItem.Text = "Ecrire Message";
            this.ecrireMessageToolStripMenuItem.Click += new System.EventHandler(this.ecrireMessageToolStripMenuItem_Click);
            // 
            // sauvegardeToolStripMenuItem
            // 
            this.sauvegardeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegardeToolStripMenuItem1,
            this.restaurationToolStripMenuItem});
            this.sauvegardeToolStripMenuItem.Name = "sauvegardeToolStripMenuItem";
            this.sauvegardeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // sauvegardeToolStripMenuItem1
            // 
            this.sauvegardeToolStripMenuItem1.Name = "sauvegardeToolStripMenuItem1";
            this.sauvegardeToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.sauvegardeToolStripMenuItem1.Text = "Sauvegarde";
            this.sauvegardeToolStripMenuItem1.Click += new System.EventHandler(this.sauvegardeToolStripMenuItem1_Click);
            // 
            // restaurationToolStripMenuItem
            // 
            this.restaurationToolStripMenuItem.Name = "restaurationToolStripMenuItem";
            this.restaurationToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.restaurationToolStripMenuItem.Text = "Restauration";
            this.restaurationToolStripMenuItem.Click += new System.EventHandler(this.restaurationToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegardeToolStripMenuItem2,
            this.restaurationToolStripMenuItem1});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // sauvegardeToolStripMenuItem2
            // 
            this.sauvegardeToolStripMenuItem2.Name = "sauvegardeToolStripMenuItem2";
            this.sauvegardeToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.sauvegardeToolStripMenuItem2.Text = "Sauvegarde";
            this.sauvegardeToolStripMenuItem2.Click += new System.EventHandler(this.sauvegardeToolStripMenuItem2_Click);
            // 
            // restaurationToolStripMenuItem1
            // 
            this.restaurationToolStripMenuItem1.Name = "restaurationToolStripMenuItem1";
            this.restaurationToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.restaurationToolStripMenuItem1.Text = "Restauration";
            this.restaurationToolStripMenuItem1.Click += new System.EventHandler(this.restaurationToolStripMenuItem1_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 346);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "Serveur de messaherie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messagerieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmissionMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegardeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecrireMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegardeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem restaurationToolStripMenuItem1;
    }
}