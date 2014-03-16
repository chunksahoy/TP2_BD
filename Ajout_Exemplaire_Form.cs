using Oracle.DataAccess.Client;
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
    public partial class Ajout_Exemplaire_Form : Form
    {
        public OracleConnection conn = new OracleConnection();
        public int quantite = 0;
        public string titre;
        public Ajout_Exemplaire_Form()
        {
            InitializeComponent();
        }
        
        private void Initialize_Titres()
        {
            try
            {
                string sql = "select titre from livres";

                OracleCommand oraCMD = new OracleCommand(sql, conn);
                oraCMD.CommandType = CommandType.Text;

                OracleDataReader oraRead = oraCMD.ExecuteReader();

                while (oraRead.Read())
                {
                    CB_Titre.Items.Add(oraRead.GetString(0));
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void Ajout_Exemplaire_Form_Load(object sender, EventArgs e)
        {
            Initialize_Titres();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            titre = CB_Titre.SelectedItem.ToString();
            quantite = int.Parse(NUD_Quantite.Value.ToString());
        }
    }
}
