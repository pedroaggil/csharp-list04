﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_List_04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) à 3° Lista de Exercícios em C#!");
            Console.WriteLine("Espero que as soluções aqui dispostas sejam-lhe de seu agrado! :D");
            Console.ReadKey();
            Console.WriteLine();

            // Ex 001
            Console.Write("Digite o número a ser calculado (fatorial): ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, calcFatorial(n));

            Console.ReadKey();
            Console.WriteLine();

            // Ex 002
            Console.Write("Digite o 1° número a ser calculado (diferença): ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número a ser calculado (diferença): ");
            double n2 = double.Parse(Console.ReadLine());


            Console.WriteLine("A diferença entre os números dados é: {0}", Diferenca(n1, n2));

            Console.ReadKey();
            Console.WriteLine();

            // Ex 003
            bool repeatTriangleQuestion = true;

            do
            {
                Console.Write("Digite o valor do primeiro lado: ");
                double l1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor do segundo lado: ");
                double l2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor do terceiro lado: ");
                double l3 = double.Parse(Console.ReadLine());

                if (verifTriangulo(l1, l2, l3))
                {
                    if (l1 == l2 && l2 == l3)
                    {
                        Console.WriteLine("O triângulo é equilátero.");
                    }
                    else if (l1 == l2 || l1 == l3 || l2 == l3)
                    {
                        Console.WriteLine("O triângulo é isósceles.");
                    }
                    else
                    {
                        Console.WriteLine("O triângulo é escaleno.");
                    }

                    repeatTriangleQuestion = false;
                }
                else
                {
                    Console.WriteLine("Não é triângulo não, mano. Revise os dados informados e tente novamente.");
                    repeatTriangleQuestion = true;

                    Console.ReadKey();
                    Console.WriteLine();

                }

            } while (repeatTriangleQuestion == true);

            Console.ReadKey();
            Console.WriteLine();

            // Ex 004
            Console.WriteLine("Digite a altura (em metros):");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o gênero (M para masculino ou F para feminino):");
            char genero = char.ToUpper(Console.ReadKey().KeyChar);

            double pesoIdeal = calcPesoIdeal(genero, altura);
            Console.WriteLine("\nO peso ideal é: " + pesoIdeal.ToString("0.00") + " kg");

            Console.ReadKey();
            Console.WriteLine();

            // Ex 005
            int opcao;

            do
            {
                ExibirMenu();
                opcao = LerOpcao();

                switch (opcao)
                {
                    case 1:
                        CalcularSoma();
                        break;
                    case 2:
                        CalcularSubtracao();
                        break;
                    case 3:
                        CalcularDivisao();
                        break;
                    case 4:
                        CalcularMultiplicacao();
                        break;
                    case 5:
                        CalcularRestoDivisao();
                        break;
                    case 6:
                        CalcularDobro();
                        break;
                    case 7:
                        CalcularQuadrado();
                        break;
                    case 8:
                        CalcularCubo();
                        break;
                    case 9:
                        CalcularRaizQuadrada();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;

                }

                Console.WriteLine();

            } while (opcao != 0);

            Console.ReadKey();
            Console.WriteLine();

            // Ex 006
            Console.WriteLine("Digite as coordenadas (x, y):");
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());

            int quadrante = verificaQuadrante(x, y);
            Console.WriteLine("O ponto está no quadrante " + quadrante);

            Console.ReadKey();
            Console.WriteLine();

            // Exit program
            Console.WriteLine("Muito obrigado por ficar até o final :') Até a próxima!");
            Console.ReadKey();
        }

        static double calcFatorial(double n)
        {
            int fat = 1;

            for (int x = 1; x <= n; x++)
            {
                fat = fat * x;
            }

            return fat;
        }

        static double Diferenca(double a, double b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;
        }

        static bool verifTriangulo(double a, double b, double c)
        {
            return a < b + c && b < a + c && c < a + b;
        }

        static double calcPesoIdeal(char gen, double alt)
        {
            if (gen == 'F')
                return (62.1 * alt) - 44.7;
            else
                return (72.7 * alt) - 58;
        }

        static void ExibirMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Dobro");
            Console.WriteLine("7 - Quadrado");
            Console.WriteLine("8 - Cubo");
            Console.WriteLine("9 - Raiz Quadrada");
            Console.WriteLine("0 - Sair");
        }

        static int LerOpcao()
        {
            Console.Write("Digite a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        static void CalcularSoma()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            double resultado = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }

        static void CalcularSubtracao()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            double resultado = num1 - num2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
        }

        static void CalcularDivisao()
        {
            Console.Write("Digite o dividendo: ");
            double dividendo = double.Parse(Console.ReadLine());
            Console.Write("Digite o divisor: ");
            double divisor = double.Parse(Console.ReadLine());

            if (divisor != 0)
            {
                double resultado = dividendo / divisor;
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }

        static void CalcularMultiplicacao()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            double resultado = num1 * num2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }

        static void CalcularRestoDivisao()
        {
            Console.Write("Digite o dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());
            Console.Write("Digite o divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            if (divisor != 0)
            {
                int resto = dividendo % divisor;
                Console.WriteLine("O resto da divisão é: " + resto);
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }

        static void CalcularDobro()
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            double resultado = num * 2;
            Console.WriteLine("O dobro do número é: " + resultado);
        }

        static void CalcularQuadrado()
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(num, 2);
            Console.WriteLine("O quadrado do número é: " + resultado);
        }

        static void CalcularCubo()
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(num, 3);
            Console.WriteLine("O cubo do número é: " + resultado);
        }

        static void CalcularRaizQuadrada()
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                double resultado = Math.Sqrt(num);
                Console.WriteLine("A raiz quadrada do número é: " + resultado);
            }
            else
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
            }
        }

        static int verificaQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}
