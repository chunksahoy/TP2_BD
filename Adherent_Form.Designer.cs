namespace TP1_BD
{
    partial class Adherent_Form
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
            this.LB_Clients = new System.Windows.Forms.ListBox();
            this.DGV_Emprunts_Client = new System.Windows.Forms.DataGridView();
            this.BTN_Ajout_Adherent = new System.Windows.Forms.Button();
            this.BTN_Retirer_Adherent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emprunts_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Clients
            // 
            this.LB_Clients.FormattingEnabled = true;
            this.LB_Clients.Location = new System.Drawing.Point(12, 12);
            this.LB_Clients.Name = "LB_Clients";
            this.LB_Clients.Size = new System.Drawing.Size(166, 238);
            this.LB_Clients.TabIndex = 0;
            this.LB_Clients.SelectedIndexChanged += new System.EventHandler(this.LB_Clients_SelectedIndexChanged);
            // 
            // DGV_Emprunts_Client
            // 
            this.DGV_Emprunts_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emprunts_Client.Location = new System.Drawing.Point(184, 12);
            this.DGV_Emprunts_Client.Name = "DGV_Emprunts_Client";
            this.DGV_Emprunts_Client.Size = new System.Drawing.Size(430, 238);
            this.DGV_Emprunts_Client.TabIndex = 1;
            // 
            // BTN_Ajout_Adherent
            // 
            this.BTN_Ajout_Adherent.Location = new System.Drawing.Point(12, 256);
            this.BTN_Ajout_Adherent.Name = "BTN_Ajout_Adherent";
            this.BTN_Ajout_Adherent.Size = new System.Drawing.Size(81, 30);
            this.BTN_Ajout_Adherent.TabIndex = 3;
            this.BTN_Ajout_Adherent.Text = "Inscrire";
            this.BTN_Ajout_Adherent.UseVisualStyleBackColor = true;
            this.BTN_Ajout_Adherent.Click += new System.EventHandler(this.BTN_Ajout_Adherent_Click);
            // 
            // BTN_Retirer_Adherent
            // 
            this.BTN_Retirer_Adherent.Location = new System.Drawing.Point(97, 256);
            this.BTN_Retirer_Adherent.Name = "BTN_Retirer_Adherent";
            this.BTN_Retirer_Adherent.Size = new System.Drawing.Size(81, 30);
            this.BTN_Retirer_Adherent.TabIndex = 3;
            this.BTN_Retirer_Adherent.Text = "Désinscrire";
            this.BTN_Retirer_Adherent.UseVisualStyleBackColor = true;
            this.BTN_Retirer_Adherent.Click += new System.EventHandler(this.BTN_Retirer_Adherent_Click);
            // 
            // Adherent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 299);
            this.Controls.Add(this.BTN_Retirer_Adherent);
            this.Controls.Add(this.BTN_Ajout_Adherent);
            this.Controls.Add(this.DGV_Emprunts_Client);
            this.Controls.Add(this.LB_Clients);
            this.Name = "Adherent_Form";
            this.Text = "Adhérents";
            this.Load += new System.EventHandler(this.Adherent_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emprunts_Client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Clients;
        private System.Windows.Forms.DataGridView DGV_Emprunts_Client;
        private System.Windows.Forms.Button BTN_Ajout_Adherent;
        private System.Windows.Forms.Button BTN_Retirer_Adherent;
    }
}