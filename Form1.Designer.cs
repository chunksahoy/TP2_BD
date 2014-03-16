namespace TP1_BD
{
    partial class Main_Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_Livres = new System.Windows.Forms.DataGridView();
            this.BTN_Ajout_Livre = new System.Windows.Forms.Button();
            this.BTN_Retirer_Livre = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adhérentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Exemplaires = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livres)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Livres
            // 
            this.DGV_Livres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Livres.Location = new System.Drawing.Point(12, 27);
            this.DGV_Livres.Name = "DGV_Livres";
            this.DGV_Livres.Size = new System.Drawing.Size(655, 228);
            this.DGV_Livres.TabIndex = 0;
            // 
            // BTN_Ajout_Livre
            // 
            this.BTN_Ajout_Livre.Location = new System.Drawing.Point(12, 261);
            this.BTN_Ajout_Livre.Name = "BTN_Ajout_Livre";
            this.BTN_Ajout_Livre.Size = new System.Drawing.Size(211, 47);
            this.BTN_Ajout_Livre.TabIndex = 1;
            this.BTN_Ajout_Livre.Text = "Ajouter Livre";
            this.BTN_Ajout_Livre.UseVisualStyleBackColor = true;
            this.BTN_Ajout_Livre.Click += new System.EventHandler(this.BTN_Ajout_Livre_Click);
            // 
            // BTN_Retirer_Livre
            // 
            this.BTN_Retirer_Livre.Location = new System.Drawing.Point(229, 260);
            this.BTN_Retirer_Livre.Name = "BTN_Retirer_Livre";
            this.BTN_Retirer_Livre.Size = new System.Drawing.Size(221, 47);
            this.BTN_Retirer_Livre.TabIndex = 1;
            this.BTN_Retirer_Livre.Text = "Retirer Livre";
            this.BTN_Retirer_Livre.UseVisualStyleBackColor = true;
            this.BTN_Retirer_Livre.Click += new System.EventHandler(this.BTN_Retirer_Livre_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adhérentToolStripMenuItem,
            this.retoursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adhérentToolStripMenuItem
            // 
            this.adhérentToolStripMenuItem.Name = "adhérentToolStripMenuItem";
            this.adhérentToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.adhérentToolStripMenuItem.Text = "Adhérents";
            this.adhérentToolStripMenuItem.Click += new System.EventHandler(this.adhérentToolStripMenuItem_Click);
            // 
            // retoursToolStripMenuItem
            // 
            this.retoursToolStripMenuItem.Name = "retoursToolStripMenuItem";
            this.retoursToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.retoursToolStripMenuItem.Text = "Prêts/Retards";
            this.retoursToolStripMenuItem.Click += new System.EventHandler(this.retoursToolStripMenuItem_Click);
            // 
            // BTN_Exemplaires
            // 
            this.BTN_Exemplaires.Location = new System.Drawing.Point(456, 260);
            this.BTN_Exemplaires.Name = "BTN_Exemplaires";
            this.BTN_Exemplaires.Size = new System.Drawing.Size(211, 47);
            this.BTN_Exemplaires.TabIndex = 1;
            this.BTN_Exemplaires.Text = "Consulter Exemplaires";
            this.BTN_Exemplaires.UseVisualStyleBackColor = true;
            this.BTN_Exemplaires.Click += new System.EventHandler(this.BTN_Exemplaires_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 319);
            this.Controls.Add(this.BTN_Exemplaires);
            this.Controls.Add(this.BTN_Retirer_Livre);
            this.Controls.Add(this.BTN_Ajout_Livre);
            this.Controls.Add(this.DGV_Livres);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Livres)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Livres;
        private System.Windows.Forms.Button BTN_Ajout_Livre;
        private System.Windows.Forms.Button BTN_Retirer_Livre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adhérentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retoursToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Exemplaires;
    }
}

