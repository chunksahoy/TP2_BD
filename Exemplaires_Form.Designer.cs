namespace TP1_BD
{
    partial class Exemplaires_Form
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
            this.DGV_Exemplaires = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Retirer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Exemplaires)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Exemplaires
            // 
            this.DGV_Exemplaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Exemplaires.Location = new System.Drawing.Point(12, 12);
            this.DGV_Exemplaires.Name = "DGV_Exemplaires";
            this.DGV_Exemplaires.Size = new System.Drawing.Size(578, 150);
            this.DGV_Exemplaires.TabIndex = 0;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(12, 168);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(284, 31);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter Exemplaire";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Retirer
            // 
            this.BTN_Retirer.Location = new System.Drawing.Point(302, 168);
            this.BTN_Retirer.Name = "BTN_Retirer";
            this.BTN_Retirer.Size = new System.Drawing.Size(288, 31);
            this.BTN_Retirer.TabIndex = 1;
            this.BTN_Retirer.Text = "Retirer Exemplaire";
            this.BTN_Retirer.UseVisualStyleBackColor = true;
            this.BTN_Retirer.Click += new System.EventHandler(this.BTN_Retirer_Click);
            // 
            // Exemplaires_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 210);
            this.Controls.Add(this.BTN_Retirer);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Exemplaires);
            this.Name = "Exemplaires_Form";
            this.Text = "Exemplaires";
            this.Load += new System.EventHandler(this.Exemplaires_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Exemplaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Exemplaires;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Retirer;
    }
}