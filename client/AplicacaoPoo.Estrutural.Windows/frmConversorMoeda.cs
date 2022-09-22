using AplicacaoPoo.Dominio.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmConversorMoeda : Form
    {
        public frmConversorMoeda()
        {
            InitializeComponent();
            btnConverterEmReal.Enabled = false;
        }

        private void btnConverterEmReal_Click(object sender, EventArgs e)
        {
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            
            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
            
            //string interpolation
            MessageBox.Show($"Valor convertido é: {resultado} reais");
        }


        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorEmDolar.Text == "")
                {
                    btnConverterEmReal.Enabled = false
                        ;
                    return;
                };

                var resultado = decimal.Parse(txtValorEmDolar.Text);
                btnConverterEmReal.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtValorEmDolar.Focus();
                btnConverterEmReal.Enabled = false;
            }
        }
    }
}