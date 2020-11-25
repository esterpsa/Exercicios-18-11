using System;

namespace Exercicios_18_11
{
    class Program
    {
        static void Main(string[] args)
        {  
                 //número válido
                // Console.WriteLine("Digite números de 0 à 10: ");
                // int numero = int.Parse(Console.ReadLine());

                // while(numero >=10)
                // {
                //     Console.WriteLine("Número Inválido");
                //     Console.WriteLine("Tente novamente, digite um númerode entre 0 e 10: ");
                //     numero = int.Parse(Console.ReadLine());
                // }
                // Console.WriteLine("Parabéns! Número válido");
            
            
                //cadastro
                // Console.WriteLine("Digite a sua nome: ");
                // string nome =Console.ReadLine();
                // Console.WriteLine("______________");
                // Console.WriteLine("Dígite a sua senha: ");
                // string senha =Console.ReadLine();

                // if(senha == nome)
                // {
                //     Console.WriteLine("Senha inválida");
                // }
                // else{
                //     Console.WriteLine("Senha cadastrada com sucesso!");
                // }

                // Console.WriteLine("Cadastro de Usuário");
                // Console.WriteLine("-------------------------");

                // Console.WriteLine("Digite o seu nome: ");
                // string nome = Console.ReadLine();

                // while(nome == "")
                // {
                //     Console.WriteLine("O campo não foi informado");
                //     Console.WriteLine("Tente novamente, digite o seu nome: ");
                //     nome = Console.ReadLine();
                // }
                
                // Console.WriteLine("Dígite a sua idade: ");
                // int idade = int.Parse(Console.ReadLine());

                //  while(idade >=150)
                // {
                //     Console.WriteLine("Número inválido");
                //     Console.WriteLine("Tente novamente, informe a sua idade: ");
                //     idade = int.Parse(Console.ReadLine()); 
                // }

                // Console.WriteLine("Dígite o seu salário: ");
                // int salario = int.Parse(Console.ReadLine());

                //    while(salario <=0)
                // {
                //     Console.WriteLine("Número inválido");
                //     Console.WriteLine("Tente novamente, o salário precisa ser maior que zero: ");
                //     salario = int.Parse(Console.ReadLine()); 
                // }
                //      string resposta = Console.ReadLine();
    
                
                //      Console.WriteLine("Informe o seu estado civil, selecione uma das opções");
                //         Console.WriteLine("S- solteiro");
                //         Console.WriteLine("C- casado");
                //         Console.WriteLine("V- viuvo");
                //         Console.WriteLine("D - Divorciado");
                //         resposta = Console.ReadLine();

                        

                //     while(resposta == "A" || resposta == "B" ||resposta == "E" ||resposta =="F"|| resposta == "G"|| resposta == "H"||resposta == "I" || resposta == "J" ||resposta == "K" ||resposta =="L"|| resposta == "M"|| resposta == "N"||resposta == "O" || resposta == "P" ||resposta == "Q" ||resposta =="R"|| resposta == "T"||resposta == "U" || resposta == "V" ||resposta == "X" ||resposta =="Y"|| resposta == "Z")
                //     {
                //         Console.WriteLine("opção inválida, tente novamente");
                //          Console.WriteLine("S- solteiro");
                //         Console.WriteLine("C- casado");
                //         Console.WriteLine("V- viuvo");
                //         Console.WriteLine("D - Divorciado");
                //         resposta = Console.ReadLine();
                //     }

                //     Console.WriteLine("Cadastro concluído");

                //Desafio Fibonacci

                int x = 1;
                int z = 0;
                int resposta; 
                int valor = 0;

                Console.WriteLine("Digite um número");
                resposta = int.Parse(Console.ReadLine());

                for( int i = 0; valor <=500; i++)
                {
                    valor = x + z;
                    Console.Write( z + ",");
                    x =z;
                    z= valor;
                }
                  Console.ReadLine();


                    


                

        }
    }
}
