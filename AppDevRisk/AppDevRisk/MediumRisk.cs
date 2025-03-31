using ConsoleAppDevRisk;
public class MediumRisk : Categorization
{
    public override string Category(ITrade trade, DateTime referenceDate) =>
                            trade.Value > 1000000 && trade.ClientSector == "Public" ? "MEDIUMRISK" : null;
}