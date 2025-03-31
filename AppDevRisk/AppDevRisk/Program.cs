using System.Globalization;

namespace ConsoleAppDevRisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("#####################################################");
            Console.WriteLine("                  *    AppDevRisk     *              ");
            Console.WriteLine("#####################################################");
            Console.ResetColor();

            Console.WriteLine("Entre com a data de referência no formato MM/dd/yyyy.");
            string referenceDateInput = Console.ReadLine().Trim();
            DateTime referenceDate = DateTime.ParseExact(referenceDateInput, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre o número de operações.");
            int n = int.Parse(Console.ReadLine().Trim());

            Portfolio portfolio = new Portfolio();
            List<string> category = new List<string>();
            Console.WriteLine("Entre com a operação.");

            for (int i = 0; i < n; i++)
            {
                string[] operationData = Console.ReadLine().Split();

                double value = double.Parse(operationData[0], CultureInfo.InvariantCulture);
                string clientSector = operationData[1];
                DateTime nextPaymentDate = DateTime.ParseExact(operationData[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);

                ITrade trade = new Trade(value, clientSector, nextPaymentDate);
                category.Add(portfolio.ClassifyOperation(trade, referenceDate).Trim());
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            category.ForEach(Console.WriteLine);
            Console.ResetColor();
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Adicionar categoria");
                Console.WriteLine("2. Remover categoria");
                Console.WriteLine("3. Atualizar categoria");
                Console.WriteLine("4. Exibir categorias");
                Console.WriteLine("5. Sair");
                
                var option = Console.ReadLine().Trim();
               
                if (option == "5") break;

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Adicione uma nova categoria previamente cadastrada (exemplo: Expired, HighRisk, MediumRisk):");
                        string categoryToAdd = Console.ReadLine().Trim();
                        if (categoryToAdd == "Expired")
                            portfolio.AddCategory(new Expired());
                        else if (categoryToAdd == "HighRisk")
                            portfolio.AddCategory(new HighRisk());
                        else if (categoryToAdd == "MediumRisk")
                            portfolio.AddCategory(new MediumRisk());
                        break;

                    case "2":
                        Console.WriteLine("Digite o número da categoria para remover:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        portfolio.DisplayCategorization();
                        Console.ResetColor();
                        int indexToRemove = int.Parse(Console.ReadLine().Trim());
                        int arraySize = portfolio._category.Count;
                        if(indexToRemove+1 > arraySize)
                        {
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($" > Número inválido: {indexToRemove}.");
                            Console.ResetColor();
                            continue;
                        }
                        portfolio.RemoveCategory(portfolio._category[indexToRemove]);
                        break;

                    case "3":
                        Console.WriteLine("Digite o índice da categoria para atualizar:");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        portfolio.DisplayCategorization();
                        Console.ResetColor();
                        int indexToUpdate = int.Parse(Console.ReadLine().Trim());
                        Console.WriteLine("Digite a nova categoria (exemplo: Expired):");
                        string newCategory = Console.ReadLine().Trim();

                        if (newCategory == "Expired")
                            portfolio.UpdateCategory(indexToUpdate, new Expired());
                        else if (newCategory == "HighRisk")
                            portfolio.UpdateCategory(indexToUpdate, new HighRisk());
                        else if (newCategory == "MediumRisk")
                            portfolio.UpdateCategory(indexToUpdate, new MediumRisk());
                        break;

                    case "4":
                        portfolio.DisplayCategorization();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
