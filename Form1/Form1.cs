using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Formulario";
            this.BackColor = Color.Fuchsia;

            if (MessageBox.Show("Desea salir?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy un evento","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            this.button1.BackColor = Color.Coral;

            string texo = this.textBox1.Text;

            this.Text += texo; //acumulo en el texto

            this.listBox1.Items.Add(this.textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            //sender representa el objeto que provoco el evento
        }
    }
}
