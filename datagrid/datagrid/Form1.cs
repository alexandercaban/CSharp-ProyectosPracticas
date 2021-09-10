using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom;
            int tel;

            nom = textBox1.Text;
            tel = int.Parse(textBox2.Text);
            dataGridView1.Rows.Add(nom, tel);
         } 
    }
}
