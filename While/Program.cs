using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;
            double totalsalariofinal = 0;

            while (continuar == 1)
            {
                Console.Write("Qual o tipo de contratação?(A - Assalariado | C - Comissionado | H - Horista): ");
                string contratacao = Console.ReadLine().ToUpper();

                if (contratacao == "A")
                {
                    Console.Write("Insira o salário líquido do funcionário: ");
                    double asalarioliq = double.Parse(Console.ReadLine());

                    totalsalariofinal += asalarioliq;

                    Console.Write("Deseja continuar? (1 para sim | 0 para não): ");
                    continuar = int.Parse(Console.ReadLine());

                    Console.Clear();
                }
                else if (contratacao == "C")
                {
                    Console.Write("Insira o valor das vendas: ");
                    double cvendas = double.Parse(Console.ReadLine());

                    Console.Write("Insira a porcentagem de comissão: ");
                    double ccomissao = double.Parse(Console.ReadLine());

                    double csalarioliq = cvendas * (ccomissao / 100);

                    totalsalariofinal += csalarioliq;

                    Console.Write("Deseja continuar? (1 para sim | 0 para não): ");
                    continuar = int.Parse(Console.ReadLine());

                    Console.Clear();
                }
                else if (contratacao == "H")
                {
                    Console.Write("Insira a quantidade de horas trabalhadas: ");
                    double hhoras = double.Parse(Console.ReadLine());

                    Console.Write("Insira o valor pago por hora: ");
                    double hvalor = double.Parse(Console.ReadLine());

                    double hsalarioliq = hhoras * hvalor;

                    totalsalariofinal += hsalarioliq;

                    Console.Write("Deseja continuar? (1 para sim | 0 para não): ");
                    continuar = int.Parse(Console.ReadLine());

                    Console.Clear();
                }
                else
                {
                    Console.Write("A letra digitada não corresponde a um tipo de contratação");
                    Console.ReadKey();

                    Console.Write("Deseja continuar? (1 para sim | 0 para não): ");
                    continuar = int.Parse(Console.ReadLine());

                    Console.Clear();
                }
            }

            Console.Write("O total a ser pago para os funcionários é: " + totalsalariofinal);
            Console.ReadKey();
        }
    }
}