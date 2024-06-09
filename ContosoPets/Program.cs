using System;

class Program
{
    static void Main()
    {
        // Dados de exemplo usando uma matriz multidimensional
        string[,] ourAnimals = new string[5, 6]
        {
            { "1", "cão", "2", "pequeno, pelagem preta", "brincalhão", "Rex" },
            { "2", "gato", "1", "médio, pelagem branca", "calmo", "Mimi" },
            { "3", "cão", "3", "grande, pelagem marrom", "protetor", "Max" },
            { "4", "gato", "4", "pequeno, pelagem cinza", "curioso", "Luna" },
            { "5", "cão", "1", "médio, pelagem dourada", "amigável", "Buddy" }
        };

        string userInput;
        do
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Listar todas as nossas informações atuais sobre os animais de estimação.");
            Console.WriteLine("2. Atribuir valores aos campos da matriz ourAnimals.");
            Console.WriteLine("3. Verificar se os dados de idade e descrição física dos animais estão completos.");
            Console.WriteLine("4. Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.");
            Console.WriteLine("5. Editar a idade do animal.");
            Console.WriteLine("6. Editar a descrição de personalidade do animal.");
            Console.WriteLine("7. Exibir todos os gatos com uma característica especificada.");
            Console.WriteLine("8. Exibir todos os cães com uma característica especificada.");
            Console.WriteLine("Digite 'sair' para sair do programa.");

            userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "1":
                    ListAllAnimals(ourAnimals);
                    break;
                case "2":
                    AddNewAnimal(ref ourAnimals);
                    break;
                case "3":
                    Console.WriteLine("Funcionalidade ainda não implementada: Verificar se os dados de idade e descrição física dos animais estão completos.");
                    break;
                case "4":
                    Console.WriteLine("Funcionalidade ainda não implementada: Verificar se os dados de apelido e descrição de personalidade dos animais estão completos.");
                    break;
                case "5":
                    Console.WriteLine("Funcionalidade ainda não implementada: Editar a idade do animal.");
                    break;
                case "6":
                    Console.WriteLine("Funcionalidade ainda não implementada: Editar a descrição de personalidade do animal.");
                    break;
                case "7":
                    Console.WriteLine("Funcionalidade ainda não implementada: Exibir todos os gatos com uma característica especificada.");
                    break;
                case "8":
                    Console.WriteLine("Funcionalidade ainda não implementada: Exibir todos os cães com uma característica especificada.");
                    break;
                case "sair":
                    Console.WriteLine("Saindo do programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                    break;
            }
        } while (userInput.ToLower() != "sair");
    }

    static void ListAllAnimals(string[,] animals)
    {
        Console.WriteLine("\nLista de todos os animais:");
        for (int i = 0; i < animals.GetLength(0); i++)
        {
            for (int j = 0; j < animals.GetLength(1); j++)
            {
                Console.Write($"{animals[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void AddNewAnimal(ref string[,] animals)
    {
        int newId = animals.GetLength(0) + 1;
        string[,] tempArray = new string[newId, 6];
        for (int i = 0; i < animals.GetLength(0); i++)
        {
            for (int j = 0; j < animals.GetLength(1); j++)
            {
                tempArray[i, j] = animals[i, j];
            }
        }

        Console.Write("Espécie do animal (cão ou gato): ");
        string species = Console.ReadLine();
        Console.Write("Idade do animal (em anos): ");
        string age = Console.ReadLine();
        Console.Write("Descrição das condições/características físicas do animal: ");
        string physicalDesc = Console.ReadLine();
        Console.Write("Descrição da personalidade do animal: ");
        string personalityDesc = Console.ReadLine();
        Console.Write("Apelido do animal: ");
        string nickname = Console.ReadLine();

        tempArray[newId - 1, 0] = newId.ToString();
        tempArray[newId - 1, 1] = species;
        tempArray[newId - 1, 2] = age;
        tempArray[newId - 1, 3] = physicalDesc;
        tempArray[newId - 1, 4] = personalityDesc;
        tempArray[newId - 1, 5] = nickname;

        animals = tempArray;

        Console.WriteLine("Novo animal adicionado com sucesso!");
    }
}
