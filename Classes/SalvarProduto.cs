using System;
using System.IO;

namespace CadastroVendasPoo.Classes
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
            bool e = new Prod().Exists(produto.Id);                        /// verificando se o Id já está cadastrado
            
            try
            {
                ar = new StreamWriter("cadProdutos.csv", true);
                if (!e)
                {
                    ar.WriteLine(   produto.Id + ";" +
                                    produto.NProduto + ";" +
                                    produto.Desc + ";" +
                                    produto.Preco);

                    msg = "Produto cadastrado com sucesso!";
                }
                else
                {
                    msg = "Id já está cadastrada!";
                }
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