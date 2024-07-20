using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace trabajo_final
{
    public partial class Login : Form
    {
        private String connstring = "database = floristeria;Server=localhost;User id = root; password =";
        public string usuario { get { return txtusu.Text; } }
        public string clave { get { return txtcontra.Text; } }
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
        }

        private void Btningresar_Click(object sender, EventArgs e)
        {

            string usuario = txtusu.Text;
            string clave = txtcontra.Text;

            if (VerificarCredenciales(usuario, clave))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo nuevamente.");
            }


        }
        public bool VerificarCredenciales(string usuario, string clave)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM usuario WHERE ced_usu = @123 AND nom_usu = @camilo";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cod_usu", 123);
                    cmd.Parameters.AddWithValue("@nom_usu", "camilo");

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
    
}
