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
using System.Data.Common;

namespace phone
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =D:\C# LREARNING\FARADARS\APPS\PHONE\DATABASE1.MDF; Integrated Security = True";
            conn.Open();
            fillgred();
        }
        void fillgred(string s="Select * from tbltel")
        {
            cmd.CommandText = s;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            da.Fill(ds,"T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "T1");
            textBoxname.DataBindings.Clear();
            textBoxname.DataBindings.Add("text", ds, "T1.firstname");
            textBoxfamily.DataBindings.Clear();
            textBoxfamily.DataBindings.Add("text", ds, "T1.lastname");
            textBoxphone.DataBindings.Clear();
            textBoxphone.DataBindings.Add("text", ds, "T1.phoneno");
            textBoxaddress.DataBindings.Clear();
            textBoxaddress.DataBindings.Add("text", ds, "T1.address");
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
