using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_V03bis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double importe = double.Parse(this.textBox3.Text);
            double descuento = 0;

            if (importe >= 3000 && importe <= 5000)
            {
                descuento = importe * 0.1;
                this.textBox2.Text = $"{descuento}";
                this.textBox1.Text = $"{importe - descuento}";
            }
            else if (importe > 5000)
            {
                descuento = importe * 0.2;
                this.textBox2.Text = $"{descuento}";
                this.textBox1.Text = $"{importe - descuento}";
            }
            else
            {
                this.textBox1.Text = $"{importe}";
            }
    
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Text = "Descuento recibido:";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Ingrese importe a cobrar:";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Descuento";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Text = "Total a pagar:";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox) //is me indica si la variale izquierda es del mismo tipo que la variable de la derecha, devuleve true o false
                {
                    ((TextBox)item).Clear();
                    //casteamos la variale item que es de tipo Control a formato TextBox 
                }
            }
        }
    }
}
