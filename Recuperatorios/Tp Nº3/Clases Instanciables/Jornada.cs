using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.IO;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clases;
        private Profesor instructor;

        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }
        public Universidad.EClases Clases { get { return this.clases; } set { this.clases = value; } }
        public Profesor Instructor { get { return this.instructor; } set { this.instructor = value; } }


        #region Constructor

        public Jornada()
        {

            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clases, Profesor instructor) : this()
        {
            this.clases = clases;
            this.instructor = instructor;

        }

        #endregion

        #region Metodos


        public static bool Guardar(Jornada jornada)
        {
            Texto guardar = new Texto();
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "texto.txt";
            bool rtnVal;

            try
            {
                rtnVal = guardar.Guardar(archivo, jornada.ToString());
            }
            catch (Excepciones.ArchivosException)
            {
                rtnVal = false;
            }

            return rtnVal;
        }

        public static string Leer()
        {
            Texto reader = new Texto();
            string archivo = AppDomain.CurrentDomain.BaseDirectory + "texto.txt";
            string datos = "";

            try
            {
                reader.Leer(archivo, out datos);
            }
            catch (Excepciones.ArchivosException)
            {
                datos = "No pudo leerse";
            }

            return datos;
        }

        #endregion

        #region SobreCarga

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool todoOk = false;

            foreach (Alumno c in j.alumnos)
            {
                if (c.DNI == a.DNI)
                {
                    todoOk = true;

                }

            }

            return todoOk;

        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static bool operator +(Jornada j, Alumno a)
        {
            bool todoOk = false;

            if (j != a)
            {
                j.alumnos.Add(a);
                todoOk = true;
            }

            return todoOk;

        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Clase de {this.clases} Por {this.instructor.ToString()}\n");

            foreach (Alumno a in this.alumnos)
            {
                texto.AppendLine($"{a.ToString()}\n");
            }

            texto.AppendLine("< ------------------------------------------------------------------>");

            return texto.ToString();

        }

        #endregion
    }
}
