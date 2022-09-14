using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_V04bis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.groupBox1.Text = "Ingrese un nuevo numero";
            this.groupBox2.Text = "Orden";
            this.groupBox3.Text = "Lista de numeros";
            this.radioButton1.Text = "Ascendente";
            this.radioButton2.Text = "Descendente";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numeroIngresado;

            numeroIngresado = this.txtNumero.Text;

            this.lstNumeros.Items.Add(numeroIngresado);
            this.txtNumero.Text = ""; //se limpia el textBox
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int list = this.lstNumeros.Items.Count; //obtiene la cantidad de nuemeros que hay en la lista 
            for (int i = 0; i < list-1; i++)
            {
                for (int j = i+1; j < list; j++)
                {
                    
                    
                        //parseamos los items de la lstNumeros
                        if ( (this.radioButton1.Checked == true && int.Parse(lstNumeros.Items[i].ToString()) > int.Parse(lstNumeros.Items[j].ToString())) 
                            || (this.radioButton2.Checked == true && int.Parse(lstNumeros.Items[i].ToString()) < int.Parse(lstNumeros.Items[j].ToString())) )
                        {
                            int aux = int.Parse(lstNumeros.Items[i].ToString());
                            lstNumeros.Items[i] = lstNumeros.Items[j];
                            lstNumeros.Items[j] = aux;

                        }
                    
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*manera horrible
            this.txtNumero.Text = "";
            this.lstNumeros.Items.Clear();
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            */

            foreach (Control controlGrupBox in this.Controls)
            {
                if (controlGrupBox is GroupBox) // si el control es de tipo grupBox
                {
                    foreach (Control item in controlGrupBox.Controls)
                    {
                        if (item is ListBox lista)
                        {
                            lstNumeros.Items.Clear();
                            continue;
                        }
                        if (item is TextBox txtBox)
                        {
                            txtBox.Clear();
                            continue;
                        }
                        if (item is RadioButton radioButtton)
                        {
                            radioButtton.Checked = false;
                            continue;
                        }
                    }
                }
            }
        }
    }
}
