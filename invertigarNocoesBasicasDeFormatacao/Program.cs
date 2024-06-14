/*string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");*/




/*
decimal price = 123.45m;
int discount = 50;
var total = price - discount;
Console.WriteLine($"Total: {total:C}");
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
Console.WriteLine($"Measurement: {measurement:N4} units");
Recapitulação
Aqui estão as informações mais importantes desta unidade sobre a formatação da cadeia de caracteres:

Você pode usar a formatação composta ou a interpolação de cadeia de caracteres para formatar cadeias de caracteres.
Com a formatação composta, você usa um modelo de cadeia de caracteres que contém um ou mais tokens de substituição
no formato {0}. Forneça também uma lista de argumentos correspondidos com os tokens de substituição baseados em sua
ordem. A formatação composta funciona ao usar string.Format() ou Console.WriteLine().
Com a interpolação de cadeia de caracteres, você usa um modelo de cadeia de caracteres que contém os nomes
de variável que você deseja substituir entre chaves. Use a diretiva $ antes do modelo de cadeia de caracteres 
para indicar que você deseja que a cadeia de caracteres seja interpolada.
Formate a moeda usando um especificador :C.
Formate os números usando um especificador :N. Controle a precisão (número de valores após o ponto decimal)
usando um número após o :N, como {myNumber:N3}.
Formate as porcentagens usando o especificador de formato :P.
A formatação de moedas e números depende da cultura do usuário final,
um código de cinco caracteres que inclui o país/região e o idioma do usuário 
(de acordo com as configurações do computador).

 */
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

