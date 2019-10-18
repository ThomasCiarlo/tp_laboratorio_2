using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jordanas;
        private List<Profesor> profesores;

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD

        }

        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }
        public List<Profesor> Instructores { get { return this.profesores; } set { this.profesores = value; } }
        public List<Jornada> Jornadas { get { return this.jordanas; } set { this.jordanas = value; } }

        public Jornada this[int i]
        {
            get { return this.jordanas[i]; }
            set { this.jordanas[i] = value; }
        }

        #region Constructor

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jordanas = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        #endregion

        #region Metodos

        public bool Guarda(Universidad uni)
        {

            return true;
        }

        public bool Leer()
        {

            return true;
        }

        private static string MostrarDatos(Universidad uni) {

            StringBuilder texto = new StringBuilder();

            foreach (Jornada j in uni.jordanas)
            {
                texto.Append($"{j.ToString()}\n");
            }

            return texto.ToString();

        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }



        #endregion

        #region SobreCarga

        public static bool operator ==(Universidad uni, Alumno a) {

            bool todoOk = false;

            foreach (Alumno c in uni.alumnos) {

                if (a.DNI == c.DNI && a.Apellido == c.Apellido) {
                    todoOk = true;
                }

            }
            return todoOk;
        }

        public static bool operator !=(Universidad uni, Alumno a) {

            return !(uni == a);

        }

        public static Profesor operator ==(Universidad uni, EClases clases) {

            Profesor p = null;

            foreach (Jornada j in uni.jordanas) {

                if (j.Clases == clases) {

                    p = j.Instructor;
                }

            }

            return p;

        }

        public static Profesor operator !=(Universidad uni, EClases clases) {

            if (uni is clases) {
                
            }

            //Terminar este metodo y los que restan

        }

        #endregion



    }
}
