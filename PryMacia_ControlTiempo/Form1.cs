using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMacia_ControlTiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime TiempoInicio;
        bool enProceso = false;
        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            if (!enProceso)
            {
                TiempoInicio = DateTime.Now;
                enProceso = true;
                btnTrabajo.BackColor = Color.Red;
                lblTiempo.Text = "Cronometro iniciando...";
            }
            else
            {
                DateTime tiempoFin = DateTime.Now;
                TimeSpan duracion = tiempoFin - TiempoInicio;
                lblTiempo.Text = $"tiempo transcurrido: {duracion.TotalSeconds:F2}segundos";
                btnTrabajo.BackColor = Color.LightGreen;
                enProceso = false;
            }
        }
    }
}
