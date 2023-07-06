namespace CadastroDePessoas
{
    public partial class TelaPrincipal : Form
    {
        private bool verificaNome()
        {
            if (textBoxNomeCompleto.Text.Length >= 5 && textBoxNomeCompleto.Text.Contains(' '))
            {
                return true;
            }
            MessageBox.Show("Preencha o nome completo!","Campo inválido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            textBoxNomeCompleto.Focus();
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
                        MessageBox.Show("CPF inválido!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maskedTextBoxCpf.Focus();
                        return false; 
                    }
                }
                else
                {
                    MessageBox.Show("CPF inválido!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedTextBoxCpf.Focus();
                    return false;

                }
            } 
            else
            {
                MessageBox.Show("CPF inválido!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCpf.Focus();
                return false;
                
            }

        }

        private bool verificaTipoEndereco()
        {
            if (comboBoxTipoEndereco.Text.Contains("Rua") || comboBoxTipoEndereco.Text.Contains("Avenida") || 
                comboBoxTipoEndereco.Text.Contains("Travessa") || comboBoxTipoEndereco.Text.Contains("Praça") || 
                comboBoxTipoEndereco.Text.Contains("Alameda") || comboBoxTipoEndereco.Text.Contains("Estrada") || 
                comboBoxTipoEndereco.Text.Contains("Outro"))
            {
                return true;
            }
            MessageBox.Show("Selecione um tipo de endereço!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            comboBoxTipoEndereco.Focus();
            return false;
        }

        private bool verificaLogradouro()
        {
            if (textBoxLogradouro.Text.Length >= 3)
            {
                return true;
            }
            MessageBox.Show("Preencha o campo Logradouro!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxLogradouro.Focus();
            return false;
        }

        private bool verificaNumeroEndereco()
        {
            if(checkBox1.Checked)
            {
                textBoxNumeroEndereco.Text = "Sem numero";
            }
            string numeroEndereco = textBoxNumeroEndereco.Text;
           
            if (numeroEndereco.Length != 0 || checkBox1.Checked)
            {
                return true;
            }
            MessageBox.Show("Preencha o campo Número ou marque a opção sem número!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxNumeroEndereco.Focus();
            return false;
        }

        private bool verificaCep()
        {
            string cep = maskedTextBoxCep.Text.Replace("-", string.Empty);
            int cepInt = 0;

            if (cep.Length == 8)
            {
                cepInt = int.Parse(cep);
            }
            else
            {
                MessageBox.Show("CEP inválido!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCep.Focus();
                return false;
            }

            if (cepInt >= 1000000 && cepInt <= 19999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("SP");
                return true;
            }
            else if (cepInt >= 20000000 && cepInt <= 28999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("RJ");
                return true;
            }
            else if (cepInt >= 29000000 && cepInt <= 29999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("ES");
                return true;
            }
            else if (cepInt >= 30000000 && cepInt <= 39999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("MG");
                return true;
            }
            else if (cepInt >= 40000000 && cepInt <= 48999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("BA");
                return true;
            }
            else if (cepInt >= 49000000 && cepInt <= 49999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("SE");
                return true;
            }
            else if (cepInt >= 50000000 && cepInt <= 56999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("PE");
                return true;
            }
            else if (cepInt >= 57000000 && cepInt <= 57999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("AL");
                return true;
            }
            else if (cepInt >= 58000000 && cepInt <= 58999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("PB");
                return true;
            }
            else if (cepInt >= 59000000 && cepInt <= 59999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("RN");
                return true;
            }
            else if (cepInt >= 60000000 && cepInt <= 63999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("CE");
                return true;
            }
            else if (cepInt >= 64000000 && cepInt <= 64999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("PI");
                return true;
            }
            else if (cepInt >= 65000000 && cepInt <= 65999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("MA");
                return true;
            }
            else if (cepInt >= 66000000 && cepInt <= 68899999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("PA");
                return true;
            }
            else if (cepInt >= 69400000 && cepInt <= 69899999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("AM");
                return true;
            }
            else if (cepInt >= 69300000 && cepInt <= 69389999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("RR");
                return true;
            }
            else if (cepInt >= 69900000 && cepInt <= 69999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("AC"); 
                return true;
            }
            else if (cepInt >= 70000000 && cepInt <= 73699999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("DF");
                return true;
            }
            else if (cepInt >= 72800000  && cepInt <= 76799999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("GO");
                return true;
            }
            else if (cepInt >= 77000000  && cepInt <= 77995999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("TO");
                return true;
            }
            else if (cepInt >= 78000000 && cepInt <= 78899999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("MT");
                return true;
            }
            else if (cepInt >= 78900000 && cepInt <= 78999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("RO");
                return true;
            }
            else if (cepInt >= 79000000 && cepInt <= 79999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("MS");
                return true;
            }
            else if (cepInt >= 80000000 && cepInt <= 87999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("PR");
                return true;
            }
            else if (cepInt >= 88000000 && cepInt <= 89999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("SC");
                return true;
            }
            else if (cepInt >= 90000000 && cepInt <= 99999999)
            {
                comboBoxEstado.SelectedIndex = comboBoxEstado.FindString("RS");
                return true;
            }
            else
            {
                MessageBox.Show("CEP inválido!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCep.Focus();
                return false;
            }

        }

        private bool verificaBairro()
        {
            if (textBoxBairro.Text.Replace("-", string.Empty).Length > 4)
            {
                return true;
            }
            MessageBox.Show("Preencha o campo Bairro!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxBairro.Focus();
            return false;
        }

        private bool verificaCidade()
        {
            if (textBoxCidade.Text.Length > 4)
            {
                return true;
            }
            MessageBox.Show("Preencha o campo Cidade!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxCidade.Focus();
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
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            int numberOfItens = maskedTextBoxTelefone.Text.Length;

            if (numberOfItens >=10)
            {
                return true;
            }
            MessageBox.Show("Preencha o campo Telefone!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            maskedTextBoxTelefone.Focus();
            return false;
        }

        private bool verificaEmail()
        {
            if (textBoxEmail.Text.Contains("@hotmail.com") || textBoxEmail.Text.Contains("@gmail.com") || textBoxEmail.Text.Contains("@outlook.com"))
            {
                return true;
            }
            MessageBox.Show("Preencha o campo Email!", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxEmail.Focus();
            return false;
        }
    }
}
