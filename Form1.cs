using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calcmachine;

namespace LatihanFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var a = int.Parse(textBox1.Text);
            var b = int.Parse(textBox2.Text);
            var cal = new calc();
            listBox1.Items.Add(string.Format("{0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            listBox1.Items.Add(string.Format("{0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            listBox1.Items.Add(string.Format("{0} * {1} = {2}", a, b, cal.Perkalian(a, b)));
            listBox1.Items.Add(string.Format("{0} / {1} = {2}", a, b, calc.Pembagian(a, b)));
        }
    }
}
