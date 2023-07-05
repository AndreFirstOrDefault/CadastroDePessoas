using System.Data.SqlClient;

namespace CadastroDePessoas
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            string hora = DateTime.Now.ToString();
            labelBemVindo.Text = hora;
        }

        string hora = DateTime.Now.ToString();

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (verificaNome() && verificaCpf() && verificaEstado() && verificaLogradouro() && verificaNumeroEndereco() && verificaCep()
                && verificaBairro() && verificaCidade() && verificaEstado() && verificaTelefone() && verificaEstado() && verificaTelefone()
                && verificaEmail())

            {
                Pessoa pessoa = new Pessoa(textBoxNomeCompleto.Text, maskedTextBoxCpf.Text, comboBoxTipoEndereco.Text, textBoxLogradouro.Text,
                    textBoxNumeroEndereco.Text, maskedTextBoxCep.Text, textBoxBairro.Text, textBoxCidade.Text, comboBoxEstado.Text,
                    maskedTextBoxTelefone.Text, textBoxEmail.Text);

                MessageBox.Show("Cadastro realizado com sucesso!");

                SalvarNoBanco(pessoa);
            }
            else
            {
                MessageBox.Show("Verifique os dados e tente novamente!");
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

        
    }
}