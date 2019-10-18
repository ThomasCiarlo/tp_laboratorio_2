using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        protected string apellido;
        protected int dni;
        protected string nombre;
        protected ENacionalidad nacionalidad;

        public enum ENacionalidad
        {
            Argentino,
            Extrajero
        }

        public string Nombre { get { return this.nombre; } set { this.nombre = value;  } }
        public string Apellido { get { return this.apellido; } set { this.nombre = apellido; } }
        public int DNI { get { return 1; } set { this.dni = value; } }

    }
}
