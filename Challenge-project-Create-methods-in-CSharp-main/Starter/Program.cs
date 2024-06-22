using System;

Random random = new Random();
Console.CursorVisible = false;
int altura = Console.WindowHeight - 1;
int largura = Console.WindowWidth - 5;
bool deveSair = false;

// Posição do jogador no Console
int jogadorX = 0;
int jogadorY = 0;

// Posição da comida no Console
int comidaX = 0;
int comidaY = 0;

// Strings disponíveis para o jogador e comida
string[] estados = { "('-')", "(^-^)", "(X_X)" };
string[] comidas = { "@@@@@", "$$$$$", "#####" };

// String atual do jogador exibida no Console
string jogador = estados[0];

// Índice da comida atual
int comida = 0;

InicializarJogo();
while (!deveSair)
{
    Mover();
}

// Retorna true se o Terminal foi redimensionado
bool TerminalRedimensionado()
{
    return altura != Console.WindowHeight - 1 || largura != Console.WindowWidth - 5;
}

// Exibe comida aleatória em um local aleatório
void ExibirComida()
{
    // Atualiza a comida para um índice aleatório
    comida = random.Next(0, comidas.Length);

    // Atualiza a posição da comida para um local aleatório
    comidaX = random.Next(0, largura - jogador.Length);
    comidaY = random.Next(0, altura - 1);

    // Exibe a comida na localização
    Console.SetCursorPosition(comidaX, comidaY);
    Console.Write(comidas[comida]);
}

// Muda o jogador para combinar com a comida consumida
void MudarJogador()
{
    jogador = estados[comida];
    Console.SetCursorPosition(jogadorX, jogadorY);
    Console.Write(jogador);
}

// Temporariamente impede o jogador de se mover
void CongelarJogador()
{
    System.Threading.Thread.Sleep(1000);
    jogador = estados[0];
}

// Lê a entrada direcional do Console e move o jogador
void Mover()
{
    int ultimoX = jogadorX;
    int ultimoY = jogadorY;

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            jogadorY--;
            break;
        case ConsoleKey.DownArrow:
            jogadorY++;
            break;
        case ConsoleKey.LeftArrow:
            jogadorX--;
            break;
        case ConsoleKey.RightArrow:
            jogadorX++;
            break;
        case ConsoleKey.Escape:
            deveSair = true;
            break;
    }

    // Limpa os caracteres na posição anterior
    Console.SetCursorPosition(ultimoX, ultimoY);
    for (int i = 0; i < jogador.Length; i++)
    {
        Console.Write(" ");
    }

    // Mantém a posição do jogador dentro dos limites da janela do Terminal
    jogadorX = (jogadorX < 0) ? 0 : (jogadorX >= largura ? largura : jogadorX);
    jogadorY = (jogadorY < 0) ? 0 : (jogadorY >= altura ? altura : jogadorY);

    // Desenha o jogador na nova localização
    Console.SetCursorPosition(jogadorX, jogadorY);
    Console.Write(jogador);
}

// Limpa o console, exibe a comida e o jogador
void InicializarJogo()
{
    Console.Clear();
    ExibirComida();
    Console.SetCursorPosition(0, 0);
    Console.Write(jogador);
}
