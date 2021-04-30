using System;

namespace Financeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Um cliente quer solicitar um empréstimo. Receba o valor solicitado, a quantidade de parcelas 
            desejada e a renda mensal comprovada. Só autorize empréstimos cuja parcela não ultrapasse 30% da renda (desconsidere os juros).*/
            decimal rendaMensal, valorParcela, valorContratado;
            int parcela;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■ ■ ■ ■ ■ ■ ANALISE DE CREDITO ■ ■ ■ ■ ■ ■\n");

            Console.ResetColor();

            Console.Write("Digite o valor a ser contratado: R$ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            valorContratado = Convert.ToDecimal(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Qual quantidade de parcelas deseja fazer: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            parcela = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            
            if (parcela <= 0 || parcela > 12)
            {
                Console.WriteLine($"Não é possivel parcela em {parcela} vez(es), escolha entre 1 a 12");
                
            }
            else
            {
            Console.Write("Informe sua renda mensal: R$ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            rendaMensal = Convert.ToDecimal(Console.ReadLine());
            Console.ResetColor();

            valorParcela = rendaMensal / parcela;
            
            if (valorParcela > (rendaMensal * 30/100))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Valor ultrapassou 30% de sua renda, crédito NEGADO\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"Valor APROVADO em {parcela} parcelas de {valorParcela:C}\n");    
                Console.ResetColor();            
            }
            }
            Console.WriteLine("Obrigado por usar o programa.");
            Console.WriteLine("Todos direito reservados Fabiano N Souza®");
            Console.ReadKey();
                    
        }
    }
}

