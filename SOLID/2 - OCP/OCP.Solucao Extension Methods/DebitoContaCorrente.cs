namespace SOLID._2___OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // logica de negócio para debito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}