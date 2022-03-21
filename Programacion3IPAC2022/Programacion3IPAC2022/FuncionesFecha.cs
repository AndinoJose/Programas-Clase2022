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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void procesarbutton_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker.Value;


            diaTexBox.Text = fecha.Day.ToString();
            mestextBox.Text = fecha.Month.ToString();
            añotextBox.Text= fecha.Year.ToString();

            DiaenletrastextBox.Text= fecha.ToString("dddd");
            MesenletrastextBox.Text = fecha.ToString("MMMM");

            //sumar dias 
            sumardiastextBox.Text=fecha.AddDays(25).ToShortDateString();

            edadtextBox.Text = DevolverEdad(fecha).ToString();
            


        }



        private int DevolverEdad(DateTime _fechadenacimiento)
        {
            DateTime fechadenacimineto = _fechadenacimiento;
            DateTime fechaactual = DateTime.Now;

            int edad = 0;
            if (fechadenacimineto>fechaactual)
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la fecha actual");
                
                return 0;
            }
            {
                edad = fechaactual.Year - fechadenacimineto.Year;
                if (fechadenacimineto.Month > fechaactual.Month) ;
                {
                    --edad;
                }
            }


            return edad;

        }


        private void FuncionesFecha_Load(object sender, EventArgs e)
        {

        }




    }
}
