using System.Data.SqlClient;

namespace CadastroDePessoas
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string cpf, string tipoEndereco, 
            string logradouro, string numero, string cep, string bairro, 
            string cidade, string estado, string telefone, string email) 
        {
            Nome = nome;
            Cpf = cpf;
            TipoEndereco = tipoEndereco;
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Email = email;

        }

        
        
    }
}
