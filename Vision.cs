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
    public partial class Vision : Form
    {
        public Vision()
        {
            InitializeComponent();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
        }
    }
}
