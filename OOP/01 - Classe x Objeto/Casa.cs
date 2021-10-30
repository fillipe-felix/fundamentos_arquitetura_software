namespace OOP._01___Classe_x_Objeto
{
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            //Definição de Objeto
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 1000000,
                NumeroVagas = 3
            };
        }
    }
}