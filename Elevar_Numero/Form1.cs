using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevar_Numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Numero = int.Parse(textBox1.Text);
            double Potencia = int.Parse(textBox2.Text);
            double Resultado;
            Resultado = Math.Pow(Numero,Potencia);
            listBox1.Items.Add(Resultado);
        }
    }
}
