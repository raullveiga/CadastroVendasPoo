using System;
using System.IO;
using System.Text;

namespace CadastroVendasPoo.Classes
{
    public class Extrato
    {

        public string Dados(string cpfUser)
        {

            string c;
            string r = "";
            
            if(!new Cpf().Exists(cpfUser)){                     /// verifica se o cpf não existe 
                c = null;   
                if(new Cpf().Val(cpfUser))                      /// também verificando se é valido, retornando as devidas respostas
                    r = "O CPF digitado não está cadastrado";
                else
                    r = "CPF inválido.";
            }
            StreamReader cadCli = null;

            try
            {
                cadCli = new StreamReader("cadvendas.csv", Encoding.Default);
                while ((c = cadCli.ReadLine()) != null)
                {
                    string[] CPFcli = c.Split(';');
                    if (CPFcli[1] == cpfUser)
                        r += c+"\n";
                }
            }
            catch (Exception ex)
            {
                r = "Houve um problema ao consultar"+ex.Message;
            }
            finally
            {
                cadCli.Close();
            }
            if(r=="")
            r = "Não há dados sobre o CPF digitado.";
            return r;
        }
    }
}