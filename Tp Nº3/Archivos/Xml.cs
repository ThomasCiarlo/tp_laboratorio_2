using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
  public class Xml<T> : IArchivo<T>
  {
    public bool Guardar(string archivo, T dato)
    {
      return true;
    }

    public bool Leer(string archivo,out T datos)
    {
      T dato;

      datos = default(T);

      return true;
    }



  }
}
