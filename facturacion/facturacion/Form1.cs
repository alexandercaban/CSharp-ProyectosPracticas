using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deta;
            int cod, cant, valun, iva;

            cod = int.Parse(textBox1.Text);
            cant = int.Parse(textBox2.Text);
            deta = textBox3.Text;
            valun = int.Parse(textBox4.Text);
            iva = int.Parse(textBox5.Text);
            int valto = valun + cant;

            dataGridView1.Rows.Add(cod, cant, deta, valun, iva, valto);
        }
    }
}
