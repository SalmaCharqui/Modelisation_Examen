using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading.Channels;
using System.Data.SqlTypes;
using System.Security.Cryptography.Xml;
namespace formulaire
{
    public partial class FormPrincipale : System.Windows.Forms.Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }
        String strConnection = @"Data Source=SALMACHARQUI;Initial Catalog=bibliotheque;Integrated Security=True";
        SqlConnection cnx = new SqlConnection(strConnection);
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

        }
    }
}