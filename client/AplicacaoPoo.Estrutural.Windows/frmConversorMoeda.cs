using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmConversorMoeda : Form
    {
        public frmConversorMoeda()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
            
            //Coloca os valores da nossa classe dentro do combobox.
            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoedas.DataSource = list; 
            cmbMoedas.SelectedIndex = 0;          
        }

        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorEmDolar.Text == "") return;

                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);

                var moeda = new ConverterMoedaService();
                var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtValorEmDolar.Focus();
            }
        }

        private void cmbMoedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region MEU PROGRAMA
            //Atalho para comentar código CTRL + K + C
            //Atalho para descomentar o código CTRL + K + U
            if (txtValorEmDolar.Text == "") return;

            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moedaService = new ConverterMoedaService();
            switch (cmbMoedas.SelectedValue)
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = 
                            moedaService.ConverterDolarEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido =
                            moedaService.ConverterEuroEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Libra:
                    {
                        var valorConvertido =
                            moedaService.ConverterLibraEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libra} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                default:
                    break;
            }
            #endregion

            #region PROGRAMA TOP DAS GALAXIA DO PROFESSOR

            #endregion
        }
    }
}