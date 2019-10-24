using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        protected int legajo;

        #region Constructores

        public Universitario() { }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos
        protected virtual string MostrarDatos()
        {

            StringBuilder texto = new StringBuilder(base.ToString());
            texto.Append($"\nLegajo: {this.legajo}\n");

            return texto.ToString();

        }

        protected abstract string ParticiparEnClase();
        #endregion

        #region SobreCargas

        public static bool operator ==(Universitario uni1, Universitario uni2)
        {
            bool todoOk = false;

            if (uni1.DNI == uni2.DNI && uni1.legajo == uni2.legajo)
            {
                todoOk = true;

            }

            return todoOk;

        }

        public static bool operator !=(Universitario uni1, Universitario uni2) {

            return !(uni1 == uni2);

        }

        public override bool Equals(object obj)
        {
            return obj is Universitario;
        }


        #endregion





    }
}
