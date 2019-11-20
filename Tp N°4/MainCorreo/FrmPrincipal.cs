using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MainCorreo
{
    public partial class FrmPrincipal : Form
    {
        Correo correo;
        public FrmPrincipal()
        {
            InitializeComponent();
            correo = new Correo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Agrega un nuevo paquete a la lista de correo, si el paqute esta repetido tira una excepcion 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textDireccion.Text != "" && maskedTrakingID.Text != "")
            {
                Paquete p = new Paquete(textDireccion.Text, maskedTrakingID.Text);

                try
                {
                    correo += p;
                    p.InformarEstado += paq_InformaEstado;
                    this.ActualizarEstado();

                }
                catch (TrackingIdRepetidoException)
                {

                    MessageBox.Show("Error, el paquete ya se encuenta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else {
                MessageBox.Show("Ingrese los datos necesarios para crear el paquete", "Creacion incorrecta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        #region metodos

        /// <summary>
        /// Actualiza los estados y los ubica en la lista que corresponda
        /// </summary>
        private void ActualizarEstado()
        {

            lstEstadoEntregado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoIngresado.Items.Clear();

            foreach (Paquete p in this.correo.Paquetes)
            {

                switch (p.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(p);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(p);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(p);
                        break;
                }

            }

        }

        /// <summary>
        /// llama al matedo actualizarEstado, y crea una instacia del delegado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {

            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {

                this.ActualizarEstado();

            }

        }

        /// <summary>
        /// muestra la informacion de un elemento
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {

            if (elemento != null)
            {
                rtbMostrar.Text += elemento.MostrarDatos(elemento);
            }

        }


        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }


        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
