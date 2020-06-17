using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

                           // Showing The Data in the Database with the Grid Method

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Clear username
        private void Clear1_Click(object sender, EventArgs e)
        {
            Tboxname.Text = " ";
        }

        //Clear password
        private void Clear2_Click(object sender, EventArgs e)
        {
            Tboxpass.Text = " ";
        }

        //Clear phonenumber
        private void Clear3_Click(object sender, EventArgs e)
        {
            Tboxpnumber.Text = " ";
        }

        //Clear location
        private void Clear4_Click(object sender, EventArgs e)
        {
            Tboxloc.Text = " ";
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
           
            //Location of database file
             SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-I59KSTC;AttachDbFilename=" +
                                                             "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.MSSQLSERVER\\MSSQL\\DATA\\users.mdf;" +
                                                             " Initial Catalog = users; Integrated Security = True");


            //query that gets data from the table
             string query = "SELECT * FROM dbo.Table_1 WHERE username='" + Tboxname.Text +
                                                      "'and password='" + Tboxpass.Text +
                                                      "' and location='" +Tboxloc.Text +
                                                      "' and pnumber='"+Tboxpnumber.Text+"' ";

            //communication between the Dataset and the SQL database
            SqlDataAdapter sqldataapter = new SqlDataAdapter(query, sqlconnection);
            DataTable datatable = new DataTable();
            sqldataapter.Fill(datatable);

            if (datatable.Rows.Count == 1)
            {
                LoginDBase objectLDBase = new LoginDBase();
                objectLDBase.Visible = false;

                //allows the LoginDBase to open
                objectLDBase.ShowDialog();            
              
            }
            else
            {        
                MessageBox.Show("User information is wrong");
            }
        }


        //button Cancell
        private void CancellButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


    }
}


