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
    public partial class Main_Form : Form
    {
        private OracleConnection conn = new OracleConnection();
        BindingSource source;
        DataSet livres_data = new DataSet();

        public Main_Form()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////// Connection à la BD //////////////////////////////////////////////////////////
        private void Connect()
        {
            string Dsource = "(DESCRIPTION=" + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

            String ChaineConnexion = "Data Source=" + Dsource
            + ";User Id= hunterro;Password =oracle2";
            conn.ConnectionString = ChaineConnexion;

            try
            {
                conn.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Application.Exit();
            }
        }

        private void Ajouter_Livre(string titre, string auteur, int num)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Documents.AjouterLivre", conn);
                oraCMD.CommandText = "Gestion_Documents.AjouterLivre";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter pnum = new OracleParameter("pnum", OracleDbType.Int32);
                pnum.Direction = ParameterDirection.Input;
                pnum.Value = num;
                oraCMD.Parameters.Add(pnum);

                OracleParameter pauteur = new OracleParameter("pauteur", OracleDbType.Varchar2);
                pauteur.Direction = ParameterDirection.Input;
                pauteur.Value = auteur;
                oraCMD.Parameters.Add(pauteur);

                OracleParameter ptitre = new OracleParameter("ptitre", OracleDbType.Varchar2);
                ptitre.Direction = ParameterDirection.Input;
                ptitre.Value = titre;
                oraCMD.Parameters.Add(ptitre);

                oraCMD.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void Retirer_Livre(int num)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Documents.RetirerLivre", conn);
                oraCMD.CommandText = "Gestion_Documents.RetirerLivre";
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

        private void List_Documents()
        {
            try
            {
                livres_data.Clear();

                OracleCommand oraCMD = new OracleCommand("Gestion_Documents.ListerLivres", conn);
                oraCMD.CommandText = "Gestion_Documents.ListerLivres";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter ref_cursor = new OracleParameter("LISTE", OracleDbType.RefCursor);
                ref_cursor.Direction = ParameterDirection.ReturnValue;
                oraCMD.Parameters.Add(ref_cursor);

                OracleDataAdapter oraAdapt = new OracleDataAdapter(oraCMD);
                oraAdapt.Fill(livres_data, "Livres");

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
            source = new BindingSource(livres_data, "Livres");
            DGV_Livres.DataSource = source;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Connect();
            List_Documents();
        }

        private void BTN_Ajout_Livre_Click(object sender, EventArgs e)
        {
            Ajout_Livre_Form dlg = new Ajout_Livre_Form();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Ajouter_Livre(dlg.titre, dlg.auteur, dlg.num);
                List_Documents();
            }
        }

        private void BTN_Retirer_Livre_Click(object sender, EventArgs e)
        {
            int nb = int.Parse(DGV_Livres.SelectedRows[0].Cells[0].Value.ToString());
            Retirer_Livre(nb);
        }

        private void BTN_Exemplaires_Click(object sender, EventArgs e)
        {
            Exemplaires_Form form = new Exemplaires_Form();
            form.conn = conn;
            int num;

            num = int.Parse(DGV_Livres.SelectedRows[0].Cells[0].Value.ToString());
            form.numLivre = num;
            form.ShowDialog();
        }

        private void adhérentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adherent_Form form = new Adherent_Form();
            form.conn = conn;
            form.ShowDialog();
        }

        private void retoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprunts_Form form = new Emprunts_Form();
            form.conn = conn;
            form.ShowDialog();
        }
    }
}
