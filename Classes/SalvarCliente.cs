using System;
using System.IO;

namespace CadastroVendasPoo.classes
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

            try
            {
                    ar = new StreamWriter("cadClientes.csv", true);
                if (validaCPF(cliente.Cpf))
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
        /// <summary>
        /// O método validaCPF verifica se o CPF passado é valido ou não.
        ///<summary>
        bool validaCPF(string cpfUsuario)
        {
            bool retorno = true;

            string cpfCalculo = "";

            int[] v1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] v2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int resultado = 0;
            int resto = 0;


            cpfCalculo = cpfUsuario.Substring(0, 9);

            for (int i = 0; i < cpfCalculo.Length; i++)
            {
                resultado += Int16.Parse(cpfCalculo[i].ToString()) * v1[i];
            }

            resto = resultado % 11;
            if (resto < 2)
                cpfCalculo += "0";
            else
                cpfCalculo += (11 - resto).ToString();

            resultado = 0;

            for (int i = 0; i < cpfCalculo.Length; i++)
            {
                resultado += Int16.Parse(cpfCalculo[i].ToString()) * v2[i];
            }

            resto = resultado % 11;
            if (resto < 2)
                cpfCalculo += "0";
            else
                cpfCalculo += (11 - resto).ToString();

            if (cpfUsuario != cpfCalculo)
                retorno = false;

            return retorno;

        }
    }
}