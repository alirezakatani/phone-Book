﻿using System;
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
using System.IO;

namespace phone
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        CurrencyManager cr;
        int beforcurrent;
        Region x = new Region();
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
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename ="+Application.StartupPath+@"\DATABASE1.MDF; Integrated Security = True";
            conn.Open();
            fillgred();
        }
        void fillgred(string s="Select * from tbltel")
        {
            cmd.CommandText = s;
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            ds.Clear();
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
            pictureBox1.DataBindings.Clear();
            pictureBox1.DataBindings.Add("imagelocation", ds, "T1.picurl");
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Enabled = false;
            btnsave.Enabled = true;
            textBoxaddress.ReadOnly = false;
            textBoxfamily.ReadOnly = false;
            textBoxname.ReadOnly = false;
            textBoxphone.ReadOnly= false;
            btnbrowse.Enabled = true;
            textBoxphone.Text = "";
            textBoxfamily.Text = "";
            textBoxname.Text = "";
            textBoxaddress.Text = "";
            textBoxname.Focus();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            setcur(0);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            setcur(cr.Position+1);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            setcur(cr.Position-1);

        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            setcur(cr.Count);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.Connection = conn;
            c1.CommandText = "insert into tbltel values(@p1,@p2,@p3,@p4,@p5)";
            c1.Parameters.AddWithValue("p1", textBoxname.Text);
            c1.Parameters.AddWithValue("p2", textBoxfamily.Text);
            c1.Parameters.AddWithValue("p3", textBoxphone.Text);
            c1.Parameters.AddWithValue("p4", textBoxaddress.Text);
            c1.Parameters.AddWithValue("p5", Copypic(pictureBox1.ImageLocation,textBoxphone.Text));
            c1.ExecuteNonQuery();
            btnnew.Enabled = true;
            btnsave.Enabled = false;
            btnbrowse.Enabled = false;
            textBoxaddress.ReadOnly = true;
            textBoxfamily.ReadOnly = true;
            textBoxname.ReadOnly = true;
            textBoxphone.ReadOnly = true;
            fillgred();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("do you wnat to delete this item with name: " + textBoxname.Text + "/nand phone :   " + textBoxphone.Text,"delete ...", MessageBoxButtons.YesNo);
            if(x==DialogResult.Yes)
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "delete from tbltel where phoneno=@p1";
                c2.Parameters.AddWithValue("p1", textBoxphone.Text);
                c2.Connection = conn;
                c2.ExecuteNonQuery();
                fillgred();
            }
          
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            
           if(btnedit.Text=="edit")
            {
                textBoxaddress.ReadOnly = false;
                textBoxfamily.ReadOnly = false;
                textBoxname.ReadOnly = false;
                btnbrowse.Enabled = true;
                textBoxname.Focus();
                   beforcurrent = cr.Position;
                btnedit.Text = "apply";
                

            }
            else
            {
                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "update tbltel set firstname=@p1 , lastname=@p2 , address=@p3 , picurl=@p5 where phoneno=@p4";
                c3.Parameters.AddWithValue("p1", textBoxname.Text);
                c3.Parameters.AddWithValue("p2", textBoxfamily.Text);
                c3.Parameters.AddWithValue("p4", textBoxphone.Text);
                c3.Parameters.AddWithValue("p3", textBoxaddress.Text);
                c3.Parameters.AddWithValue("p5", Copypic(pictureBox1.ImageLocation,textBoxphone.Text));
                c3.Connection = conn;
                c3.ExecuteNonQuery();
                fillgred();
                setcur(beforcurrent);
                textBoxaddress.ReadOnly = true;
                textBoxfamily.ReadOnly = true;
                textBoxname.ReadOnly = true;
                textBoxphone.ReadOnly = true;
                btnbrowse.Enabled = false;
                btnedit.Text = "edit";


            }
            


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string a;
            if (textBoxsearchfor == null)
                return;
            a = "select * from tbltel where " + comboBoxsearched.Text + " like '" + textBoxsearchfor.Text + "%'";
            fillgred(a);
        }

        private void textBoxsearchfor_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }
        void setcur(int cur)
        {
            if (cur > cr.Count || cur < 0)
                return;
            cr.Position = cur;
            dataGridView1.CurrentCell = dataGridView1.Rows[cur].Cells[dataGridView1.CurrentCell.ColumnIndex];
           
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            setcur(dataGridView1.CurrentCell.RowIndex);
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = openFileDialog1.ShowDialog();
            if (x == DialogResult.Cancel)
                return;
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.SizeMode==PictureBoxSizeMode.StretchImage)
            {
                 x = pictureBox1.Region;
                
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
               
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                 x=pictureBox1.Region;
            }
        }

        private string Copypic (string source,string key)
        {
            string curpath;
            string newpath;
            curpath = Application.StartupPath + @"\images";
            if (Directory.Exists(curpath) == false)
                Directory.CreateDirectory(curpath);
            newpath = curpath + key + source.Substring(source.LastIndexOf("."));
            if (File.Exists(newpath))
                return "";
             File.Copy(source, newpath);
            return newpath;


        }
    }
}
