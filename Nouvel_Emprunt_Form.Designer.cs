namespace TP1_BD
{
    partial class Nouvel_Emprunt_Form
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
            this.CB_NumAdherent = new System.Windows.Forms.ComboBox();
            this.TB_NumExemplaire = new System.Windows.Forms.TextBox();
            this.CB_Adherent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_NumAdherent
            // 
            this.CB_NumAdherent.FormattingEnabled = true;
            this.CB_NumAdherent.Location = new System.Drawing.Point(116, 12);
            this.CB_NumAdherent.Name = "CB_NumAdherent";
            this.CB_NumAdherent.Size = new System.Drawing.Size(72, 21);
            this.CB_NumAdherent.TabIndex = 0;
            // 
            // TB_NumExemplaire
            // 
            this.TB_NumExemplaire.Location = new System.Drawing.Point(116, 39);
            this.TB_NumExemplaire.Name = "TB_NumExemplaire";
            this.TB_NumExemplaire.Size = new System.Drawing.Size(72, 20);
            this.TB_NumExemplaire.TabIndex = 1;
            // 
            // CB_Adherent
            // 
            this.CB_Adherent.AutoSize = true;
            this.CB_Adherent.Location = new System.Drawing.Point(12, 12);
            this.CB_Adherent.Name = "CB_Adherent";
            this.CB_Adherent.Size = new System.Drawing.Size(81, 13);
            this.CB_Adherent.TabIndex = 2;
            this.CB_Adherent.Text = "Num. Adhérent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num. Exemplaire:";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(113, 68);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Accepter";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(32, 68);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // Nouvel_Emprunt_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 103);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Adherent);
            this.Controls.Add(this.TB_NumExemplaire);
            this.Controls.Add(this.CB_NumAdherent);
            this.Name = "Nouvel_Emprunt_Form";
            this.Text = "Nouveau Prêt";
            this.Load += new System.EventHandler(this.Nouvel_Emprunt_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_NumAdherent;
        private System.Windows.Forms.TextBox TB_NumExemplaire;
        private System.Windows.Forms.Label CB_Adherent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}