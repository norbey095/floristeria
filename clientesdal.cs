using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace trabajo_final
{
    internal class clientesdal
    {
        public static List<Cliente> Buscar(string pcedula)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select cedulausu, nombreusu, Apellidousu, direccionusu, telefonousu, ciudadusu  from usuarios where cedulausu = '{0}'", pcedula), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Cliente pcliente = new Cliente();
                pcliente.cedula = _reader.GetInt32(0);
                pcliente.Nombre = _reader.GetString(1);
                pcliente.Apellido = _reader.GetString(2);
                pcliente.direccion= _reader.GetString(3);
                pcliente.telefono = _reader.GetString(4);
                pcliente.ciudad = _reader.GetString(5);

                _lista.Add(pcliente);
            }

            return _lista;
        }
        public static int Agregar(Cliente pcliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into usuarios values ('{0}','{1}','{2}','{3}','{4}','{5}')", pcliente.cedula, pcliente.Nombre, pcliente.Apellido, pcliente.direccion, pcliente.telefono, pcliente.ciudad), bdcomun.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Cliente> Eliminar(string pcedula)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(string.Format("delete from usuarios where cedulausu = '{0}'", pcedula), bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Cliente pcliente = new Cliente();
                pcliente.cedula = _reader.GetInt32(0);
                pcliente.Nombre = _reader.GetString(1);
                pcliente.Apellido = _reader.GetString(2);
                pcliente.direccion = _reader.GetString(3);
                pcliente.telefono = _reader.GetString(4);
                pcliente.ciudad = _reader.GetString(5);

                _lista.Add(pcliente);
            }

            return _lista;
        }
        public static int Modificar (Cliente pcliente)
        {
            int resultado = 0;
            string cadena = "";
            cadena = "update usuarios set nombreusu = '{1}', Apellidousu = '{2}', direccionusu = '{3}', telefonousu = {4}, ciudadusu = '{5}' where cedulausu = {0}";
            MySqlCommand comando = new MySqlCommand(string.Format(cadena, pcliente.cedula, pcliente.Nombre, pcliente.Apellido, pcliente.direccion, pcliente.telefono, pcliente.ciudad), bdcomun.obtenerconexion());
            resultado = comando.ExecuteNonQuery();
            return resultado;
        }
        public static List<Cliente> Mostrar()
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(string.Format("select cedulausu, nombreusu, Apellidousu, direccionusu, telefonousu, ciudadusu from usuarios"),bdcomun.obtenerconexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Cliente pcliente = new Cliente();
                pcliente.cedula = _reader.GetInt32(0);
                pcliente.Nombre = _reader.GetString(1);
                pcliente.Apellido = _reader.GetString(2);
                pcliente.direccion= _reader.GetString(3);
                pcliente.telefono = _reader.GetString(4);
                pcliente.ciudad = _reader.GetString(5);

                _lista.Add(pcliente);
            }

            return _lista;
        }

    }
}
