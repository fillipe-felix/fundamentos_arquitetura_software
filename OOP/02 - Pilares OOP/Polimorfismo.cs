namespace OOP._02___Pilares_OOP
{
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem) : base(nome, voltagem)
        {
        }

        public CafeteiraExpressa() : base("Padrao", 220)
        {
            
        }

        private static void AquecerAgua()
        {
            
        }

        private static void MoerGraos()
        {
            
        }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            //Etc...
        }

        public override void Testar()
        {
            //teste de cafeteira
        }

        public override void Ligar()
        {
            //Verificr recipiente de agua
        }

        public override void Desligar()
        {
            //Resfriar aquecedor
        }
    }
}