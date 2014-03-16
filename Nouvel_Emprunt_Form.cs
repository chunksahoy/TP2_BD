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
    public partial class Nouvel_Emprunt_Form : Form
    {
        public OracleConnection conn = new OracleConnection();
        
        public int numAdh;
        public int numEx;

        public Nouvel_Emprunt_Form()
        {
            InitializeComponent();
        }

        private void Initialize_Adherents()
        {
            string sql = "select numadherent from adherents";

            OracleCommand oraCMD = new OracleCommand(sql, conn);
            oraCMD.CommandType = CommandType.Text;

            OracleDataReader oraRead = oraCMD.ExecuteReader();

            while (oraRead.Read())
            {
                CB_NumAdherent.Items.Add(oraRead.GetInt32(0));
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            numAdh = int.Parse(CB_NumAdherent.SelectedItem.ToString());
            numEx = int.Parse(TB_NumExemplaire.Text);
        }

        private void Nouvel_Emprunt_Form_Load(object sender, EventArgs e)
        {
            Initialize_Adherents();
        }
    }
}
