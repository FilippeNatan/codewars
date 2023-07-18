using System;

Console.WriteLine(Kata.Disemvowel("Seu site é muito ruim e deveria acabar!"));

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string finalStr = "";
        string vogais = "aeiou";
        for(int x=0; x < str.Length; x++)
        {
            if(!vogais.Contains(Char.ToLower(str[x])))
            {
                finalStr += str[x];
            }
        }
        str = finalStr;
        return str;
    }
}