using System.Data.SqlClient;

namespace CadastroDePessoas
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            string data = DateTime.Now.ToLongDateString().ToString();
            string hora = DateTime.Now.ToShortTimeString().ToString();
            labelBemVindo.Text = data + " " + hora;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (verificaNome() && verificaCpf() && verificaTipoEndereco() && verificaLogradouro() && verificaNumeroEndereco() && verificaCep()
                && verificaBairro() && verificaCidade() && verificaEstado() && verificaTelefone() && verificaEmail())

            {
                Pessoa pessoa = new Pessoa(textBoxNomeCompleto.Text, maskedTextBoxCpf.Text, comboBoxTipoEndereco.Text, textBoxLogradouro.Text,
                    textBoxNumeroEndereco.Text, maskedTextBoxCep.Text, textBoxBairro.Text, textBoxCidade.Text, comboBoxEstado.Text,
                    maskedTextBoxTelefone.Text, textBoxEmail.Text);

                SalvarNoBanco(pessoa);
                MessageBox.Show("Dados salvos com Sucesso!");
                limparCampos();
                
                
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxNumeroEndereco.Text = "Sem número";
                textBoxNumeroEndereco.Enabled = false;
            }
            else if (!checkBox1.Checked)
            {
                textBoxNumeroEndereco.Enabled = true;
                textBoxNumeroEndereco.Text = "";
                textBoxNumeroEndereco.PlaceholderText = "Número";
            }

        }
        private void limparCampos()
        {
            textBoxNomeCompleto.Text = string.Empty;
            maskedTextBoxCpf.Text = string.Empty;
            comboBoxTipoEndereco.Text = string.Empty;
            textBoxLogradouro.Text = string.Empty;
            textBoxNumeroEndereco.Text = string.Empty;
            checkBox1.Checked = false;
            maskedTextBoxCep.Text = string.Empty;
            textBoxBairro.Text = string.Empty;
            textBoxCidade.Text = string.Empty;
            comboBoxEstado.Text = string.Empty;
            maskedTextBoxTelefone.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
        }
    }
}