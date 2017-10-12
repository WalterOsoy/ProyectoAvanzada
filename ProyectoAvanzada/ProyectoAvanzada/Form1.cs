using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAvanzada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*boton de login
         * captura los datos
         * valida bajo una condicion booleana
         *
       */
        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            bool permitir = false;
            permitir = Goathemala.find(user, password);
            textBox1.Clear();
            textBox2.Clear();
            if (permitir == true)
            {
                this.Hide();
                Principal obj = new Principal();
                obj.Show();
            }
            else
            {
                textBox3.Text = "datos invalidos";
            }            
        }
        //boton de sign up 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singup sign = new Singup();
            sign.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
