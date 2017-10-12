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
    public partial class Principal : Form
    {
        public leyes leyes = new leyes();
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //boton de slaida del menu principal
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Creacion");
            comboBox1.Items.Add("Modificacion");
            comboBox1.Items.Add("Eliminacion");
            comboBox1.Items.Add("Prestar");
            comboBox1.Items.Add("Devolución");

            comboBox2.Items.Add("Creacion");
            comboBox2.Items.Add("Modificacion");
            comboBox2.Items.Add("Eliminacion");
            comboBox2.Items.Add("Prestar");
            comboBox2.Items.Add("Devolución");

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int ley = comboBox1.SelectedIndex;
            switch (ley)
            {
                case 0://creacion
                    leyes.Show();
                    leyes.tabControl1.SelectTab(0);
                    this.Close();

                    break;
                case 1://modificacion 
                    leyes.Show();
                    leyes.tabControl1.SelectTab(1);
                    this.Hide();

                    break;
                case 2:// eliminacion
                    leyes.Show();
                    leyes.tabControl1.SelectTab(2);
                    this.Hide();

                    break;
                case 3://prestar
                    leyes.Show();
                    leyes.tabControl1.SelectTab(3);
                    this.Hide();

                    break;
                case 4://devolver
                    leyes.Show();
                    leyes.tabControl1.SelectTab(4);
                    this.Hide();

                    break;
                default:
                    break;
            }                        
            comboBox1.SelectedIndex = -1;            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int reglamentos = comboBox2.SelectedIndex;
            switch (reglamentos)
            {
                case 0://creacion
               
                    break;
                case 1://modificacion 
               
                    break;
                case 2:// eliminacion
               
                    break;
                case 3://prestar

                    break;
                case 4://devolver

                    break;
                default:
                    break;
            }            
            comboBox2.SelectedIndex = -1;
        }

        //boton de ver leyes         
        private void button1_Click_1(object sender, EventArgs e)
        {
            leyes.Show();
            leyes.tabControl1.SelectTab(5);
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
