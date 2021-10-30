namespace OOP._02___Pilares_OOP
{
    public class AutomacaoCafe
    {
        public void ServiceCafe()
        {
            var expresso = new CafeteiraExpressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
}