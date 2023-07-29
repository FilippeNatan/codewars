using System;

Console.WriteLine(Kata.IsPangram("Cwm fjord bank glyphs vext quiz"));
public static class Kata
{
  public static bool IsPangram(string str)
  {
    char firstLetter = 'a';
    List<char> alphabet = new List<char>();
    while(Char.IsLetter(firstLetter))
    {
        alphabet.Add(firstLetter);
        firstLetter++;
    }

    foreach(char letter in str)
    {
        if(alphabet.Contains(Char.ToLower(letter)))
        {
            alphabet.Remove(Char.ToLower(letter));
        }
    }
    
    switch(alphabet.Count())
    {
        case < 1:
        return true;
        
        default:
        return false;
    }
  }
}