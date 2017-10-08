using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{    
    public partial class Form1 : Form
    {        

    {
        public int size;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            bool permitir = Goathemala.buscar(user, password);
            if (permitir=true)
            {
                this.Hide();
                Principal obj = new Principal();
                obj.Show();
            }
            else
            {
                textBox3.Text = "datos invalidos";
            }                       
            string password = textBox2.Text;            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();

            sign.Show();            

            sign.Show();
            
            size++;
                        

        }
    }
}
