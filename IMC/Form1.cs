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
