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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.lbName.Text = "Nombre";
            this.lbLastName.Text = "Apellido";
            this.lbMateria.Text = "Materia favorita";
            this.btnSaludar.Text = "Saludar";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = $"Hola, Windows Form!";
            string mensaje = $"Soy {this.txtName.Text} {this.txtLastName.Text} y mi materia favorita es {this.cmbMateria.Text}";

            if (!ValidarCampos()) //si No me devuleve ningun true es poruqe no hay ningun campo vacio
            {
                //es decir devuelve true si hay campos null o con espacio, de lo contraio false
                Form2 saludar = new Form2(titulo,mensaje);
                saludar.ShowDialog();
            }
            
        }

        private bool ValidarCampos()
        {
            bool vacio = false;
            StringBuilder mostrar = new StringBuilder($"Se deben completar los siguientes campos: ");

            if (String.IsNullOrWhiteSpace(this.txtName.Text))
            {
                vacio = true;
                mostrar.AppendLine("Nombre");
            }
            else
            {
                if (String.IsNullOrWhiteSpace(this.txtLastName.Text))
                {
                    vacio = true;
                    mostrar.AppendLine("Apellido");
                }
            }

            if (vacio)
            {
                MessageBox.Show(mostrar.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return vacio;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.SelectedIndex = 0;
           
        }
    }
}
