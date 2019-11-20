using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformarEstado;


        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }


        public string DireccionEntrega { get { return this.direccionEntrega; } set { this.direccionEntrega = value; } }
        public EEstado Estado { get { return this.estado; } set { this.estado = value; } }
        public string TrackingID { get { return this.trackingID; } set { this.trackingID = value; } }

        #region Constructor
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.trackingID = trackingID;
            this.direccionEntrega = direccionEntrega;
            this.estado = EEstado.Ingresado;

        }
        #endregion

        #region Metodos
        /// <summary>
        /// genera un hilo para que el paquete pueda ir cambiando de estado
        /// </summary>
        public void MockCicloDeVida()
        {

            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.estado++;
                this.InformarEstado.Invoke(this, null);                               
            }

            PaqueteDAO.Insertar(this);

        }

        /// <summary>
        /// Muestra los datos de un paquete
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {

            Paquete p = (Paquete)elemento;

            return string.Format("{0} Para {1} \n", p.trackingID, p.direccionEntrega);
        }

        #endregion

        #region SobreCarga
        /// <summary>
        /// verifica que dos paquetes no sean iguales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>retorta un bool dependiendo la respuesta</returns>
        public static bool operator ==(Paquete a, Paquete b)
        {
            return (a.trackingID == b.trackingID);

        }

        /// <summary>
        /// verifica que nos paquetes sean distintos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>retorta un bool dependiendo la respuesta</returns>

        public static bool operator !=(Paquete a, Paquete b)
        {

            return !(a == b);
        }

        /// <summary>
        /// Muestra los datos de un paquete mediante le metodo toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return MostrarDatos(this);
        }

        #endregion







    }
}
