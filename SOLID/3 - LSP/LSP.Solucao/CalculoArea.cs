using System;

namespace SOLID._3___LSP.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Paralelograma ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            Console.Clear();
            Console.WriteLine("Digite a altura: ");
            var altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a largura");
            var largura = Convert.ToInt32(Console.ReadLine());

            //var quad = new Quadrado(altura, largura);
            var ret = new Retangulo(altura, largura);

            ObterAreaRetangulo(ret);
            //ObterAreaRetangulo(quad);
        }
    }
}