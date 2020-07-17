using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_hat_spa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Pizzas_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_P_Click(object sender, EventArgs e)
        {

        }

        private void Familiar_P_CheckedChanged(object sender, EventArgs e)
        {
            
        }
         
        private void Mediana_P_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Individual_P_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Bebidas_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_B_Click(object sender, EventArgs e)
        {

        }

        private void Individual_B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Familiar_B_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Pedido_Click(object sender, EventArgs e)
        {
            string input;
            if (Familiar_P.Checked== true)
            {
                input = Familiar_P.Text;
                MessageBox.Show(input);
            }
            if (Mediana_P.Checked == true)
            {
                input = Mediana_P.Text;
                
            }
            if (Individual_P.Checked == true)
            {
                input = Individual_P.Text;
                MessageBox.Show(input);
            }
            if (Individual_B.Checked == true)
            {
                input = Individual_B.Text;
                MessageBox.Show(input);
            }
            if (Familiar_B.Checked == true)
            {
                input = Familiar_B.Text;
              MessageBox.Show(input);
            }
            this.Close();
        }

        private void Cerrar_Caja_Click(object sender, EventArgs e)
        {
            string input;
            if (Familiar_P.Checked == true)
            {
                Familiar_P.Text = "22000";
                input = Familiar_P.Text;
                MessageBox.Show(input);
            }
            if(Mediana_P.Checked==true)
            {
                Mediana_P.Text = "12000";
                input = Mediana_P.Text;
                MessageBox.Show(input);
            }
            if(Individual_P.Checked==true)
            {
                Individual_P.Text = "8000";
                input = Individual_P.Text;
                MessageBox.Show(input);
            }
            if(Individual_B.Checked==true)
            {
                Individual_B.Text = "1500";
                input = Individual_B.Text;
                MessageBox.Show(input);
            }
            if(Familiar_B.Checked ==true)
            {
                Familiar_B.Text = "5000";
                input = Familiar_B.Text;
                MessageBox.Show(input);
            }
            MessageBox.Show("Gracias,adios");
            this.Close();
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void Total_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
