using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_V01bis
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblSaludo.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "¡¡¡Hola mundo WinForm!!!";
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            this.Text = "Saludos desde un form";
            this.lblSaludo.Visible = false;
        }
    }
}
