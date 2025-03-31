namespace ConsoleAppDevRisk
{
    public abstract class Categorization
    {
        public abstract string Category(ITrade trade, DateTime referenceDate);
    }
}