using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

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

    public static bool Guardar(Universidad uni)
    {

      Xml<Universidad> cargar = new Xml<Universidad>();
      string archivo = AppDomain.CurrentDomain.BaseDirectory + "xmlfile.xml";

      return cargar.Guardar(archivo, uni);

     
    } 

    public bool Leer()
    {

      Xml<Universidad> leer = new Xml<Universidad>();
      string archivo = AppDomain.CurrentDomain.BaseDirectory + "xmlfile.xml";
      Universidad uni = this;

      return leer.Leer(archivo, out uni);

    }

    private static string MostrarDatos(Universidad uni)
    {

      StringBuilder texto = new StringBuilder();

      texto.AppendLine("JORNADA: \n");

      foreach (Jornada j in uni.jordanas)
      {
        texto.AppendLine($"{j.ToString()}\n");
      }

      return texto.ToString();

    }

    public override string ToString()
    {
      return Universidad.MostrarDatos(this);
    }



    #endregion

    #region SobreCarga

    public static bool operator ==(Universidad uni, Alumno a)
    {

      bool todoOk = false;

      foreach (Alumno c in uni.alumnos)
      {

        if (a == c)
        {
          todoOk = true;
        }

      }
      return todoOk;
    }

    public static bool operator !=(Universidad uni, Alumno a)
    {

      return !(uni == a);

    }



    public static Profesor operator ==(Universidad uni, EClases clases)
    {
      Profesor retorno = null;

      foreach (Profesor p in uni.profesores)
      {
        if (p == clases)
        {
          retorno = p;
          break;
        }
      }

      if (retorno is null)
      {
        throw new Excepciones.SinProfesorException();
      }

      return retorno;

    }


    public static Profesor operator !=(Universidad uni, EClases clases)
    {
      Profesor retorno = null;

      foreach (Profesor p in uni.profesores)
      {
        if (p != clases)
        {
          retorno = p;
          break;
        }
      }

      return retorno;
    }

    public static Universidad operator +(Universidad uni, EClases clases)
    {
      Jornada jornadaNueva = new Jornada(clases, (uni == clases));

      foreach (Alumno a in uni.alumnos)
      {
        if (a == clases)
        {
          jornadaNueva.Alumnos.Add(a);
        }

      }

      uni.jordanas.Add(jornadaNueva);

      return uni;
    }

    public static Universidad operator +(Universidad uni, Profesor profesor)
    {
      bool todoOk = true;

      foreach (Profesor p in uni.profesores)
      {
        if (p == profesor)
        {

          todoOk = false;

        }
      }

      if (todoOk)
      {
        uni.profesores.Add(profesor);
      }

      return uni;

    }

    public static Universidad operator +(Universidad uni, Alumno a)
    {



      if (uni != a)
      {

        uni.alumnos.Add(a);

      }
      else
      {

        throw new AlumnoRepetidoException();
      }

      return uni;

    }


    #endregion



  }
}
