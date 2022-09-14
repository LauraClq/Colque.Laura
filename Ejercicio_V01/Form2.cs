using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_V01
{
    public partial class Form2 : Form
    {
        public Form2(string titulo, string mensaje)
        {
            InitializeComponent();
           
            this.lbTitulo.Text = titulo;
            this.lbMensaje.Text = mensaje;

        }

    }
}
