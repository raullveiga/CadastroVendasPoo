using System.IO;
using System.Text;

namespace CadastroVendasPoo.Classes{
    public class Prod{
        /// <summary>
        /// O método Exists verifica se o id passado existe dentro do cadastro
        /// de produtos (cadProdutos.csv).
        ///<summary>
        public bool Exists(int id){
            bool bll = true;

            StreamReader cadProd = new StreamReader("cadProdutos.csv",Encoding.Default);
            string c;
            while( (c=cadProd.ReadLine()) != null){ 
                string[] idProd = c.Split(';');
                if(id.ToString() !=  idProd[0])
                    bll = false;
            }
            cadProd.Close();

            return bll;

        }
         public bool Exists(int id, StreamReader cadProd){
            bool bll = true;

            string c;
            while( (c=cadProd.ReadLine()) != null){ 
                string[] idProd = c.Split(';');
                if(id.ToString() !=  idProd[0])
                    bll = false;
            }
            cadProd.Close();

            return bll;

        }
    }
}