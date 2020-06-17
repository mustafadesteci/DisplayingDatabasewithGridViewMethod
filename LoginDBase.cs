using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Login
{
    public partial class LoginDBase : Form
    {
        public LoginDBase()
        {
            InitializeComponent();
        }

        
        private void button_Click(object sender, EventArgs e)
        {
            //Location of database file
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-I59KSTC;AttachDbFilename=" +
                                                            "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\" +
                                                            "MSSQL\\DATA\\users.mdf; " +
                                                            "Initial Catalog = users; Integrated Security = True");
            sqlconnection.Open();

            //gets data from table
            SqlDataAdapter sqldataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Table_1",sqlconnection);
            DataTable dt = new DataTable();
            sqldataAdapter.Fill(dt);
            datagridview.DataSource = dt;
        }

        
        private void LoginDBase_Load(object sender, EventArgs e)
        {
          
        }
    }
}
