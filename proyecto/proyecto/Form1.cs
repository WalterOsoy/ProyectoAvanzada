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
<<<<<<< HEAD
    {        
=======
    {
        public int size;
>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        
=======
>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
<<<<<<< HEAD
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
=======
            string password = textBox2.Text;            

>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
<<<<<<< HEAD
            sign.Show();            
=======
            sign.Show();
            
            size++;
                        
>>>>>>> 684caf237c61338eee419c08678957cea6c73cf1
        }
    }
}
