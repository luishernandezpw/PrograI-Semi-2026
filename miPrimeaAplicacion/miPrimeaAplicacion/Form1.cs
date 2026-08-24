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
        double media(double[] serie){
            double suma = 0;
            for (int i = 0; i < serie.Length; i++){
                suma += serie[i];
            }
            double media = suma / serie.Length;
            return media;
        }
        double varianza(double[] serie, double media) {
            return serie.Average(n => Math.Pow(n - media, 2));
        }
        double desviacionTipica(double[] serie, double media){
            return Math.Sqrt(varianza(serie, media));
        }
        double armonica(double[] serie) {
            int n = serie.Length;
            return n / serie.Sum(x=>1/x);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            limpiar();
            String[] serie = txtSerie.Text.Split(',');
            double[] miSerie = serie.Select(n=>double.Parse(n)).ToArray();
            double m = media(miSerie);

            ltsValores.Items.Add("La media es: " + m);
            ltsValores.Items.Add("La desviacion estandar: " + varianza(miSerie, m));
            ltsValores.Items.Add("La desviacion tipica: "+ desviacionTipica(miSerie, m));
            ltsValores.Items.Add("La media armonica: " + armonica(miSerie));
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
