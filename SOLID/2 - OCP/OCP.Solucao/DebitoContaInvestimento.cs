namespace SOLID._2___OCP.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita conta de investimento
            // Isenta taxa
            return FormatarTransacao();
        }
    }
}