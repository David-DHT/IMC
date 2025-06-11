using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1: Form
    {
        ClsIMC Calculo;
        public Form1()
        {
            Calculo = new ClsIMC();
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo.C_Estatura = float.Parse(txtEstatura.Text);
            Calculo.C_peso = float.Parse(txtPeso.Text);
            Calculo.C_zancada = float.Parse(txtZancadas.Text);
            Calculo.C_Pasos = int.Parse(txtPasos.Text);

            lblIMC.Text = "Tu IMC es de " + Calculo.CalcularIMC();
            MessageBox.Show("Tu IMC es de " + Calculo.CalcularIMC());
            var Estado = Calculo.Estado();
            MessageBox.Show(Estado.Item1);
            MessageBox.Show("La distancia recorrida fue de " + Calculo.CalcularDistancia()+"Km\n"+Calculo.C_Faltante(Estado.Item2));
            
         
        }
    }
}
