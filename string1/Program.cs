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


Console.WriteLine("Dimmi il numero binario di massimo 8 cifre ");
string v = Console.ReadLine();

Console.WriteLine("Dimmi la frase che vuoi ");
string frase = Console.ReadLine();
string[] frase1 = frase.Split(" ");
string frase2 = frase.Substring(0, frase.Length/2);
string frase3 = frase.Substring(frase.Length/2);
string risultato = "";
//es 1
int j = decimale(v);
Console.WriteLine("Il numero decimale è: " + j);
//es 2
for (int i = 0; i < frase1.Length; i++)
{
    if (frase1[i] != "")
    {
        risultato += frase1[i] + " ";
    }
}

Console.Write(risultato);
Console.WriteLine(" ");
//es 3
Console.WriteLine("la pirma metà è: " + frase2);
Console.WriteLine("la sedonda metà è: " + frase3);