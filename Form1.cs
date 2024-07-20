using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_final
{
    public partial class Form1 : Form
    {
        int iterableImage = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[iterableImage];
            if (iterableImage == imageList1.Images.Count - 1)
            {
                iterableImage = 0;
            }
            else
            {
                iterableImage++;
            }
        }

        private void misionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mision a = new Mision();
            this.Hide();
            a.ShowDialog();
        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision a = new Vision();
            this.Hide();
            a.ShowDialog();
        }

        private void loguinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas a = new Ventas();
            this.Hide();
            a.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
