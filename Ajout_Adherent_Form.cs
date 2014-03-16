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
    public partial class Ajout_Adherent_Form : Form
    {
        public string nom;
        public string prenom;

        public Ajout_Adherent_Form()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            nom = TB_Nom.Text;
            prenom = TB_Prenom.Text;
        }
    }
}
