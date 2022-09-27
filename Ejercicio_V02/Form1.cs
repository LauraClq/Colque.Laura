using BibliotecRegistro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_V02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtName.Text;
            string direccion = this.txtStreet.Text;
            int edad = (int)nudEdad.Value;
            string[] cursos = CargarCursos();
            string genero = GeneroSelecionado();
            int paisSeleccionado = lstPaises.SelectedItems.Count;

            Ingresante unIngresante = new Ingresante(nombre, direccion, genero, lstPaises.Text,cursos,edad);
            
            if (ValidarDatosIngresados(nombre, direccion, genero, paisSeleccionado))
            {
                MessageBox.Show(unIngresante.Mostrar(),"Informacion del Ingresante", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar datos","Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        private string[] CargarCursos()
        {
            string[] cursos = new string[3];

            if (chckCplusplus.Checked == true)
            {
                cursos[0] = "C++";
            }
            if (chkCshirp.Checked == true)
            {
                cursos[1] = "C#";
            }
            if (chckJava.Checked == true)
            {
                cursos[2] = "JavaScrip";
            }

            return cursos;
        }

        private string GeneroSelecionado()
        {
            string genero = "";

            if (rdoFemenino.Checked == true)
            {
                genero = "Femenino";
            }
            if (rdoMasculino.Checked == true)
            {
                genero = "Masculino";
            }
            if (rdoNoBianrio.Checked == true)
            {
                genero = "No binario";
            }

            return genero;
        }

        private static bool ValidarDatosIngresados(string nombre, string direccion, string genero, int pais)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(direccion) || genero == "" || pais == 0)
            {
                return false; 
            }

            return true; //es porque completo los campos
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nudEdad.Value = 18;
            this.nudEdad.Minimum = 18;
            this.nudEdad.Maximum = 30;

            lstPaises.Items.Add("Argentina");
            lstPaises.Items.Add("Chile");
            lstPaises.Items.Add("Uruguay");
        }
    }
}
