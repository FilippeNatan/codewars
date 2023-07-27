using System;

Console.WriteLine(Kata.ToCamelCase("the_stealth_warrior"));
Console.WriteLine(Kata.ToCamelCase("the-stealth-warrior"));
Console.WriteLine(Kata.ToCamelCase("The_Stealth_Warrior"));
Console.WriteLine(Kata.ToCamelCase("The_Stealth-Warrior"));

public class Kata
{
  public static string ToCamelCase(string str)
  {
    bool firstLetter = false;
    bool firstTime = true;
    string finalStr = "";
    char currentLetter;

    foreach(char letter in str)
    {
        if(firstTime == true)
        {
            finalStr += letter;
            firstTime = false;
        }
        else
        {
            if(char.IsLetter(letter))
            {
                if(firstLetter == true)
                {
                    currentLetter = char.ToUpper(letter);
                    firstLetter = false;
                }
                else
                {
                    currentLetter = char.ToLower(letter);
                }
                finalStr += currentLetter;
            }
            else
            {
                firstLetter = true;
            };
        }
        
    }

    return finalStr;
  }
}