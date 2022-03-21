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
    public partial class FuncionesAsincronas : Form
    {
        public FuncionesAsincronas()
        {
            InitializeComponent();
        }

        private void Hornearbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "La Pizza esta lista";


        }

        private void HornearPizza()
        {
        }


    }
}
