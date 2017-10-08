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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private Usuario obj;
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1 diputado, 2 asesor   
            int job=0;
            int allright = 0;
            if (radioButton1.Checked==true)
            {
                job = 1;
                allright++;       
            }
            else 
            {
                if (radioButton2.Checked == true) {
                    job = 2;
                    allright++;
                }
                else
                {
                    textBox6.Text = "Debe de llenar todos los campos";
                }
            }
            if (textBox4.Text.Equals(textBox5.Text))
            {
                allright++;
            }
            if (allright==2)
            {
                allright = 0;                
                obj = new Usuario(textBox1.Text, textBox2.Text, textBox3.Text, job, textBox4.Text);
                Goathemala.addPolitico(obj);
                Principal main = new Principal();
                main.Show();
                this.Hide();

            }
            else
            {
                textBox6.Text = "revise que todos los datos esten bien";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
