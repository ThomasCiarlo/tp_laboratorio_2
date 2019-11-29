using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes { get { return this.paquetes; } set { this.paquetes.Add(default); } }

        #region Constructor
        public Correo() {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// finaliza todos los hilos de entregas
        /// </summary>
        public void FinEntregas() {

            foreach (Thread c in this.mockPaquetes)
            {
                if (c != null)
                {
                    if (c.IsAlive)
                    {
                        c.Abort();
                    }
                }
            }

        }

        /// <summary>
        /// Muestra los datos de los elementos
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elemento) {

            string retor = "";
            Correo c = (Correo) elemento;

            foreach (Paquete p in c.Paquetes) {

                retor += string.Format("{0} para {1} ({2})\n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            
            }

            return retor;
        }

        #endregion

        #region SobreCarga
        /// <summary>
        /// Agrega un nuevo paquete al correo
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns>retorna un correo con el nuevo paquete cargado</returns>
        public static Correo operator +(Correo c, Paquete p) {

            bool todoOk = true;

            foreach (Paquete x in c.paquetes) {

                if (p == x) {

                    todoOk = false;
                
                }
            
            }

            if (todoOk)
            {
                c.paquetes.Add(p);
                Thread t1 = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(t1);
                t1.Start();
            }
            else {
                throw new TrackingIdRepetidoException("El paquete ya existe");
            }

            return c;

            
        }

        #endregion


    }
}
