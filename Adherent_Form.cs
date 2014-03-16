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
    public partial class Adherent_Form : Form
    {

        public OracleConnection conn = new OracleConnection();
        private DataSet myData = new DataSet();
        private BindingSource source;
        private bool retards = false;

        public Adherent_Form()
        {
            InitializeComponent();
        }

        private void List_Adherents()
        {
            try
            {
                LB_Clients.Items.Clear();

                OracleCommand oraCMD = new OracleCommand("Gestion_Adherents.Lister", conn);
                oraCMD.CommandText = "Gestion_Adherents.Lister";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter ref_cursor = new OracleParameter("LISTE", OracleDbType.RefCursor);
                ref_cursor.Direction = ParameterDirection.ReturnValue;
                oraCMD.Parameters.Add(ref_cursor);

                OracleDataReader oraRead = oraCMD.ExecuteReader();

                while (oraRead.Read())
                {
                    LB_Clients.Items.Add(oraRead.GetInt32(0) + "," + oraRead.GetString(1) + "," + oraRead.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Ajouter_Adherent(string nom, string prenom)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Adherents.Insertion", conn);
                oraCMD.CommandText = "Gestion_Adherents.Insertion";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter pnom = new OracleParameter("pnom", OracleDbType.Varchar2);
                pnom.Direction = ParameterDirection.Input;
                pnom.Value = nom;
                oraCMD.Parameters.Add(pnom);

                OracleParameter pprenom = new OracleParameter("pprenom", OracleDbType.Varchar2);
                pprenom.Direction = ParameterDirection.Input;
                pprenom.Value = prenom;
                oraCMD.Parameters.Add(pprenom);

                oraCMD.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Retirer_Adherent(int num)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Adherents.Supprimer", conn);
                oraCMD.CommandText = "Gestion_Adherents.Supprimer";
                oraCMD.CommandType = CommandType.StoredProcedure;

                OracleParameter pnum = new OracleParameter("pnum", OracleDbType.Int32);
                pnum.Direction = ParameterDirection.Input;
                pnum.Value = num;
                oraCMD.Parameters.Add(pnum);

                oraCMD.Parameters.Add(pnum);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Lister_Emprunts(int num)
        {
            try
            {
                myData.Clear();

                OracleCommand oraCMD;

                if (retards)
                {
                    oraCMD = new OracleCommand("Gestion_Emprunts.ConsultRetards", conn);
                    oraCMD.CommandText = "Gestion_Emprunts.ConsultRetards";
                    oraCMD.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    oraCMD = new OracleCommand("Gestion_Emprunts.ConsultEmprunts", conn);
                    oraCMD.CommandText = "Gestion_Emprunts.ConsultEmprunts";
                    oraCMD.CommandType = CommandType.StoredProcedure;
                }


                OracleParameter ref_cursor = new OracleParameter("LISTE", OracleDbType.RefCursor);
                ref_cursor.Direction = ParameterDirection.ReturnValue;
                oraCMD.Parameters.Add(ref_cursor);

                OracleParameter pnum = new OracleParameter("pnum", OracleDbType.Int32);
                pnum.Direction = ParameterDirection.Input;
                pnum.Value = num;
                oraCMD.Parameters.Add(pnum);

                OracleDataAdapter oraAdapt = new OracleDataAdapter(oraCMD);
                oraAdapt.Fill(myData, "Emprunts");
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
            source = new BindingSource(myData, "Emprunts");
            DGV_Emprunts_Client.DataSource = source;
        }

        private void Adherent_Form_Load(object sender, EventArgs e)
        {
            List_Adherents();
        }

        private void LB_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;
            List<string> temp;

            temp = LB_Clients.SelectedItem.ToString().Split(',').ToList<string>();
            num = int.Parse(temp[0]);

            Lister_Emprunts(num);
        }

        private void BTN_Ajout_Adherent_Click(object sender, EventArgs e)
        {
            Ajout_Adherent_Form dlg = new Ajout_Adherent_Form();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Ajouter_Adherent(dlg.nom, dlg.prenom);
            }
            List_Adherents();
        }

        private void BTN_Retirer_Adherent_Click(object sender, EventArgs e)
        {
            int num;
            List<string> temp;

            temp = LB_Clients.SelectedItem.ToString().Split(',').ToList<string>();
            num = int.Parse(temp[0]);

            Retirer_Adherent(num);
            List_Adherents();
        }
    }
}
