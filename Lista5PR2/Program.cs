using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int program;

            for (int i = 0; i != 8 && i <= 7; i++)
            {
                Console.WriteLine("\nqual o programa que voce deseja executar? \ndigite 0 para finalizar\n");
                program = int.Parse(Console.ReadLine());

                if (program == 0)
                {
                    break;
                }

                switch (program)
                {
                    case 1:
                        int n;
                        Console.WriteLine("\ndigite o numero desejado:");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int j = 0; j <= n; j++)
                        {
                            Console.WriteLine(j);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        int num;
                        Console.WriteLine("digite o numero desejado:");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int j = 0; j <= num; j++)
                        {
                            if (j % 2 == 0)
                                Console.WriteLine(j);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        int numm;
                        Console.WriteLine("digite o numero desejado:");
                        numm = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int j = 1000; j >= numm; j--)
                        {
                            if (j % 2 == 0)
                                Console.WriteLine(j);
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        {
                            int num1;
                            num1 = 0;
                            for (int j = 0; num1 < 200; j++)
                            {
                                Console.WriteLine("digite um numero:");
                                int num2 = int.Parse(Console.ReadLine());
                                if (num2 > 0)
                                    num1 = num1 + num2;
                                Console.WriteLine(num2 + " soma total: " + num1);
                            }
                        }
                        break;

                    case 5:
                        {
                            double nummmm;
                            Console.WriteLine("digite o numero desejado:");
                            nummmm = double.Parse(Console.ReadLine());
                            for (int j = 1; j <= nummmm; j++)
                            {
                                if (nummmm % j == 0)
                                {
                                    Console.WriteLine(j);
                                }
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        int numero, maior, menor;
                        Console.WriteLine("digite um numero:");
                        maior = int.Parse(Console.ReadLine());
                        menor = maior;
                        for (int j = 0; j < 9; j++)
                        {
                            Console.WriteLine("digite um numero:");
                            numero = int.Parse(Console.ReadLine());
                            if (numero > maior)
                                maior = numero;
                            if (numero < menor)
                                menor = numero;
                        }
                        Console.WriteLine("O menor numero é: " + menor + " e o maior é: " + maior);
                        break;

                    case 7:
                        {
                            int numerooo, somai, somap;
                            somap = 0;
                            somai = 0;
                            for (int j = 1; j != 0; j++)
                            {
                                Console.WriteLine("digite um numero:");
                                numerooo = int.Parse(Console.ReadLine());
                                if (numerooo == 0)
                                    break;
                                if (numerooo % 2 == 0)
                                    somap = somap + numerooo;
                                else
                                    somai = somai + numerooo;
                            }
                            Console.WriteLine("soma dos numeros pares: " + somap);
                            Console.WriteLine("soma dos numeros impares: " + somai);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}