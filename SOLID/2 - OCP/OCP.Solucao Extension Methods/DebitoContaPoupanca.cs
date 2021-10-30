namespace SOLID._2___OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // logica de negócio para debito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}