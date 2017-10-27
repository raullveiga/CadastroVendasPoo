using System;
using CadastroVendasPoo.classes;

namespace CadastroVendasPoo
{
    class Program
    {
        static void Main(string[] args)
        {


            int op = 0;
            while (op!=9)
            {   
                
              Console.WriteLine("\n\n##############################################################");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("#                    Programa de Vendas                      #");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("##############################################################");
            
                Console.WriteLine("\nDigite:\n 1- Cadastro de Cliente\n 2- Cadastro de Produto\n 3- Cadastro de Venda\n 4- Extrato do cliente\n 9- Sair");
                op = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        string nomeCliente = Console.ReadLine();
                        Console.Write("Digite o e-mail do cliente: ");
                        string email = Console.ReadLine();
                        Console.Write("Digite o CPF do cliente: ");
                        string cpf = Console.ReadLine();
                        
                        Cliente cl = new Cliente(nomeCliente,email,cpf,DateTime.Now.Date);
                        Console.Write(new SalvarCliente().Salvar(cl));

                    break;

                    case 2:
                        Console.Write("Digite o Id do produto: ");
                        int idProduto = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite o nome do produto: ");
                        string nProduto = Console.ReadLine();
                        Console.Write("Digite a descrição do produto: ");
                        string desc = Console.ReadLine();
                        Console.Write("Digite o preço do produto: ");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        Produto pr = new Produto(idProduto,nProduto,desc,preco);
                        Console.Write(new SalvarProduto().Salvar(pr));

                    break;

                    case 3:
                        Console.Write("Digite o id da venda: ");
                        int idvenda = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite o CPF do cliente: ");
                        cpf = Console.ReadLine();
                        
                    break;
                    
                    default:
                    break;
                }
                
            }



        }
    }
}
