Console.WriteLine("\n-----------\nEXERCÍCIO 2\n-----------");
int[] pares = new int[10];
int[] impares = new int[10];
int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Informe o {i + 1}º numero: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        pares[i] = numeros[i];
    }
    else
    {
        impares[i] = numeros[i];
    }
}
Console.Write("\nPares: ");
foreach (int par in pares)
{
    if (par > 0)
    {
        Console.Write($"{par} ");
    }
}
Console.Write("\nÍmpares: ");
foreach (int impar in impares)
{
    if (impar > 0)
    {
        Console.Write($"{impar} ");
    }
}