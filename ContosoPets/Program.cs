using System;

class Program
{
    static void Main()
    {
        string[,] ourAnimals = new string[5, 6]
        {
            { "1", "cão", "2", "pequeno, pelagem preta", "brincalhão", "Rex" },
            { "2", "gato", "1", "médio, pelagem branca", "calmo", "Mimi" },
            { "3", "cão", "3", "grande, pelagem marrom", "protetor", "Max" },
            { "4", "gato", "4", "pequeno, pelagem cinza", "curioso", "Luna" },
            { "5", "cão", "1", "médio, pelagem dourada", "amigável", "Buddy" }
        };

        while (true)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Listar todas as nossas informações atuais sobre os animais de estimação.");
            Console.WriteLine("2. Atribuir valores aos campos da matriz ourAnimals.");
            Console.WriteLine("Digite 'Exit' para sair do programa.");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "exit")
            {
                break;
            }

            switch (choice)
            {
                case "1":
                    ListAllAnimals(ourAnimals);
                    break;
                case "2":
                    AddNewAnimal(ref ourAnimals);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                    break;
            }
        }
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
