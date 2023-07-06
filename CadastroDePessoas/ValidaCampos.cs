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
            string cpfString = maskedTextBoxCpf.Text;
            cpfString = cpfString.Replace(".",string.Empty).Replace("-",string.Empty);
            char[] cpfCharArray = cpfString.ToCharArray();
            int[] cpfIntArray = Array.ConvertAll(cpfCharArray, x => (int)Char.GetNumericValue(x));
            int soma = 0;
            int digitoVerificador1 = 0;
            int digitoVerificador2 = 0;
            int m = 10;

            for (int i = 0; i < 9; i++)
            {
                soma += cpfIntArray[i] * m;              
                m--;
            }

            int resto = soma % 11;

            if (!(resto == 0 || resto == 1))
            {
                digitoVerificador1 = 11 - resto;
            }
            else
            {
                digitoVerificador1 = 0;
            }
            //Verificador 2
            soma = 0;
            m = 11;

            for (int i = 0; i < 10; i++)
            {
                
                soma += cpfIntArray[i] * m;
                m--;
            }

            resto = soma % 11;

            if (!(resto == 0 || resto == 1))
            {
                digitoVerificador2 = 11 - resto;
            }
            else
            {
                digitoVerificador2 = 0;
            }

            if (cpfString.Length == 11)
            {
                if( !(cpfString == "00000000000" || cpfString == "11111111111" ||
                    cpfString == "22222222222" || cpfString == "33333333333" || cpfString == "44444444444" ||
                    cpfString == "55555555555" || cpfString == "66666666666" || cpfString == "77777777777" ||
                    cpfString == "88888888888" || cpfString == "99999999999" || cpfString == "01234567890"))
                {
                    if ((cpfIntArray[9] == digitoVerificador1) && (cpfIntArray[10] == digitoVerificador2))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido!", "Erro no campo CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; 
                    }
                }
                else
                {
                    MessageBox.Show("CPF inválido!", "Erro no campo CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            } 
            else
            {
                MessageBox.Show("CPF inválido!","Erro no campo CPF",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
                
            }

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
