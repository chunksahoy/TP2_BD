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
    public partial class Emprunts_Form : Form
    {
        public OracleConnection conn = new OracleConnection();
        private DataSet myData = new DataSet();
        private BindingSource source;
        private bool retards = false;

        public Emprunts_Form()
        {
            InitializeComponent();
        }

        private void Initialize_DGV()
        {
            try
            {
                OracleCommand oraCMD;
                myData.Clear();

                if (retards)
                {
                    oraCMD = new OracleCommand("Gestion_Emprunts.ListerRetards", conn);
                    oraCMD.CommandText = "Gestion_Emprunts.ListerRetards";
                    oraCMD.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    oraCMD = new OracleCommand("Gestion_Emprunts.ListerEmprunts", conn);
                    oraCMD.CommandText = "Gestion_Emprunts.ListerEmprunts";
                    oraCMD.CommandType = CommandType.StoredProcedure;
                }

                OracleParameter ref_cursor = new OracleParameter("LISTE", OracleDbType.RefCursor);
                ref_cursor.Direction = ParameterDirection.ReturnValue;
                oraCMD.Parameters.Add(ref_cursor);

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
            DGV_Emprunts.DataSource = source;
        }

        private void Nouveau_Pret(int numAdh, int numEx)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Emprunts.Nouveau", conn);
                oraCMD.CommandText = "Gestion_Emprunts.Nouveau";
                oraCMD.CommandType = CommandType.StoredProcedure;                

                OracleParameter pnumEx = new OracleParameter("pnumEx", OracleDbType.Int32);
                pnumEx.Direction = ParameterDirection.Input;
                pnumEx.Value = numEx;
                oraCMD.Parameters.Add(pnumEx);

                OracleParameter pnumAdh = new OracleParameter("pnumadh", OracleDbType.Int32);
                pnumAdh.Direction = ParameterDirection.Input;
                pnumAdh.Value = numAdh;
                oraCMD.Parameters.Add(pnumAdh);

                OracleParameter pemprunt = new OracleParameter("pemprunt", OracleDbType.Date);
                pemprunt.Direction = ParameterDirection.Input;
                pemprunt.Value = DateTime.Parse(DateTime.Today.ToShortDateString());
                oraCMD.Parameters.Add(pemprunt);

                OracleParameter pretour = new OracleParameter("pretour", OracleDbType.Date);
                pretour.Direction = ParameterDirection.Input;
                pretour.Value = DateTime.Parse( DateTime.Today.AddMonths(1).ToShortDateString());
                oraCMD.Parameters.Add(pretour);

                oraCMD.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Retour(int num)
        {
            try
            {
                OracleCommand oraCMD = new OracleCommand("Gestion_Emprunts.Retour", conn);
                oraCMD.CommandText = "Gestion_Emprunts.Retour";
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

        private void Emprunts_Form_Load(object sender, EventArgs e)
        {
            if (retards)
            {
                RB_Emprunts.Checked = false;
                RB_Retards.Checked = true;
            }
            else
            {
                RB_Emprunts.Checked = true;
                RB_Retards.Checked = false;
            }
            Initialize_DGV();
        }

        private void BTN_Emprunt_Click(object sender, EventArgs e)
        {
            Nouvel_Emprunt_Form dlg = new Nouvel_Emprunt_Form();
            dlg.conn = conn;
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Nouveau_Pret(dlg.numAdh, dlg.numEx);
            }
            Initialize_DGV();
        }

        private void BTN_Retour_Click(object sender, EventArgs e)
        {
           int num = int.Parse(DGV_Emprunts.SelectedRows[0].Cells[0].Value.ToString());

           Retour(num);
           Initialize_DGV();
        }

        private void RB_Emprunts_CheckedChanged(object sender, EventArgs e)
        {
            retards = false;
            Initialize_DGV();
        }

        private void RB_Retards_CheckedChanged(object sender, EventArgs e)
        {
            retards = true;
            Initialize_DGV();
        }
    }
}
