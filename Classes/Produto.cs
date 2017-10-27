namespace CadastroVendasPoo.classes{
    /// <summary>
    /// A Classe Produto possui informações do produto
    /// </summary>
    public class Produto{
        private int id;
        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        private string nProduto;
        public string NProduto
        {
            get { return nProduto;}
            set { nProduto = value;}
        }
        private string desc;
        public string Desc
        {
            get { return desc;}
            set { desc = value;}
        }
        private double preco;
        public double Preco
        {
            get { return preco;}
            set { preco = value;}
        }
        /// <summary>
        /// Constrói o objeto Produto
        /// </summary>
        public Produto(){}
        /// <summary>
        /// Constrói o objeto Produto e você precisa passar os dados como parâmetros
        /// </summary>
        /// <param name="id">Passe o id do produto como int</param>
        /// <param name="nProduto">Passe o nome do produto como string</param>
        /// <param name="desc">Passe a descrição do produto como string</param>
        /// <param name="preco">Passe o preço do produto como double</param>
        public Produto(int id, string nProduto, string desc, double preco){
            this.id = id;
            this.nProduto = nProduto;
            this.desc = desc;
            this.preco = preco;
        }


        
        
        
        
    }
}