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
    public partial class Singup : Form
    {
        private Usuario obj;
        public Singup()
        {
            InitializeComponent();
        }
        //boton de salir del signup
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }
        //boton aceptar
        /*valida que todos los datos esten llenos
         * y manda a llamar al arreglo de usuario para agragar uno nuevo
         * si no esta llenos infoma que tiene que llenar todos los campos
         * 
        */ 
        private void button1_Click(object sender, EventArgs e)
        {
            //1 diputado, 2 asesor   
            int job = 0;
            int allright = 0;
            if (radioButton1.Checked == true)
            {
                job = 1;
                allright++;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
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
            if (allright == 2)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&  textBox4.Text != "" ) {
                    allright = 0;
                    obj = new Usuario(textBox1.Text, textBox2.Text, textBox3.Text, job, textBox4.Text);
                    Goathemala.addPolitico(obj);
                    this.Hide();
                    leyes main = new leyes();
                    main.tabControl1.SelectTab(6);
                    main.Show();
                }
                else
                {
                    textBox6.Text = "revise que todos los datos esten bien";
                }

            }
            else
            {
                textBox6.Text = "revise que todos los datos esten bien";
            }
        }

        private void Singup_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
