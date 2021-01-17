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
    public partial class Form1 : Form
    {

        public void Empty(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    Empty(ct);
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        string strcn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Gestionclient;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        private void Form1_Load(object sender, EventArgs e)
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

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vider les champs ?", "Oui", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Empty(this);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow Ligne = ds.Tables["clt"].NewRow();
            Ligne[0] = int.Parse(textBox4.Text);
            Ligne[1] = textBox1.Text;
            Ligne[2] = textBox2.Text;
            Ligne[3] = textBox3.Text;
            ds.Tables["clt"].Rows.Add(Ligne);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < ds.Tables["clt"].Rows.Count; i++)
            {
                if (textBox4.Text == ds.Tables["clt"].Rows[i][0].ToString())
                {
                    p = i;
                }
            }
            if (p == -1) { MessageBox.Show("cilent introvable"); }
            else
            {
                ds.Tables["clt"].Rows[p][0] = int.Parse(textBox4.Text);
                ds.Tables["clt"].Rows[p][1] = textBox1.Text;
                ds.Tables["clt"].Rows[p][2] = textBox2.Text;
                ds.Tables["clt"].Rows[p][3] = textBox3.Text;
                MessageBox.Show("Le client a été modifié avec succès");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < ds.Tables["clt"].Rows.Count; i++)
            {
                if (textBox4.Text == ds.Tables["clt"].Rows[i][0].ToString())
                {
                    p = i;
                }
            }
            if (p == -1) { MessageBox.Show("cilent introvable"); }
            else
            {
                ds.Tables["clt"].Rows[p].Delete();
                MessageBox.Show("Le client a été supprimè avec succès");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "clt");
            MessageBox.Show("Les données ont été bien Enregistrées");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
