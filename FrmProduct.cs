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

namespace demo_Adonet
{
    public partial class frmproduct: Form
    {
        public frmproduct()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IQULJ22J\\SQLEXPRESS;Initial Catalog=DbistanbulAkademi;Integrated Security=True");
            connection.Open();
            SqlCommand Command = new SqlCommand("select * from tblproduct", connection);
            SqlDataAdapter adapter= new SqlDataAdapter(Command);
            DataTable dataTable=new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;   

            connection.Close();
        }
    }
}
