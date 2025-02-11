int decimale(string v)
{
    int[] m = new int[v.Length];
    int somma = 0;

    for (int i = 0; i < v.Length; i++)
    {
        m[i] = v[i] - '0';
        somma = somma * 2 + m[i];
    }

    return somma;
}

Console.WriteLine("Dimmi il numero binario di massimo 8 cifre");
string v = Console.ReadLine();

int j = decimale(v);
Console.WriteLine("Il numero decimale è: " + j);