using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTGiamSat2.Service1 st = new HTGiamSat2.Service1();
            string ID = textBox1.Text;
            DataTable slist = st.Camera(ID);
            dataGridView1.DataSource = slist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HTGiamSat2.Service1 st = new HTGiamSat2.Service1();
            string ID = textBox2.Text;
            DataTable slist = st.ViTri(ID);
            dataGridView2.DataSource = slist;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
