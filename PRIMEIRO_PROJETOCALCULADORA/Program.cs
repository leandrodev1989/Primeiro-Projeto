using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEIRO_PROJETOCALCULADORA
{
    class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potência, Raiz, Sair }
        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)//Enquanto o usuario NÃO(!) ESCOLHER SAIR EXIBA O MENU
            {


                Console.WriteLine("SEJAM BEM VINDO AO CALC:");
                Console.WriteLine(" 1-Soma\n 2-Subtração\n 3-Divisão\n 4-Multiplicação\n 5-Potência\n 6-Raiz\n 7-Sair");
                Console.WriteLine("DIGITE UMA OPERAÇÃO:");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());//int.Parse converte  string em numeros//

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtração:
                        Sub();
                        break;
                    case Menu.Divisão:
                        Div();
                        break;
                    case Menu.Multiplicação:
                        Mult();
                        break;
                    case Menu.Potência:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();
            }

        

        }
     static void Soma()
        {

            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");//opeçao $ para não concatenar//
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

                

        }
        static void Sub()
        {

            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Div()
        {

            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            float a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Mult()
        {

            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Pot()
        {

            Console.WriteLine("Potência de dois numeros: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Raiz()
        {

            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
    }
}
