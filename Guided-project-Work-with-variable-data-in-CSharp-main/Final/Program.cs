﻿// Program.cs
// #1 o array nossosAnimais armazenará o seguinte: 
string especieAnimal = "";
string idAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string apelidoAnimal = "";
string doacaoSugerida = "";

// #2 variáveis que suportam a entrada de dados
int maxAnimais = 8;
string? resultadoLeitura;
string selecaoMenu = "";
decimal decimalDoacao = 0.00m;

// #3 array usado para armazenar dados em tempo de execução, não há dados persistentes
string[,] nossosAnimais = new string[maxAnimais, 7];

// #4 criar dados de exemplo nas entradas do array nossosAnimais
for (int i = 0; i < maxAnimais; i++)
{
    switch (i)
    {
        case 0:
            especieAnimal = "cachorro";
            idAnimal = "c1";
            idadeAnimal = "2";
            descricaoFisicaAnimal = "fêmea de porte médio, cor creme, golden retriever, pesando cerca de 20 kg. treinada para fazer necessidades fora de casa.";
            descricaoPersonalidadeAnimal = "adora ter sua barriga coçada e gosta de perseguir seu rabo. dá muitos beijos.";
            apelidoAnimal = "lola";
            doacaoSugerida = "85.00";
            break;

        case 1:
            especieAnimal = "cachorro";
            idAnimal = "c2";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "macho de porte grande, cor marrom avermelhada, golden retriever, pesando cerca de 40 kg. treinado para fazer necessidades fora de casa.";
            descricaoPersonalidadeAnimal = "adora ter suas orelhas coçadas quando te cumprimenta na porta, ou a qualquer momento! adora se encostar e dar abraços de cachorro.";
            apelidoAnimal = "gus";
            doacaoSugerida = "49.99";
            break;

        case 2:
            especieAnimal = "gato";
            idAnimal = "g3";
            idadeAnimal = "1";
            descricaoFisicaAnimal = "fêmea pequena, cor branca, pesando cerca de 4 kg. treinada para usar a caixa de areia.";
            descricaoPersonalidadeAnimal = "amigável";
            apelidoAnimal = "neve";
            doacaoSugerida = "40.00";
            break;

        case 3:
            especieAnimal = "gato";
            idAnimal = "g4";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "leão";
            doacaoSugerida = "";

            break;

        default:
            especieAnimal = "";
            idAnimal = "";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "";
            doacaoSugerida = "";
            break;

    }

    nossosAnimais[i, 0] = "ID #: " + idAnimal;
    nossosAnimais[i, 1] = "Espécie: " + especieAnimal;
    nossosAnimais[i, 2] = "Idade: " + idadeAnimal;
    nossosAnimais[i, 3] = "Apelido: " + apelidoAnimal;
    nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaAnimal;
    nossosAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
// #1 o array nossosAnimais armazenará o seguinte: 
string especieAnimal = "";
string idAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string apelidoAnimal = "";
string doacaoSugerida = "";

// #2 variáveis que suportam a entrada de dados
int maxAnimais = 8;
string? resultadoLeitura;
string selecaoMenu = "";
decimal decimalDoacao = 0.00m;

// #3 array usado para armazenar dados em tempo de execução, não há dados persistentes
string[,] nossosAnimais = new string[maxAnimais, 7];

// #4 criar dados de exemplo nas entradas do array nossosAnimais
for (int i = 0; i < maxAnimais; i++)
{
    switch (i)
    {
        case 0:
            especieAnimal = "cachorro";
            idAnimal = "c1";
            idadeAnimal = "2";
            descricaoFisicaAnimal = "fêmea de porte médio, cor creme, golden retriever, pesando cerca de 20 kg. treinada para fazer necessidades fora de casa.";
            descricaoPersonalidadeAnimal = "adora ter sua barriga coçada e gosta de perseguir seu rabo. dá muitos beijos.";
            apelidoAnimal = "lola";
            doacaoSugerida = "85.00";
            break;

        case 1:
            especieAnimal = "cachorro";
            idAnimal = "c2";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "macho de porte grande, cor marrom avermelhada, golden retriever, pesando cerca de 40 kg. treinado para fazer necessidades fora de casa.";
            descricaoPersonalidadeAnimal = "adora ter suas orelhas coçadas quando te cumprimenta na porta, ou a qualquer momento! adora se encostar e dar abraços de cachorro.";
            apelidoAnimal = "gus";
            doacaoSugerida = "49.99";
            break;

        case 2:
            especieAnimal = "gato";
            idAnimal = "g3";
            idadeAnimal = "1";
            descricaoFisicaAnimal = "fêmea pequena, cor branca, pesando cerca de 4 kg. treinada para usar a caixa de areia.";
            descricaoPersonalidadeAnimal = "amigável";
            apelidoAnimal = "neve";
            doacaoSugerida = "40.00";
            break;

        case 3:
            especieAnimal = "gato";
            idAnimal = "g4";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "leão";
            doacaoSugerida = "";

            break;

        default:
            especieAnimal = "";
            idAnimal = "";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            apelidoAnimal = "";
            doacaoSugerida = "";
            break;

    }

    nossosAnimais[i, 0] = "ID #: " + idAnimal;
    nossosAnimais[i, 1] = "Espécie: " + especieAnimal;
    nossosAnimais[i, 2] = "Idade: " + idadeAnimal;
    nossosAnimais[i, 3] = "Apelido: " + apelidoAnimal;
    nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaAnimal;
    nossosAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;

    if (!decimal.TryParse(doacaoSugerida, out decimalDoacao))
    {
        decimalDoacao = 45.00m; // se doacaoSugerida NÃO for um número, padrão para 45.00
    }
    nossosAnimais[i, 6] = $"Doação Sugerida: {decimalDoacao:C2}";
}

// #5 exibir as opções do menu principal
do
{
    // NOTA: o método Console.Clear está lançando uma exceção em sessões de depuração
    Console.Clear();

    Console.WriteLine("Bem-vindo ao aplicativo Contoso PetFriends. Suas opções de menu principais são:");
    Console.WriteLine(" 1. Listar todas as informações dos nossos animais atuais");
    Console.WriteLine(" 2. Exibir todos os cachorros com uma característica especificada");
    Console.WriteLine();
    Console.WriteLine("Digite o número da sua seleção (ou digite Sair para sair do programa)");

    resultadoLeitura = Console.ReadLine();
    if (resultadoLeitura != null)
    {
        selecaoMenu = resultadoLeitura.ToLower();
    }

    // usar switch-case para processar a opção de menu selecionada
    switch (selecaoMenu)
    {
        case "1":
            // listar todas as informações dos animais
            for (int i = 0; i < maxAnimais; i++)
            {
                if (nossosAnimais[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(nossosAnimais[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPressione a tecla Enter para continuar");
            resultadoLeitura = Console.ReadLine();

            break;

        case "2":
            // Exibir todos os cachorros com uma característica especificada

            string caracteristicaCachorro = "";

            while (caracteristicaCachorro == "")
            {
                // pedir ao usuário para inserir características físicas para pesquisar
                Console.WriteLine($"\nDigite uma característica desejada de cachorro para procurar");
                resultadoLeitura = Console.ReadLine();
                if (resultadoLeitura != null)
                {
                    caracteristicaCachorro = resultadoLeitura.ToLower().Trim();
                }
            }

            bool semCorrespondenciasCachorro = true;
            string descricaoCachorro = "";

            // #6 percorrer o array nossosAnimais para procurar animais correspondentes
            for (int i = 0; i < maxAnimais; i++)
            {
                bool correspondeCachorro = true;

                if (nossosAnimais[i, 1].Contains("cachorro"))
                {

                    if (correspondeCachorro == true)
                    {
                        // #7 Procurar descrições combinadas e relatar resultados
                        descricaoCachorro = nossosAnimais[i, 4] + "\n" + nossosAnimais[i, 5];


                        if (descricaoCachorro.Contains(caracteristicaCachorro))
                        {
                            Console.WriteLine($"\nNosso cachorro {nossosAnimais[i, 3]} é uma correspondência!");
                            Console.WriteLine(descricaoCachorro);

                            semCorrespondenciasCachorro = false;
                        }
                    }
                }
            }

            if (semCorrespondenciasCachorro)
            {
                Console.WriteLine("Nenhum de nossos cachorros é uma correspondência para: " + caracteristicaCachorro);
            }

            Console.WriteLine("\n\rPressione a tecla Enter para continuar");
            resultadoLeitura = Console.ReadLine();

            break;

        default:
            break;
    }

} while (selecaoMenu != "sair");
