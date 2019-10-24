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

      this.Nombre = nombre;
      this.Apellido = apellido;
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

          throw new NacionalidadInvalidaException("el dni y la nacionalidad no coinciden");
        }
      }
      else
      {

        throw new DniInvalidoException("El dni supera el mayor numero permitido");

      }

      return retorno;

    }


    private int ValidarDni(ENacionalidad nacionalidad, string dato)
    {

      if (int.TryParse(dato, out int x))
      {

        return ValidarDni(nacionalidad, Convert.ToInt32(dato));
      }
      else
      {
        throw new DniInvalidoException("El dni contiene un string");
      }
    }

    private string ValidarNombreApellido(string dato)
    {


      string retorno = "Nombre incorrecto";

      if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
      {
        retorno = dato;
      }

      return retorno;

    }



    #endregion





  }
}
