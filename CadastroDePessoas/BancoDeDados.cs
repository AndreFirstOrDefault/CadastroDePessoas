using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDePessoas
{
    partial class TelaPrincipal
    {
        private string stringDeConexao = "Data Source=ANDREDELL_3501;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void SalvarNoBanco(Pessoa pessoa)
        {
            string stringDeComando = "INSERT INTO CadastroPF VALUES (@Nome, @Cpf, @Tipo, @Logradouro, @Numero , @Cep , @Bairro, @Cidade, @Estado, @Telefone, @Email )";
            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@Nome", textBoxNomeCompleto.Text);
                sqlCommand.Parameters.AddWithValue("@Cpf", maskedTextBoxCpf.Text);
                sqlCommand.Parameters.AddWithValue("@Tipo", comboBoxTipoEndereco.Text);
                sqlCommand.Parameters.AddWithValue("@Logradouro", textBoxLogradouro.Text);
                sqlCommand.Parameters.AddWithValue("@Numero", textBoxNumeroEndereco.Text);
                sqlCommand.Parameters.AddWithValue("@Cep", maskedTextBoxCep.Text);
                sqlCommand.Parameters.AddWithValue("@Bairro", textBoxBairro.Text);
                sqlCommand.Parameters.AddWithValue("@Cidade", textBoxCidade.Text);
                sqlCommand.Parameters.AddWithValue("@Estado", comboBoxEstado.Text);
                sqlCommand.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                sqlCommand.Parameters.AddWithValue("@Email", textBoxEmail.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            string stringDeComando = "SELECT Nome, Cpf, Tipo, Logradouro, Numero ,Cep ,Bairro, Cidade, Estado, Telefone, Email FROM " +
                " CadastroPF WHERE Cpf=@CpfConsultar";
            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@CpfConsultar", maskedTextBox1.Text);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);

                labelBemVindo.Visible = false;
                dataGridView1.Visible = true;

                dataGridView1.DataSource = ds.Tables[0];

               
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {


            string stringDeComando = "DELETE FROM CadastroPF WHERE Cpf=@CpfConsultar";

            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                sqlCommand.Parameters.AddWithValue("@CpfConsultar", maskedTextBox1.Text.Trim('.', '-'));
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();

                dataGridView1.Visible = true;
                labelBemVindo.Visible = false;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }
        }

    }
}
