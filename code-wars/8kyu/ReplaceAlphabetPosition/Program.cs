Console.WriteLine(Kata.AlphabetPosition("The narwhal bacons at midnight."));

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    string sentence = "";
    foreach(char character in text)
    {
        if(char.IsLetter(character))
        {
            int index = (int)character % 32;
            sentence += index+" ";
        }
    }
    if(sentence.Length > 0)
    {
        sentence = sentence[..^1];
    }
    text = sentence;
    return text;
  }
}