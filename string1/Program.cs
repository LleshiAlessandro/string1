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
bool ruben_arrabbiato(string parola_palindroma)
{
    for (int i = 0; i < parola_palindroma.Length; i++)
    {
        if (parola_palindroma[i] != parola_palindroma[parola_palindroma.Length - 1])
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Dimmi il numero binario di massimo 8 cifre ");
string v = Console.ReadLine();

Console.WriteLine("Dimmi la frase che vuoi ");
string frase = Console.ReadLine();
string risultato = "";
Console.WriteLine(" dimmi una parola palindroma ");
string parola_palindroma = Console.ReadLine();
//es 1
int j = decimale(v);
Console.WriteLine("Il numero decimale è: " + j);
//es 2
string[] frase1 = frase.Split(" ");
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
string frase2 = frase.Substring(0, frase.Length / 2);
string frase3 = frase.Substring(frase.Length / 2);
Console.WriteLine("la pirma metà è: " + frase2);
Console.WriteLine("la sedonda metà è: " + frase3);
//es 4
Console.WriteLine(ruben_arrabbiato(parola_palindroma));