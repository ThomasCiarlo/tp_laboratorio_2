using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;


namespace Clases_Instanciables
{
    public class Alumno : Universitario
    {
        private Universidad.EClases clasesQueToma;
        private EEstadoDeCuenta estadoDeCuenta;

        public enum EEstadoDeCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #region Constructores

        public Alumno() { }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesQueToma = clasesQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoDeCuenta estadoCeunta) : this(id, nombre, apellido, dni, nacionalidad, clasesQueToma)
        {
            this.estadoDeCuenta = estadoCeunta;
        }

        #endregion

        #region Metodos

        protected override string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder(base.MostrarDatos());
            texto.Append($"{this.ParticiparEnClase()}\nEstado de cuenta{this.estadoDeCuenta}");

            return texto.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append($"Toma clases de: {this.clasesQueToma}");

            return texto.ToString();
        }

        #endregion

        #region SobreCargas

        public static bool operator ==(Alumno alumno, Universidad.EClases clases)
        {

            bool todoOk = false;

            if (alumno.clasesQueToma == clases && (alumno.estadoDeCuenta != EEstadoDeCuenta.Deudor))
            {

                todoOk = true;
            }

            return todoOk;
        }

    

        public static bool operator !=(Alumno alumno, Universidad.EClases clases) {

            return !(alumno == clases);
        }


        #endregion



    }
}
