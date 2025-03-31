namespace ConsoleAppDevRisk
{
    /// <summary>
    /// Class responsible for the list of categorization rules.
    /// </summary>
    public class Portfolio
    {
        public readonly List<Categorization> _category;

        public Portfolio()
        {
            _category = new List<Categorization>
                {
                new Expired(),
                new HighRisk(),
                new MediumRisk()
                };
        }

        /// <summary>
        /// Method that adds a new category categorization.
        /// </summary>
        /// <param name="categoryCategorization"></param>
        public void AddCategory(Categorization categoryCategorization)
        {
            _category.Add(categoryCategorization);
        }

        /// <summary>
        /// Method that Remove a category categorization.
        /// </summary>
        /// <param name="categoryCategorization"></param>
        public void RemoveCategory(Categorization categoryCategorization)
        {
            _category.Remove(categoryCategorization);
        }

        /// <summary>
        /// Method that Updates a categorization of a category.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="categorization"></param>
        public void UpdateCategory(int index, Categorization categorization)
        {
            if (index >= 0 && index < _category.Count)
            {
                _category[index] = categorization;
            }
        }

        /// <summary>
        /// Method that classifies an operation according to categorization.
        /// </summary>
        /// <param name="trade"></param>
        /// <param name="referenceDate"></param>
        /// <returns>Returns the Operation according to its categorization.</returns>
        public string ClassifyOperation(ITrade trade, DateTime referenceDate)
        {
            foreach (var category in _category)
            {
                var _category = category.Category(trade, referenceDate);
                if (_category != null)
                {
                    return _category;
                }
            }
            return "UNKNOWN";
        }

        /// <summary>
        /// Método que Exibir todas as regras.
        /// </summary>        
        public void DisplayCategorization()
        {
            int index = 0;
            foreach (var category in _category)
            {
                Console.WriteLine($"Number: {index} Category: {category.GetType().Name}");
                index++;
            }
        }
    }
}
