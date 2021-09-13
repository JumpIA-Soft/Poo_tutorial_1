using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_animales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal gato1 = new Animal();
            gato1.nombreA = nombreA.Text;
            gato1.edadA = Int32.Parse( edadA.Text);

            respuesta1.Text = "Nombre: " + gato1.nombreA + ", Edad: " + gato1.edadA;

            if(metodoA.Text == "Comer")
            {
                respuesta2.Text = gato1.comerAniaml();
            }
            else
            {
                if(metodoA.Text == "Caminar")
                {
                    respuesta2.Text = gato1.caminarAnimal();
                }
                else
                {
                    respuesta2.Text = "null";
                }
            }
        }
    }
}
