namespace TP1_BD
{
    partial class Emprunts_Form
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
            this.DGV_Emprunts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Emprunts = new System.Windows.Forms.RadioButton();
            this.RB_Retards = new System.Windows.Forms.RadioButton();
            this.BTN_Emprunt = new System.Windows.Forms.Button();
            this.BTN_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emprunts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Emprunts
            // 
            this.DGV_Emprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emprunts.Location = new System.Drawing.Point(12, 12);
            this.DGV_Emprunts.Name = "DGV_Emprunts";
            this.DGV_Emprunts.Size = new System.Drawing.Size(589, 150);
            this.DGV_Emprunts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Retards);
            this.groupBox1.Controls.Add(this.RB_Emprunts);
            this.groupBox1.Location = new System.Drawing.Point(458, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 37);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // RB_Emprunts
            // 
            this.RB_Emprunts.AutoSize = true;
            this.RB_Emprunts.Location = new System.Drawing.Point(0, 8);
            this.RB_Emprunts.Name = "RB_Emprunts";
            this.RB_Emprunts.Size = new System.Drawing.Size(69, 17);
            this.RB_Emprunts.TabIndex = 0;
            this.RB_Emprunts.TabStop = true;
            this.RB_Emprunts.Text = "Emprunts";
            this.RB_Emprunts.UseVisualStyleBackColor = true;
            this.RB_Emprunts.CheckedChanged += new System.EventHandler(this.RB_Emprunts_CheckedChanged);
            // 
            // RB_Retards
            // 
            this.RB_Retards.AutoSize = true;
            this.RB_Retards.Location = new System.Drawing.Point(75, 8);
            this.RB_Retards.Name = "RB_Retards";
            this.RB_Retards.Size = new System.Drawing.Size(62, 17);
            this.RB_Retards.TabIndex = 0;
            this.RB_Retards.TabStop = true;
            this.RB_Retards.Text = "Retards";
            this.RB_Retards.UseVisualStyleBackColor = true;
            this.RB_Retards.CheckedChanged += new System.EventHandler(this.RB_Retards_CheckedChanged);
            // 
            // BTN_Emprunt
            // 
            this.BTN_Emprunt.Location = new System.Drawing.Point(12, 168);
            this.BTN_Emprunt.Name = "BTN_Emprunt";
            this.BTN_Emprunt.Size = new System.Drawing.Size(210, 32);
            this.BTN_Emprunt.TabIndex = 3;
            this.BTN_Emprunt.Text = "Nouveau Prêt";
            this.BTN_Emprunt.UseVisualStyleBackColor = true;
            this.BTN_Emprunt.Click += new System.EventHandler(this.BTN_Emprunt_Click);
            // 
            // BTN_Retour
            // 
            this.BTN_Retour.Location = new System.Drawing.Point(242, 168);
            this.BTN_Retour.Name = "BTN_Retour";
            this.BTN_Retour.Size = new System.Drawing.Size(210, 32);
            this.BTN_Retour.TabIndex = 3;
            this.BTN_Retour.Text = "Enregistrer Retour";
            this.BTN_Retour.UseVisualStyleBackColor = true;
            this.BTN_Retour.Click += new System.EventHandler(this.BTN_Retour_Click);
            // 
            // Emprunts_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 207);
            this.Controls.Add(this.BTN_Retour);
            this.Controls.Add(this.BTN_Emprunt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_Emprunts);
            this.Name = "Emprunts_Form";
            this.Text = "Emprunts Actuels";
            this.Load += new System.EventHandler(this.Emprunts_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emprunts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Emprunts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Retards;
        private System.Windows.Forms.RadioButton RB_Emprunts;
        private System.Windows.Forms.Button BTN_Emprunt;
        private System.Windows.Forms.Button BTN_Retour;
    }
}