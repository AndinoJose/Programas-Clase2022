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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {


           int numero = Convert.ToInt32(textBox1);
           //Vectores
         int [] arreglo1 = new int [5];
            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 30;
            arreglo1[3] = 60;
            arreglo1[4] = 80;

            int[] arreglo2 = new int[2]; //{ 41, 8, 9, 100, 20, 40 };

            int[] arreglo3 = new int[] { 2, 3, 8, 9, 5 };

            int[] arreglo4 = { 5, 6, 7, 8, 9 , 8 , 200 };

            string[] arreglo5 =  {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

           
            for (int i = 0; i < arreglo2.Length; i++)
            {
                numero = textBox1.Text.ToString().Length;    
            }

            //for (int i = 0; i < arreglo5.Length; i++)
            //{
            //   listBox1.Items.Add(arreglo5[i]);
            //}

            //foreach (string item in arreglo5)
            //{
            //    listBox1.Items.Add(item);
            //}

            //foreach (int item in arreglo4)
            //{
            //    listBox2.Items.Add(item);

            //}



        }

        private void Arreglos_Load(object sender, EventArgs e)
        {

        }
    }
}
