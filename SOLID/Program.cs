using System;
using SOLID._2___OCP.OCP.Solucao_Extension_Methods;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");
            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    CaixaEletronico.MenuOperacoes();
                    CaixaEletronico.Operacoes();
                    break;
            }
        }
    }
}