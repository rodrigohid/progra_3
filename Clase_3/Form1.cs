using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            txtdato.Text = "Hola Mundo";
            bool content = true;
            txtBool.Text = content.ToString();
            int n = 88;
            txtnum.Text = n.ToString();
            string palabra = "palabra/string";
            txtPalabra.Text = palabra;
            int[] arreglo = { 5, 2, 3 };


            foreach (int gg in arreglo)
            {
              txt3.Text = txt3.Text + gg.ToString() + "  ";


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
