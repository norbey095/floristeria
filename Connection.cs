using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace trabajo_final
{
    internal class Connection
    {
        public MySqlConnection con;
        public long insert_id;
        public Connection()
        {
            try
            {
                MySqlConnectionStringBuilder b = new MySqlConnectionStringBuilder();
                b.Server = "localhost";
                b.UserID = "root";
                b.Password = "";
                b.Database = "floristeria";
                con = new MySqlConnection(b.ToString());
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }

        }
        public void execute(string sql)
        {
            MySqlCommand cmd = this.con.CreateCommand();
            cmd.CommandText = sql;
            this.con.Open();
            cmd.ExecuteNonQuery();
            this.con.Close();
            this.insert_id = cmd.LastInsertedId;
        }
    }
}
