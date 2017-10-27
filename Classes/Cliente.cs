using System;

namespace CadastroVendasPoo.classes{
    /// <summary>
    /// A classe Cliente possui informações sobre o cliente
    /// </summary>
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;
        private DateTime datacadastro;
        /// <summary>
        /// Constrói o objeto Cliente
        /// </summary>
        public Cliente(){}
        /// <summary>
        /// Constroi o Objeto Cliente e você precisa passar os dados como parâmetro
        /// </summary>
        /// <param name="nome">Passe o nome do cliente como string</param>
        /// <param name="email">Passe o email do cliente como string</param>
        /// <param name="cpf">Passe o cpf do cliente como string</param>
        /// <param name="datacadastro">Passe a data de cadastro como DateTime</param>
        public Cliente(string nome, string email, string cpf, DateTime datacadastro){
            this.nome = nome;
            this.email = email;
            this.cpf= cpf;
            this.datacadastro = datacadastro;
        }

        public string Nome { get{return nome;} set{nome = value;}}
        public string Email { get{return email;} set{email = value;}}
        public string Cpf { get{return cpf;} set{cpf = value;}}
        public DateTime DataCadastro { get{return datacadastro;} set{datacadastro = value;}}

        
    }
}