Console.WriteLine("\n-----------\nEXERCÍCIO 1\n-----------");
int[] valores = new int[10];
int[] multiplicar = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Informe o {i + 1}º numero: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());
    multiplicar[i] = 5 * valores[i];
}

Console.Write("\nValores inseridos: ");
foreach (int valor in valores)
{
    Console.Write($"{valor} ");
}

Console.Write("\nValores inseridos multiplicados por 5: ");
foreach (int mult in multiplicar)
{
    Console.Write($"{mult} ");
}
