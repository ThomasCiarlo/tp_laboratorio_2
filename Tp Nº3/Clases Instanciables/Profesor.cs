using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Clases_Instanciables;

namespace Clases_Instanciables
{
  public sealed class Profesor : Universitario
  {
    private Queue<Universidad.EClases> clasesDelDia;
    private static Random random;

    #region Constructores

    public Profesor()
    {

      Profesor.random = new Random();
      this.clasesDelDia = new Queue<Universidad.EClases>();
      _randomClases();

    }

    public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
    {

    }


    #endregion

    #region Metodos

    protected override string MostrarDatos()
    {
      StringBuilder texto = new StringBuilder(base.MostrarDatos());
      texto.Append($"{this.ParticiparEnClase()}");

      return texto.ToString();
    }

    protected override string ParticiparEnClase()
    {
      StringBuilder texto = new StringBuilder("Clases del dia: ");


      foreach (Universidad.EClases c in this.clasesDelDia)
      {
        texto.Append(c + "\n");

      }
      return texto.ToString();
    }

    public override string ToString()
    {
      return this.MostrarDatos();
    }

    private void _randomClases()
    {

      this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(Enum.GetNames(typeof(Universidad.EClases)).Length));
      this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(Enum.GetNames(typeof(Universidad.EClases)).Length));

    }



    #endregion

    #region SobreCarga

    public static bool operator ==(Profesor p, Universidad.EClases clases)
    {
      bool todoOk = false;

      foreach (Universidad.EClases cla in p.clasesDelDia)
      {
        if (cla == clases)
        {

          todoOk = true;

        }
      }

      return todoOk;
    }

    public static bool operator !=(Profesor p, Universidad.EClases clases)
    {

      return !(p == clases);

    }

    #endregion

  }
}
