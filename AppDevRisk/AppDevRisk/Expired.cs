namespace ConsoleAppDevRisk
{
    public class Expired : Categorization
    {
        public override string Category(ITrade trade, DateTime referenceDate) => 
                                (referenceDate - trade.NextPaymentDate).Days > 30 ? "EXPIRED" : null;
    }
}
