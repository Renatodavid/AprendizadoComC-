/*Concluir uma atividade de desafio usando expressões boolianas
 Desafio da lógica de decisão
Neste desafio, você implementará a lógica de decisão com base em uma série de regras de negócios.
As regras de negócios especificam o acesso que será concedido aos usuários com base nas respectivas
permissões baseadas em função e no nível de carreira. Os branches de código exibirão uma mensagem
diferente para cada usuário, de acordo com as respectivas permissões e o nível.*/
/*
Random coin = new Random();

Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");*/


string permission = "Admin|Manager";
int level = 19;

if (permission.Contains("Admin"))
{
    if (level > 60)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}