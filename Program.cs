using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double emprestimo, parcelas, renda, porcentagem,valorParcela;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■      Analise Credito    ■");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■");   

            Console.Write("Digite o valor do emprestimo...: ");
            emprestimo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas...: ");
            parcelas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua Renda...: ");
            renda = Convert.ToDouble(Console.ReadLine());

            porcentagem = renda / 100 * 30;

            valorParcela = (emprestimo / parcelas);

            if(porcentagem > valorParcela)
            {
                Console.WriteLine("\nEmprestimo Autorizado");
            }
            else if(porcentagem < valorParcela)
            {
                 Console.WriteLine("\nEmprestimo Não Aurolizado");
            }
    
        } 

    }
}