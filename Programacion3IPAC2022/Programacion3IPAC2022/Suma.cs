using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3IPAC2022
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void sumarbutton_Click(object sender, EventArgs e)
        {
           int num1 = Convert.ToInt32(num1textBox.Text);
           int num2= Convert.ToInt32(num2textBox.Text);

            resultadotextBox.Text = Sumar (num1,num2 ).ToString();

        }

        private int Sumar (int num1, int num2)
        {
          int  resultado = num1 + num2;
           return resultado;
          
        }
    }
}
