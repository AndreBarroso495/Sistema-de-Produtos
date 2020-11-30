using System;

namespace Sistema_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            float[] preco = new float[10];
            string produto;


            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Sistema de Produtos");
            Console.WriteLine("----------------------");

            bool promocao(string resposta){
                if(resposta == "sim"){
                    return true;
                }
                else{
                    Console.WriteLine("Esse produto não está em promoção!");
                    return false;
                }
               
            }

            
            //Criar o menu
            int escolha;
            int i = 0;
            string resposta;

            do
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("[1] - Cadastrar Produto");
                Console.WriteLine("[2] - Listar Produtos");
                Console.WriteLine("[0] - Mostrar Menu");
                escolha = int.Parse(Console.ReadLine());
            
            switch (escolha)

            {
                case 1:
                do
                {
                    if (i < 10)
                    {
                        Console.WriteLine($"Digite o {i +1}º produto");
                        nome[i] = Console.ReadLine();
                        Console.WriteLine($"Digite o preço do {i +1}º produto");
                        preco [i] = float.Parse(Console.ReadLine());
                        i++;
                    }else{
                        Console.WriteLine("Limite de produtos excedido");
                        break;
                    }

                    Console.WriteLine("Gostaria de cadastrar um novo produto? s/n");
                    resposta = Console.ReadLine();
                        
                } while (resposta == "s");

                    break;

                    case 2:
                  {
                    for (var z = 0; z < 10; z++)
                    {
                        Console.WriteLine($"Produto {nome[z]}");
                    }

                  }
                    break;
                    
                    case 0:
                    Console.WriteLine("Obrigado, volte sempre!");
                    break;
                default:
                Console.WriteLine("Opção inválida!");
                    break;
            }
            
            }while (escolha != 0);
        }
    }
}
