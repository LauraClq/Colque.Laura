﻿using System;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Text = "Descuento recibido:";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
    }
}
