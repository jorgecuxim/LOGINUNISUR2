using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINUNISUR
{
    public partial class Form1 : Form
    {
        static int intentos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Necesitamos el usuario y la contraseña
            //username "jorge" password= "Barco100"
            //solo tiene derecho a 3 intentos

            string usuario = tbuser.Text;
            string password = tbcontrasena.Text;
            if (this.tbuser.Text == "jorge" && this.tbcontrasena.Text == "Barco100")
            {
                intentos = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\jorge\source\repos\LOGINUNISUR\LOGINUNISUR\unlock.jpg");
                MessageBox.Show("Bienvenido");

            }
            else if (intentos >= 0 && intentos < 3)
            {
                //avisar cuantos intentos le quedan
                
                
                intentos++;
                aviso.Text = "solo tienes" + Convert.ToString(3-intentos) + "intentos más";
                
            }
            else 
            {

                aviso.Text = "YA NO TIENES MAS INTENTOS ";
                login.Enabled = false;
                tbuser.Enabled = false;
                tbcontrasena.Enabled = false;
                pictureBox1.Image = new Bitmap(@"C:\Users\jorge\source\repos\LOGINUNISUR\LOGINUNISUR\accesodenegado.png");


                /*MessageBox.Show("Usuario o contraseña incorrecta");

                intentos = intentos + 2 ;
                intentos--;
                intentos = intentos + 2;
                intentos--;
                intentos = intentos + 1;*/





            }

        }
    }
}
