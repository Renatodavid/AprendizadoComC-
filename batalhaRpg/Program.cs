using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int heroHealth = 10;
        int monsterHealth = 10;

        do
        {
            // Herói ataca primeiro
            int heroAttack = random.Next(1, 11);
            monsterHealth -= heroAttack;
            Console.WriteLine($"Herói ataca e causa {heroAttack} de dano. Integridade do monstro restante: {monsterHealth}");

            // Verifica se o monstro ainda está vivo
            if (monsterHealth <= 0)
            {
                Console.WriteLine("O herói venceu!");
                break;
            }

            // Monstro ataca
            int monsterAttack = random.Next(1, 11);
            heroHealth -= monsterAttack;
            Console.WriteLine($"Monstro ataca e causa {monsterAttack} de dano. Integridade do herói restante: {heroHealth}");

            // Verifica se o herói ainda está vivo
            if (heroHealth <= 0)
            {
                Console.WriteLine("O monstro venceu!");
                break;
            }

        } while (heroHealth > 0 && monsterHealth > 0);
    }
}

