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

namespace Gestion_des_clients
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string strcn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Gestionclient;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        private void Form2_Load(object sender, EventArgs e)
        {
            //To get data from Sql server
            cn.ConnectionString = strcn;
            GetClients();
        }
        void GetClients()
        {
            //Creation d'une SQLCommand
            SqlCommand selectCommand = new SqlCommand("select * from client", cn);
            da.SelectCommand = selectCommand;
            da.Fill(ds, "clt");
            dataGridView1.DataSource = ds.Tables["clt"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = "select * from client where ville = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(req, cn);

            cn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cn.Close();
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
