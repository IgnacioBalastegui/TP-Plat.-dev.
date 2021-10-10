using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Usuario
    {
        private String nombre;
        private String contraseña;

        public Usuario(String nombre, String contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
