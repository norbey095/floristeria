using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    internal class Cliente
    {
        public int cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string direccion{ get; set; }
        public string telefono { get; set; }
        public string ciudad { get; set; }
        public Cliente() { }
        public Cliente(int pcedula, string pNombre, string pApellido, string pdireccion, string ptelefono, string pciudad)
        {
            this.cedula = pcedula;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.direccion = pdireccion;
            this.telefono = ptelefono;
            this.ciudad = pciudad;
        }
    }
}
