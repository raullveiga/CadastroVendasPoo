using System;
using System.IO;

namespace CadastroVendasPoo.classes
{  
    /// <summary>
    /// A classe SalvarProduto, grava os dados de um produto
    /// </summary>
    public class SalvarProduto
    {
        /// <summary>
        /// O método Salvar grava os dados passados no arquivo cadProduto.csv
        /// </summary>
        /// <param name="produto">Passe como o produto como Produto(class)</param>
        /// <returns></returns>
        public string Salvar(Produto produto)
        {
            string msg = "";

            StreamWriter ar = null;
            try
            {
                ar = new StreamWriter("cadProdutos.csv", true);
                ar.WriteLine(produto.Id + ";" +
                                produto.NProduto + ";" +
                                produto.Desc + ";" +
                                produto.Preco);

                msg = "Produto cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                msg = "Erro ao tentar gravar arquivo. " + ex.Message;

            }
            finally
            {
                ar.Close();
            }

            return msg;
        }
    }
}