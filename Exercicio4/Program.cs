Console.WriteLine("\n-----------\nEXERCÍCIO 4\n-----------");

string[] simbolos = { "pedra", "papel", "tesoura" };
int suaVitoria = 0, vitoriaPC = 0, empate = 0;
string opcao = "s";
while (opcao == "s")
{
    Console.Write("Quantas rodadas iremos fazer? ");
    int rodadas = int.Parse(Console.ReadLine());

    for (int i = 0; i < rodadas; i++)
    {
        Console.Write("\nSua vez de jogar!\nDigite 0 para pedra, 1 para papel e 2 para tesoura:");
        int jogada = int.Parse(Console.ReadLine());

        Random random = new Random();
        int PC = random.Next(0, 3);
        Console.WriteLine(PC);

        if (jogada != 0 && jogada != 1 && jogada != 2)
        {
            Console.WriteLine("Você inseriu uma jogada inválida. Tente novamente.");
        }

        else
        {
            if (jogada == PC)
            {
                empate++;
                Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e vocês empataram.");
            }
            else if (jogada == 0)
            {
                if (PC == 1)
                {
                    vitoriaPC++;
                    Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e você perdeu.");
                }
                else 
                {
                    suaVitoria++;
                    Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e você venceu.");
                }
            }
            else if (jogada == 1)
            {
                if (PC == 0)
                {
                    suaVitoria++;
                    Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e você venceu.");
                }
                else 
                {
                    vitoriaPC++;
                    Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e você perdeu.");
                }
            }
            else 
            {
                if (PC == 0)
                {
                    vitoriaPC++;
                    Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e você perdeu.");
                }
                else 
                {
                    suaVitoria++;
                    Console.WriteLine($"\nO computador escolheu {simbolos[PC]} e você venceu.");
                }
            }
        }
    }

    Console.WriteLine("\nDeseja continuar? Digite s para sim e n para não.");
    opcao = Console.ReadLine();
}

Console.WriteLine("\nRESULTADO FINAL: ");
if (suaVitoria > vitoriaPC)
{
    Console.WriteLine($"Você venceu!");
}
else if (vitoriaPC > suaVitoria)
{
    Console.WriteLine("O computador venceu!");
}
else
{
    Console.WriteLine("Empate!");
}
Console.WriteLine($"\nTOTAL GERAL: \nVocê venceu {suaVitoria} rodada(s).\nO computador venceu {vitoriaPC} rodada(s).\nHouveram {empate} empate(s).");

