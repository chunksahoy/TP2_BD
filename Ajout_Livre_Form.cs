using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_BD
{
    public partial class Ajout_Livre_Form : Form
    {
        public string titre;
        public string auteur;
        public int num;

        public Ajout_Livre_Form()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            titre = TB_Titre.Text;
            auteur = TB_Auteur.Text;
            num = int.Parse(TB_Num.Text);
        }
    }
}
