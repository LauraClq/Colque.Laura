using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicicio_V02bis
{
    public partial class FrmTablas : Form
    {
        public FrmTablas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Tablas";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numeroIngresado;

            if (e.KeyChar == (char)Keys.Enter)
            {
                numeroIngresado = txtNumero.Text;
                var resultadoTabla = Tablas.TablasMultiplcar(int.Parse(numeroIngresado)).Split('-');
                //Split('-') lo que hace es saltar una linea ya que devuelve como un string entero
                foreach (var numero in resultadoTabla)
                {
                    this.lstTabla.Items.Add(numero);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si presiono el boton se limpia la lista y el textBox
            this.lstTabla.Items.Clear();
            this.txtNumero.Text = "";
        }

        private void FrmTablas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea salir?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //cancel es true es porque selecciono el NO, no desea salir
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
