﻿namespace SOLID._3___LSP.LSP.Violacao
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area
        {
            get { return Altura * Largura; }
        }
    }
}