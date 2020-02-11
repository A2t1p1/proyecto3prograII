using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3prograII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblM1.Text = "";
            lblM5.Text = "";
            lblM10.Text = "";
            lblM25.Text = "";
            lblB1.Text = "";
            lblB5.Text = "";
            lblB10.Text = "";
            lblB20.Text = "";
            lblB50.Text = "";
            lblB100.Text = "";

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            double Cantidad, cantidadTotal, cantidadPagar;
            int B100 = 0, B50 = 0, B20 = 0, B10 = 0, B5 = 0, B1 = 0, M25 = 0, M10 = 0, M5 = 0, M1 = 0;

            string valortotal, valorpagar;

            valortotal = txtCantidad.Text;
            valorpagar = txtpagar.Text;

            cantidadTotal = double.Parse(valortotal);
            cantidadPagar = double.Parse(valorpagar);

            Cantidad = cantidadTotal - cantidadPagar;


            if (Cantidad >= 100)
            {
                B100 = (int)(Cantidad / 100);
                Cantidad = (Cantidad - (B100 * 100)); 
                label11.Visible = true;
                lblB100.Text = Convert.ToString(B100);
            }
            if (Cantidad >= 50)
            {
                B50 = (int)(Cantidad / 50);
                Cantidad = (Cantidad - (B50 * 50));
                label10.Visible = true;
                lblB50.Text = Convert.ToString(B50);
            }
            if (Cantidad >= 20)
            {
                B20 = (int)(Cantidad / 20);
                Cantidad = (Cantidad - (B20 * 20));
                label9.Visible = true;
                lblB20.Text = Convert.ToString(B20);
            }
            if (Cantidad >= 10)
            {
                B10 = (int)(Cantidad / 10);
                Cantidad = (Cantidad - (B10 * 10));
                label8.Visible = true;
                lblB10.Text = Convert.ToString(B10);
            }
            if (Cantidad >= 5)
            {
                B5 = (int)(Cantidad / 5);
                Cantidad = (Cantidad - (B5 * 5));
                label7.Visible = true;
                lblB5.Text = Convert.ToString(B5);
            }
            if (Cantidad >= 1)
            {
                B1 = (int)(Cantidad / 1);
                Cantidad = (Cantidad - (B1 * 1));
                label6.Visible = true;
                lblB1.Text = Convert.ToString(B1);
            }
            if (Cantidad >= 0.25)
            {
                M25 = (int)(Cantidad / 0.25);
                Cantidad = (Cantidad - (double)(M25 * 0.25));
                label5.Visible = true;
                lblM25.Text = Convert.ToString(M25);
            }
            if (Cantidad >= 0.10)
            {
                M10 = (int)(Cantidad / 0.10);
                Cantidad = (Cantidad - (double)(M10 * 0.10));
                label4.Visible = true;
                lblM10.Text = Convert.ToString(M10);
            }
            if (Cantidad >= 0.05)
            {
                M5 = (int)(Cantidad / 0.05);
                Cantidad = (Cantidad - (double)(M5 * 0.05));
                label3.Visible = true;
                lblM5.Text = Convert.ToString(M5);
            }
            if (Cantidad >= 0.01)
            {
                M1 = (int)(Cantidad / 0.01);
                label2.Visible = true;
                lblM1.Text = Convert.ToString(M1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int cantidad = int.Parse(textBox1.Text);

            ulong a = 0;
            ulong b = 1;
            ulong c = 1;
            listBox1.Items.Add(a.ToString());
            for (int i = 0; i < cantidad; i++)
            {
                listBox1.Items.Add(a.ToString());
                a = b;
                b = c;
                c = a + b;
            }
        }

        private void btnsaber_Click(object sender, EventArgs e)
        {
            int residuo, numero, valor = 1;
            numero = int.Parse(txtbox.Text);
            residuo = numero % valor++;
            if (numero % valor != 0)
            {
                lbl4.Text = numero + " si es primo";
            }
            else
            {
                lbl4.Text = numero + " no es primo";
            }
        }
    }
    
}
