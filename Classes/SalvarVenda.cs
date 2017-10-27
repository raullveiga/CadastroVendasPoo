using System;
using System.IO;

namespace CadastroVendasPoo.classes
{   
    /// <summary>
    /// A classe SalvarVenda grava os dados de uma venda
    /// </summary>
    public class SalvarVenda
    {   
        /// <summary>
        /// O método Salvar grava os dados passados no arquivo cadVendas.csv
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public string Salvar(Venda venda)
        {
            string msg = "";
            StreamWriter ar = null;
            try
            {
                ar = new StreamWriter("cadVendas.csv", true);
                ar.WriteLine(   venda.Id + ";" +
                                venda.Cpf + ";" +
                                venda.DataVenda);

                msg = "Venda salva com sucesso!";
            }
            catch (Exception ex)
            {
                msg = "Erro ao gravar arquivo. " + ex.Message;
            }
            finally
            {
                ar.Close();
            }
            return msg;
        }
    }
}