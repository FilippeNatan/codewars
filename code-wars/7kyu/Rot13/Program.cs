Console.Write("Write a message to convert to Rot13:\n");
string? message = Console.ReadLine();
Console.WriteLine(Kata.Rot13(message));

public class Kata
{
  public static string Rot13(string message)
    {
        char[] result = new char[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
            char letter = message[i];

            if (char.IsLetter(letter))
            {
                char baseLetter = char.IsLower(letter) ? 'a' : 'A';
                int offset = letter - baseLetter;

                char rotatedLetter = (char)((offset + 13) % 26 + baseLetter);

                result[i] = rotatedLetter;
            }
            else
            {
                result[i] = letter;
            }
        }

        return new string(result);
    }
}