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
            comboBox3.Items.Add("Creacion");
            comboBox3.Items.Add("Modificacion");
            comboBox3.Items.Add("Eliminacion");
            comboBox3.Items.Add("Prestar");
            comboBox3.Items.Add("Devolución");

            comboBox2.Items.Add("Creacion");
            comboBox2.Items.Add("Modificacion");
            comboBox2.Items.Add("Eliminacion");
            comboBox2.Items.Add("Prestar");
            comboBox2.Items.Add("Devolución");

            comboBox3.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            leys[numleyes] = new Ley();
            leys[numleyes].addLey(textBox1.Text, textBox2.Text);
            numleyes++;
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Ley creada con exito");
        }
        //boton de cancelar 
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
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
        //boton de salida, regresa al login
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ley = comboBox3.SelectedIndex;
            switch (ley)
            {
                case 0://creacion                    
                    tabControl1.SelectTab(0);
                    break;
                case 1://modificacion 
                    addPosiblesCambios();
                    tabControl1.SelectTab(1);
                    break;
                case 2:// eliminacion                    
                    tabControl1.SelectTab(2);
                    break;
                case 3://prestar                    
                    tabControl1.SelectTab(3);
                    break;
                case 4://devolver                    
                    tabControl1.SelectTab(4);
                    break;
                default:
                    break;
            }
            comboBox3.SelectedIndex = -1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            showLeyes();
            tabControl1.SelectTab(5);
        }
        public void showLeyes()
        {
            int cont = 1;
            string cadena = "";
            for (int i = 0; i < numleyes; i++)
            {
                listBox1.Items.Add("Ley No. " + cont);
                listBox1.Items.Add("Titulo: " + leys[cont - 1].getTitulo());
                listBox1.Items.Add("Descripción: " + leys[cont - 1].getInfo());
                cont++;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        public void addPosiblesCambios()
        {
            for (int i = 0; i < numleyes; i++)
            {
                comboBox1.Items.Add(leys[i].getTitulo());
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                        
        }
    }
}
