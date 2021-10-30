using System;

namespace SOLID._3___LSP.LSP.Solucao
{
    public abstract class Paralelograma
    {
        public int Altura { get; private set; }
        public int Largura { get; private set;}
        public double Area
        {
            get { return Altura * Largura; }
        }

        protected Paralelograma(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }
    }
}