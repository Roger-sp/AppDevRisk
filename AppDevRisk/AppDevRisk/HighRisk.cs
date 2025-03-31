namespace ConsoleAppDevRisk
{
    public class HighRisk : Categorization
    {
        public override string Category(ITrade trade, DateTime referenceDate) =>
                                trade.Value > 1000000 && trade.ClientSector == "Private" ? "HIGHRISK" : null;
    }
}
