using System;

namespace CadastroVendasPoo.classes{
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
        
        public Venda(){}
        public Venda(int id, string cpf, DateTime dataVenda){
            this.id = id;
            this.cpf = cpf;
            this.dataVenda = dataVenda;
        }
        
        
        
        
    }
}