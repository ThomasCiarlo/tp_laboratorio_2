using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

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

        public string Nombre { get { return this.nombre; } set { this.nombre = ValidarNombreApellido(value); } }
        public string Apellido { get { return this.apellido; } set { this.apellido = ValidarNombreApellido(value); } }
        public int DNI { get { return this.dni; } set { this.dni = ValidarDni(nacionalidad, value); } }
        public ENacionalidad Nacionalidad { get { return this.nacionalidad; } set { this.nacionalidad = value; } }
        public string ToDNI { set { this.dni = ValidarDni(nacionalidad, value); } }

        #region Constructores      
        public Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this(nombre, apellido, 0, nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.dni = dni;

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.ToDNI = dni;
        }

        #endregion

        #region SobreCarga

        
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append($"Nombre: {Nombre}\nApellido: {Apellido}\nDNI: {DNI}\nNacionalidad: {Nacionalidad}");
            return texto.ToString();
        }

        #endregion

        #region Validaciones


        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {

            int retorno = 0;

            if (dato >= 1 && dato <= 99999999)
            {
                if (nacionalidad == ENacionalidad.Argentino && (dato >= 1 && dato <= 89999999))
                {
                    retorno = dato;

                }
                else if (nacionalidad == ENacionalidad.Extrajero && (dato >= 90000000 && dato <= 99999999))
                {
                    retorno = dato;

                }
                else
                {

                    throw new NacionalidadInvalidaException();
                }
            }
            else
            {

                throw new DniInvalidoException();

            }

            return retorno;

        }


        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {

            return ValidarDni(nacionalidad, Convert.ToInt32(dato));
        }

        private string ValidarNombreApellido(string dato)
        {


            string retorno = "Nombre mal ingresado";
            Regex Val = new Regex(@"^[a-zA-Z]+$");


            if (Val.IsMatch(dato))
            {
                retorno = dato;
            }

            return retorno;

        }



        #endregion





    }
}
