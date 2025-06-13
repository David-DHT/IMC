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
            try
            {
                Calculo.C_Estatura = float.Parse(txtEstatura.Text);
                Calculo.C_peso = float.Parse(txtPeso.Text);
                Calculo.C_zancada = float.Parse(txtZancadas.Text);
                Calculo.C_Pasos = int.Parse(txtPasos.Text);

                lblIMC.Text = "Tu IMC es de " + Calculo.CalcularIMC();
                MessageBox.Show("Tu IMC es de " + Calculo.CalcularIMC());
                var Estado = Calculo.Estado();
                MessageBox.Show(Estado.Item1+ "\nLa distancia recorrida fue de "+Calculo.CalcularDistancia() + "Km\n" + Calculo.C_Faltante(Estado.Item2));
            }
            catch
            {
                MessageBox.Show("Error, no puedes dejar espacios en blanco");
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)// Si es digito 
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')// Si es digito 
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }

        private void txtZancadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }

        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
