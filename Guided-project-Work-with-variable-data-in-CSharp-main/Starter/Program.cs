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

// #3 array usado para armazenar dados em tempo de execução, não há dados persistentes
string[,] nossosAnimais = new string[maxAnimais, 7];
string[,] sugestoesAnimais = new string[maxAnimais, 7];

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
            sugestoesAnimais = "100.00";
            break;

        case 1:
            especieAnimal = "cachorro";
            idAnimal = "c2";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "macho de porte grande, cor marrom avermelhada, golden retriever, pesando cerca de 40 kg. treinado para fazer necessidades fora de casa.";
            descricaoPersonalidadeAnimal = "adora ter suas orelhas coçadas quando te cumprimenta na porta, ou a qualquer momento! adora se encostar e dar abraços de cachorro.";
            apelidoAnimal = "gus";
            sugestoesAnimais = "100.00";
            break;

            // #2 variáveis que suportam a entrada de dados
            decimal decimalDoacao = 0.00m;
            int maxAnimais = 8;
string? resultadoLeitura;
string selecaoMenu = "";

// #3 array usado para armazenar dados em tempo de execução, não há dados persistentes
string[,] nossosAnimais = new string[maxAnimais, 6];

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
                        sugestoesAnimais = "100.00";
                        break;

                    case 1:
                        especieAnimal = "cachorro";
                        idAnimal = "c2";
                        idadeAnimal = "9";
                        descricaoFisicaAnimal = "macho de porte grande, cor marrom avermelhada, golden retriever, pesando cerca de 40 kg. treinado para fazer necessidades fora de casa.";
                        descricaoPersonalidadeAnimal = "adora ter suas orelhas coçadas quando te cumprimenta na porta, ou a qualquer momento! adora se encostar e dar abraços de cachorro.";
                        apelidoAnimal = "gus";
                        sugestoesAnimais = "100.00";
                        break;

                    case 2:
                        especieAnimal = "gato";
                        idAnimal = "g3";
                        idadeAnimal = "1";
                        descricaoFisicaAnimal = "fêmea pequena, cor branca, pesando cerca de 4 kg. treinada para usar a caixa de areia.";
                        descricaoPersonalidadeAnimal = "amigável";
                        apelidoAnimal = "neve";
                        sugestoesAnimais = "100.00";
                        break;

                    case 3:
                        especieAnimal = "gato";
                        idAnimal = "g4";
                        idadeAnimal = "3";
                        descricaoFisicaAnimal = "Fêmea de porte médio, pelos longos, cor amarela, pesando cerca de 5 kg. Usa caixa de areia.";
                        descricaoPersonalidadeAnimal = "Uma gata que adora pessoas e gosta de sentar no seu colo.";
                        apelidoAnimal = "leão";
                        sugestoesAnimais = "100.00";
                        break;

                    default:
                        especieAnimal = "";
                        idAnimal = "";
                        idadeAnimal = "";
                        descricaoFisicaAnimal = "";
                        descricaoPersonalidadeAnimal = "";
                        apelidoAnimal = "";
                        break;

                }

                nossosAnimais[i, 0] = "ID #: " + idAnimal;
                nossosAnimais[i, 1] = "Espécie: " + especieAnimal;
                nossosAnimais[i, 2] = "Idade: " + idadeAnimal;
                nossosAnimais[i, 3] = "Apelido: " + apelidoAnimal;
                nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaAnimal;
                nossosAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
                nossosAnimais[i, 6] = "Sugestões: " + sugestoesAnimais;


                if (!decimal.TryParse(doacaoSugerida, out decimalDoacao))
                {
                    decimalDoacao = 45.00m; // se doacaoSugerida NÃO for um número, define o padrão para 45.00
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
                        Console.WriteLine(nossosAnimais[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPressione a tecla Enter para continuar");
            resultadoLeitura = Console.ReadLine();

            break;

        case "2":
                        // Exibir todos os cachorros com uma característica especificada
                        //  Console.WriteLine("\nEM CONSTRUÇÃO - por favor, volte no próximo mês para ver o progresso.");
                        // Console.WriteLine("Pressione a tecla Enter para continuar."); apagado para entrar com nova configuração
                        // Display all dogs with a specified characteristic

                        string cachorroCaracteriscticas = "";
                        while(cachorroCaracteriscticas == "")
                        {

                        Console.WriteLine($"\nDigite uma caracteristica desejada do cachorro para pesquisar: ");
                        readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                cachorroCaracteriscticas = readResult.ToLower().Trim();
                            }

                        }
                        if (nenhumaCorrespondenciaCao)
                        {
                            Console.WriteLine($"\nNenhum dos nossos cães correspondente à caracteristcas especifica:{cachorroCaracteriscticas} foi encontrado.");
                        }
                            Console.WriteLine("Pressione a tecla Enter para continuar.");
                        string cachorroDescricao = "";]
                       bool nenhumaCorrespondenciaCao = true;

                        // #6 percorra o array nossosAnimais para procurar animais correspondentes
                        for (int i = 0; i < maxAnimais; i++)
                        {
                            if (nossosAnimais[i, 1].Contains(cachorroCaracteriscticas))
                            {
                                cachorroDescricao = nossosAnimais[i, 4]+ "\n\r" + nossosAnimais[i, 5];
                                // #7 Pesquise descrições combinadas e reporte os resultados
                                if(cachorroDescricao.Contains(cachorroCaracteriscticas))
                                {
                                    Console.WriteLine($"\nNosso cachorro {nossosAnimais[i,3]} eu amei!");
                                    Console.WriteLine(cachorroDescricao);
                                }
                            }
                        }
                        readResult = Console.ReadLine();
                        break;
                        
            

        default:
            break;
    }

} while (selecaoMenu != "sair");
