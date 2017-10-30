using System;
using System.IO;
using System.Text;

namespace CadastroVendasPoo{
    public class Cpf{
        /// <summary>
        /// O método validaCPF verifica se o CPF passado é valido ou não e retorna em boolean.
        ///<summary>
        public bool Val(string cpfUsuario){
            bool retorno = true;

            string cpfCalculo = "";

            int[] v1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] v2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int resultado = 0;
            int resto = 0;

            try{
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
            }
            catch(Exception){
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// O método Exists verifica se o CPF passado existe dentro do cadastro
        /// de clientes (CLientes.csv) e retorna em boolean.
        ///<summary>
        public bool Exists(string cpf){
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

         public bool Exists(string cpf, StreamReader cadCli){
            bool bll = true;

            string c;
            while( (c=cadCli.ReadLine()) != null){ 
                string[] CPFcli = c.Split(';');
                if(cpf !=  CPFcli[2])
                    bll = false;
            }
            cadCli.Close();

            return bll;
        }
    }
}
