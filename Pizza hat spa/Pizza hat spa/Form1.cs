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

namespace Pizza_hat_spa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jeanr\OneDrive\Documentos\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)From login where textBox1='"+textBox1.Text+"' and con='"+con.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString()=="1")
            {
                 this.Hide();
                 Form2 ss = new Form2();
                 ss.Show();
            }
            else
            {
                MessageBox.Show("Por favor Ingrese tu Nombre y tu Contrasena");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void con_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
