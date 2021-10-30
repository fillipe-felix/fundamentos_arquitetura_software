namespace SOLID._2___OCP.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita conta corrente
            return FormatarTransacao();
        }
    }
}