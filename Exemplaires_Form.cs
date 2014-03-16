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
    public partial class Exemplaires_Form : Form
    {
        public OracleConnection conn = new OracleConnection();
        private BindingSource source;
        private DataSet myData = new DataSet();
        public int numLivre;

        public Exemplaires_Form()
        {
            InitializeComponent();
        }

        private void List_Exemplaires()
        {
            try
            {
                myData.Clear();

                OracleCommand oraCMD = new OracleCommand("Gestion_Documents.ListerExemplaires", conn);
                oraCMD.CommandText = "Gestion_Documents.ListerExemplaires";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter ref_cursor = new OracleParameter("LISTE", OracleDbType.RefCursor);
                ref_cursor.Direction = ParameterDirection.ReturnValue;
                oraCMD.Parameters.Add(ref_cursor);

                OracleParameter pnum = new OracleParameter("pnum", OracleDbType.Int32);
                pnum.Direction = ParameterDirection.Input;
                pnum.Value = numLivre;
                oraCMD.Parameters.Add(pnum);

                OracleDataAdapter oraAdapt = new OracleDataAdapter(oraCMD);
                oraAdapt.Fill(myData, "Exemplaires");
                oraAdapt.Dispose();

                Fill_DGV();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Fill_DGV()
        {
            source = new BindingSource(myData, "Exemplaires");
            DGV_Exemplaires.DataSource = source;
        }

        private void Ajouter_Exemplaire(string titre, int nb)
        {
            try
            {
                string sql = "select numlivre from livres where titre = '" + titre + "'";
                int num = 0;
                for (int i = 0; i < nb; ++i)
                {
                    OracleCommand oraSelect = new OracleCommand(sql, conn);
                    oraSelect.CommandType = CommandType.Text;

                    OracleDataReader oraRead = oraSelect.ExecuteReader();
                    while (oraRead.Read())
                    {
                        num = oraRead.GetInt32(0);
                    }

                    OracleCommand oraCMD = new OracleCommand("Gestion_Documents.AjouterExemplaire", conn);
                    oraCMD.CommandText = "Gestion_Documents.AjouterExemplaire";
                    oraCMD.CommandType = CommandType.StoredProcedure;

                    OracleParameter pnumLi = new OracleParameter("pnumLi", OracleDbType.Int32);
                    pnumLi.Direction = ParameterDirection.Input;
                    pnumLi.Value = num;
                    oraCMD.Parameters.Add(pnumLi);

                    oraCMD.ExecuteNonQuery();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Retirer_Exemplaire(int num)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Documents.RetirerExemplaire", conn);
                oraCMD.CommandText = "Gestion_Documents.RetirerExemplaire";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter pnum = new OracleParameter("pnum", OracleDbType.Int32);
                pnum.Direction = ParameterDirection.Input;
                pnum.Value = num;
                oraCMD.Parameters.Add(pnum);

                oraCMD.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Exemplaires_Form_Load(object sender, EventArgs e)
        {
            List_Exemplaires();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Ajout_Exemplaire_Form dlg = new Ajout_Exemplaire_Form();
            dlg.conn = conn;
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Ajouter_Exemplaire(dlg.titre, dlg.quantite);
                List_Exemplaires();
            }
        }

        private void BTN_Retirer_Click(object sender, EventArgs e)
        {
            int nb = int.Parse(DGV_Exemplaires.SelectedRows[0].Cells[0].Value.ToString());
            Retirer_Exemplaire(nb);
            List_Exemplaires();
        }
    }
}
