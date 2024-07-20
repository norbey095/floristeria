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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
        }

        private void Btnregistrar_Click(object sender, EventArgs e)
        {
            Cliente pcliente = new Cliente();
            pcliente.cedula = int.Parse(txtcedreg.Text);
            pcliente.Nombre = txtnomreg.Text.Trim();
            pcliente.Apellido = txtapereg.Text.Trim();
            pcliente.direccion = txtdirereg.Text.Trim();
            pcliente.telefono = txttelreg.Text.Trim();
            pcliente.ciudad = txtcuireg.Text.Trim();

            int resultado = clientesdal.Agregar(pcliente);
            if (resultado > 0)
            {
                MessageBox.Show("cliente guardado con exito", "quedo almacenado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no se pudo guardar", "falto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtcedreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btninhab_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = clientesdal.Eliminar(txtcedinha.Text);
            dataGridView2.DataSource = clientesdal.Mostrar();
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            Cliente pcliente = new Cliente();
            pcliente.cedula = int.Parse(txtcedmodi.Text);
            pcliente.Nombre = txtnommodi.Text;
            pcliente.Apellido= txtapemodi.Text;
            pcliente.direccion = txtdiremodi.Text;
            pcliente.telefono = txttelemodi.Text;
            pcliente.ciudad = txtciumodi.Text;

            int resultado = clientesdal.Modificar (pcliente);

            if (resultado > 0)
            {
                MessageBox.Show("cliente Actualizado con exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcedmodi.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar el cliente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridmostrar.DataSource = clientesdal.Mostrar();
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            List<Cliente> clienteList = clientesdal.Buscar(txtcedbus.Text);
            txtnombus.Text = clienteList.First().Nombre;
            txtapebus.Text = clienteList.First().Apellido;
            txtdirebus.Text = clienteList.First().direccion;
            txttefebus.Text = clienteList.First().telefono;
            txtcuibus.Text = clienteList.First().ciudad;

        }

        private void btnbuscarnuevo_Click(object sender, EventArgs e)
        {
            txtcedbus.Text = "";
            txtnombus.Text = "";
            txtapebus.Text = "";
            txtdirebus.Text = "";
            txttefebus.Text = "";
            txtcuibus.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> clienteList = clientesdal.Buscar(txtcedmodi.Text);
            txtnommodi.Text = clienteList.First().Nombre;
            txtapemodi.Text = clienteList.First().Apellido;
            txtdiremodi.Text = clienteList.First().direccion;
            txttelemodi.Text = clienteList.First().telefono;
            txtciumodi.Text = clienteList.First().ciudad;
        }
    }
    
}
