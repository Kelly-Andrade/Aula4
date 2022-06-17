Console.WriteLine("\n-----------\nEXERCÍCIO 3\n-----------");
string[] palavras = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª palavra");
    palavras[i] = Convert.ToString(Console.ReadLine());
}

IEnumerable<string> palavrasEmOrdem = from palavra in palavras
                                      orderby palavra.Length
                                      select palavra;

Console.WriteLine("\nPalavras em ordem crescente de tamanho: ");
foreach (string p in palavrasEmOrdem)
{
    Console.WriteLine(p);
}