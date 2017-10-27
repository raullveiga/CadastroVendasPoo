using System;

namespace CadastroVendasPoo.classes{
    /// <summary>
    /// A classe Vendas possui informações sobre a venda
    /// </summary>
    public class Venda{
        private string cpf;
        public string Cpf
        {
            get { return Cpf;}
            set { Cpf = value;}
        }
        private int id;
        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        private DateTime dataVenda;
        public DateTime DataVenda
        {
            get { return dataVenda;}
            set { dataVenda = value;}
        }
        /// <summary>
        /// Constrói o objeto Venda
        /// </summary>
        public Venda(){}
        /// <summary>
        /// Constrói o objeto Venda e você precisa passar os parâmetros
        /// </summary>
        /// <param name="id">Passe o id da venda como int</param>
        /// <param name="cpf">Passe o cpf do cliente como string</param>
        /// <param name="dataVenda">Passe a data da venda como DateTime</param>
        public Venda(int id, string cpf, DateTime dataVenda){
            this.id = id;
            this.cpf = cpf;
            this.dataVenda = dataVenda;
        }


        
        
    }
}