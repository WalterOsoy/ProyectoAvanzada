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
    public partial class leyes : Form
    {        
        public Ley[] leys = new Ley[100];
        private int numleyes; 
        public leyes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            leys[numleyes] = new Ley ();
            leys[numleyes].addLey(textBox1.Text, textBox2.Text);
            numleyes++;
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Ley creada con exito");
        }
        //boton de cancelar 
        private void button2_Click(object sender, EventArgs e)
        {
            Principal main = new Principal();
            main.Show();
            this.Close();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void leyes_Load(object sender, EventArgs e)
        {

        }
    }
}
