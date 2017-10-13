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
        //captura datos para la nueva ley t los manda a la clase Ley
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
            tabControl1.SelectTab(6);
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
        //menu de posibles opciones con el combo box de leyes
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
                    addPosibleseliminados();                   
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
        //boton de mostrar leyes
        //graga las leyes y su descripcion a un listbox
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                        
        }
        //agrega a un combo box los leyes existentes 
        public void addPosiblesCambios()
        {
            for (int i = 0; i < numleyes; i++)
            {
                comboBox1.Items.Add(leys[i].getTitulo());
            }
        }
        //boton de modificar 
        private void button4_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            if (textBox3.Text!="") {
                leys[op].setTitulo(textBox3.Text);
            }
            if (textBox4.Text != "") {
                leys[op].setInfo(textBox4.Text);
            }
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("Cambios realizados con exito");            
        }
        //agrega a un combo box los leyes para ver cual se decea eliminar 
        public void addPosibleseliminados()
        {
            for (int i = 0; i < numleyes; i++)
            {
                comboBox4.Items.Add(leys[i].getTitulo());
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }
        //Elimina una ley
        private void button10_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            leys[op].setTitulo(null);
            leys[op].setInfo(null);
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("ley eliminada con exito");
            comboBox4.SelectedIndex = -1;
            numleyes--;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
