using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

public class Class1
{

    public Class1()
	{
        try
        {
            SqlConnection cnx = new SqlConnection(strConnection);
            cnx.open();

        }
        catch(SqlException ex)
        {
            console.writeline("erreur de connexion !!");
        }


	}
}
