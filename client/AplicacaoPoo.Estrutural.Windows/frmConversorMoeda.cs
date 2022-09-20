﻿using System;
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
            var cotacaoDolar = decimal.Parse(txtCotacaoDolar.Text);
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

            var valorConvertido = cotacaoDolar * valorEmDolar;

            MessageBox.Show("Valor convertido em real é: " + valorConvertido,
                "Resultado da conversão de Dolar para Real");
        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtCotacaoDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtCotacaoDolar.Focus();
                throw;
            }
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValorEmDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtValorEmDolar.Focus();
                throw;
            }
        }
    }
}
