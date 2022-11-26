using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;

namespace Modelisation_d_examen
{
    public partial class Formulaire : Form
    {
        String strConnection = @"Data Source=SALMACHARQUI;Initial Catalog=bibliotheque;Integrated Security=True";
        public Formulaire()
        {
            InitializeComponent();
        }

        private void ajouterUnQuestionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUnQCMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void creerUnExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(strConnection);
            string strSql = "Insert into evaluation Values('" + toolStripTextBoxIntitul.Text + "', '" + toolStripTextBoxMatiere.Text + "','" + toolStripTextBoxNbrEtudiant.Text + "','"+toolStripTextBoxDateDebut.Text+"','"+toolStripTextBoxDateFin.Text+"',)";
            SqlCommand sqlcmd = new SqlCommand(strSql, cnx);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
        }

        private void toolStripTextBoxIntitul_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripMenuItemajoutQuestions_Click(object sender, EventArgs e)
        {
           
            
        }

        private void ajouterUnQCMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxPropos_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxQuestionOuvert_Click(object sender, EventArgs e)
        {

        }
    }
}
