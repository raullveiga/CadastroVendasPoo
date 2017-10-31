using System;
using CadastroVendasPoo.Classes;

namespace CadastroVendasPoo
{
    class Program
    {
        static void Main(string[] args)
        {


            int op = 0;
            do
            {   
                
              Console.WriteLine("\n\n##############################################################");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("#                    Programa de Vendas                      #");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("#                                                            #");
                Console.WriteLine("##############################################################");
                
                try{
                Console.WriteLine("\nDigite:\n 1- Cadastro de Cliente\n 2- Cadastro de Produto\n 3- Cadastro de Venda\n 4- Extrato do cliente\n 9- Sair");
                op = Convert.ToInt16(Console.ReadLine());
                

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
                        Console.Write("Digite o CPF do cliente: ");
                        cpf = Console.ReadLine();
                        Console.Write("Digite o id do produto: ");
                        idProduto = Convert.ToInt16(Console.ReadLine());

                        Venda vd = new Venda(idProduto,cpf,DateTime.Now.Date);
                        Console.WriteLine(new SalvarVenda().Salvar(vd));

                        

                    break;

                    case 4:
                        Console.WriteLine("Digite o CPF a ser consultado: ");
                        Console.WriteLine(new Extrato().Dados(Console.ReadLine()));
                        
                        

                    break;

                    case 9:
                    break;

                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }
                }
                catch(Exception){
                    System.Console.WriteLine("Entrada inválida");
                }
                finally{
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }while (op!=9);
        }
    }
}
