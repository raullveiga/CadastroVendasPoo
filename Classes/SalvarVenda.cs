using System;
using System.IO;
using System.Text;

namespace CadastroVendasPoo.Classes
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

                if(new Cpf().Exists(venda.Cpf)&&new Prod().Exists(venda.Id)){
                ar.WriteLine(   venda.Id + ";" +
                                venda.Cpf + ";" +
                                venda.DataVenda);
                msg = "Venda salva com sucesso!";
                }
                else
                msg = "CPF ou Id inválidos.";

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