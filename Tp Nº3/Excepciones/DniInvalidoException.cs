using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public class DniInvalidoException : Exception
  {
    private static string mensajeBase = "El dni contiene un string";

    public DniInvalidoException() : this(DniInvalidoException.mensajeBase , null) { }

    public DniInvalidoException(Exception e) : this(DniInvalidoException.mensajeBase, e) { }

    public DniInvalidoException(string mensaje) : this(DniInvalidoException.mensajeBase, null) { }

    public DniInvalidoException(string mensaje, Exception e) : base(DniInvalidoException.mensajeBase, e) { }

  }
}
