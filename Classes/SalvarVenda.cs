using System;
using System.IO;
using System.Text;

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

                if(chkCPF(venda.Cpf)&&chkID(venda.Id)){
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
        /// <summary>
        /// O método chkCPF verifica se o cpf passado existe 
        /// dentro do cadastro de clientes (cadClientes.csv).
        ///<summary>
        private bool chkCPF(string cpf){
            bool bll = true;

            StreamReader cadCli = new StreamReader("cadClientes.csv",Encoding.Default);
            string c;
            while( (c=cadCli.ReadLine()) != null){ 
                string[] CPFcli = c.Split(';');
                if(cpf !=  CPFcli[2])
                    bll = false;
            }
            cadCli.Close();

            return bll;
        }
        /// <summary>
        /// O método chkID verifica se o id passado existe dentro do cadastro
        /// de produtos (cadProdutos.csv).
        ///<summary>
        private bool chkID(int id){
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
    }
}