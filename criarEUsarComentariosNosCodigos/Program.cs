//criei uma variável com o nome de "firstName" e uma variável com o nome de "widgetsSold"
//com isso executei para mostrar o valor da variável "firstName" e o valor da variável "widgetsSold"
string firstName = "Renato";
int age = 36;
Console.WriteLine($"{firstName} á sua idade é {age} anos .");

/*
O seguinte código cria cinco OrderIDs aleatórios
para testar o processo de detecção de fraudes. Os OrderIDs
 consistem em uma letra de A a E e um número de três dígitos. Ex. A123..
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
