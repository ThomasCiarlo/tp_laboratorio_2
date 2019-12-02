using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace Clases_Instanciables
{
  public class Alumno : Universitario
  {
    private Universidad.EClases clasesQueToma;
    private EEstadoCuenta estadoDeCuenta;

    public enum EEstadoCuenta
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

    public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clasesQueToma, EEstadoCuenta estadoCeunta) : this(id, nombre, apellido, dni, nacionalidad, clasesQueToma)
    {
      this.estadoDeCuenta = estadoCeunta;
    }

    #endregion

    #region Metodos


    protected override string MostrarDatos()
    {
      StringBuilder texto = new StringBuilder(base.MostrarDatos());
      texto.AppendLine($"Estado de cuenta: {this.estadoDeCuenta}");
      texto.AppendLine($"{this.ParticiparEnClase()}");

      return texto.ToString();
    }

    public override string ToString()
    {
      return this.MostrarDatos();
    }

    protected override string ParticiparEnClase()
    {
      StringBuilder texto = new StringBuilder();
      texto.Append($"CLASES DEL DIA: {this.clasesQueToma}\n");

      return texto.ToString();
    }

    #endregion

    #region SobreCargas

    public static bool operator ==(Alumno alumno, Universidad.EClases clases)
    {

      bool todoOk = false;

      if (alumno.clasesQueToma == clases && (alumno.estadoDeCuenta != EEstadoCuenta.Deudor))
      {
        todoOk = true;
      }

      return todoOk;
    }



    public static bool operator !=(Alumno alumno, Universidad.EClases clases)
    {

         return alumno.clasesQueToma != clases;
    }


    #endregion



  }
}
