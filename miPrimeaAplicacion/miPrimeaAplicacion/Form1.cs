using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Estadistica objEsta = new Estadistica();
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            limpiar();
            String[] serie = txtSerie.Text.Split(',');
            double[] miSerie = serie.Select(n=>double.Parse(n)).ToArray();
            double m = objEsta.media(miSerie);

            ltsValores.Items.Add("La media es: " + m);
            ltsValores.Items.Add("La desviacion estandar: " + objEsta.varianza(miSerie, m));
            ltsValores.Items.Add("La desviacion tipica: "+ objEsta.desviacionTipica(miSerie, m));
            ltsValores.Items.Add("La media armonica: " + objEsta.armonica(miSerie));
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            limpiar();
        }
        private void limpiar() {
            ltsValores.Items.Clear();
            //txtSerie.Clear();
        }
    }
}
