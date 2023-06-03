Console.WriteLine(" jogo do adivinha\n");
Console.Clear();
Console.WriteLine(" adivinha\n");

Console.Write("o número que eu estou pensando está entre 1 e 100");
Thread.Sleep(500);Console.Write(".");
Thread.Sleep(500);Console.Write(".");
Thread.Sleep(500);Console.WriteLine("tudo pronto! agora, quero que você entre na brincadeira e tente adivinhar o número que eu estou pensando. vamos lá?\n");

int Palpite = 0;
int numerosecreto = 48;
int tentativa = 1;

bool acertou = false;

do
{
    Console.Write($"\n okay! agora dê o seu palpite #{tentativa}?");

    if (!Int32.TryParse(Console.ReadLine(), out Palpite) || Palpite <1 || Palpite >100)
    continue;

    int erro = Palpite - numerosecreto;
    int distanciaerro = Math.Abs(erro);

    acertou = (Palpite == numerosecreto);

    if (!acertou)
    {
        tentativa ++;
        
        if (distanciaerro <=45)
        exibecolorido("pelando! \n", ConsoleColor.DarkMagenta);

        else if (distanciaerro<=40)
        exibecolorido("quente!\n", ConsoleColor.DarkBlue);

        else
        {
            if(distanciaerro>=30)
            exibecolorido("ihh.. ta frio hein!...", ConsoleColor.Blue);

            bool tentarmaisalto = Math.Sign(erro) == -1;

            Console.Write("tente um numero mais");
            exibecolorido(tentarmaisalto ? "alto" : "baixo, tentarmaisalto? ", ConsoleColor.Blue);
            Console.WriteLine(".");
        }
    }
}
while (tentativa <=48 && ! acertou);

Console.Write("\n o numero que escolhi era");
exibecolorido( numerosecreto.ToString(), ConsoleColor.DarkGreen);
Console.WriteLine("\n");

exibecolorido( acertou? "parabens!!!" : "tente novamente.", ConsoleColor.DarkRed);

void exibecolorido(string texto, ConsoleColor cor )
{
    Console.ForegroundColor= cor;
    Console.Write(texto);
    Console.ResetColor();
}

        

        
        
        
    
    


