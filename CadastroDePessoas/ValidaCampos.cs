namespace CadastroDePessoas
{
    public partial class TelaPrincipal : Form
    {
        private bool verificaNome()
        {
            if (textBoxNomeCompleto.Text.Length >= 5)
            {
                return true;
            }
            return false;
        }

        private bool verificaCpf()
        {
            if (maskedTextBoxCpf.Text.Trim('.', '-').Length == 11)
            {
                return true;
            }
            return false;
        }

        private bool verificaEndereco()
        {
            if (comboBoxEstado.Text != null)
            {
                return true;
            }
            return false;
        }

        private bool verificaLogradouro()
        {
            if (textBoxLogradouro.Text != null)
            {
                return true;
            }
            return false;
        }

        private bool verificaNumeroEndereco()
        {
            if (textBoxNumeroEndereco.Text != null || checkBox1.Checked)
            {
                return true;
            }
            return false;
        }

        private bool verificaCep()
        {
            if (maskedTextBoxCep.Text.Length == 9)
            {
                return true;
            }
            return false;
        }

        private bool verificaBairro()
        {
            if (textBoxBairro.Text.Length > 4)
            {
                return true;
            }
            return false;
        }

        private bool verificaCidade()
        {
            if (textBoxCidade.Text.Length > 4)
            {
                return true;
            }
            return false;
        }

        private bool verificaEstado()
        {
            if (comboBoxEstado.Text != "")
            {
                return true;
            }
            return false;
        }

        private bool verificaTelefone()
        {
            if (maskedTextBoxTelefone.Text.Length >= 11)
            {
                return true;
            }
            return false;
        }

        private bool verificaEmail()
        {
            if (textBoxEmail.Text.Contains("@hotmail.com") || textBoxEmail.Text.Contains("@gmail.com") || textBoxEmail.Text.Contains("@outlook.com"))
            {
                return true;
            }
            return false;
        }
    }
}
