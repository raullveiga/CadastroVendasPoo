using System;
using System.IO;

namespace CadastroVendasPoo.Classes
{
    /// <summary>
    /// A classe SalvarCliente grava os dados de um cliente
    /// </summary>
    class SalvarCliente
    {
        /// <summary>
        /// O método Salvar grava os dados passados no arquivo cadClientes.csv
        /// </summary>
        /// <param name="cliente">Passe o cliente como Cliente(class)</param>
        /// <returns></returns>
        public string Salvar(Cliente cliente)
        {
            string msg = "";

            StreamWriter ar = null;
            bool e = new Cpf().Exists(cliente.Cpf);                         /// verificando se o cpf já existe
                                                                            
            try
            {
                ar = new StreamWriter("cadClientes.csv", true);
                if (!e)
                {

                    if (new Cpf().Val(cliente.Cpf))                     ///validando o cpf
                    {
                        ar.WriteLine(   cliente.Nome + ";" +
                                        cliente.Email + ";" +
                                        cliente.Cpf + ";" +
                                        cliente.DataCadastro);

                        msg = "Cliente salvo com sucesso!";
                    }
                    else
                    {
                        msg = "CPF inválido.";
                    }
                }
                else
                {
                    msg = "CPF já cadastrado.";
                }

            }
            catch (Exception ex)
            {
                msg = "Erro ao tentar gravar o arquivo. " + ex.Message;
            }
            finally
            {
                ar.Close();
            }
            return msg;

        }
    }
}