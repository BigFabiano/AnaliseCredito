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
            string parcelaDigitada, rendaDigitada, valorDigitada;
            bool numValido, numContratado, numRenda;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■ ■ ■ ■ ■ ■ ANALISE DE CREDITO ■ ■ ■ ■ ■ ■\n");

            Console.ResetColor();

            Console.Write("Digite o valor a ser contratado: R$ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            valorDigitada = Console.ReadLine();
            numContratado = decimal.TryParse(valorDigitada, out valorContratado);
            Console.ResetColor();
            if (numContratado == false || valorContratado <= 0 || valorContratado <= 1000)
            {
                Console.WriteLine("Para seu CONSIGNADO, digite um valor acima de R$ 1000,00");
            }
            else
            {
            Console.Write("Qual quantidade de parcelas deseja fazer: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            parcelaDigitada = Console.ReadLine();
            numValido = Int32.TryParse(parcelaDigitada, out parcela);
            Console.ResetColor();
            
            
            if (numContratado == false || parcela <= 0 || parcela > 12 || numValido == false)
            {
                Console.WriteLine($"Não é possivel parcela em {parcela} vez(es), escolha entre 1 a 12");
                
            }
            else
            {
            Console.Write("Informe sua renda mensal: R$ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            rendaDigitada = Console.ReadLine();
            numRenda = decimal.TryParse(rendaDigitada, out rendaMensal);
            Console.ResetColor();
            if (numRenda == false || rendaMensal <= 0)
            {
                Console.WriteLine("Error!!! - Digite um valor númerico!");
            }
            else
            {
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
            }
            }
            Console.WriteLine("Obrigado por usar o programa.");
            Console.WriteLine("Todos direito reservados Fabiano N Souza®");
            Console.ReadKey();
                    
        }
    }
}

