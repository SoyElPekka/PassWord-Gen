
Console.Title = "Password Generator I By PEKKA#3593";
Console.WriteLine("Thanks For Using This Password Generator");
Console.WriteLine("Made By PEKKA");
Console.WriteLine("Press any button to start");
string press = Console.ReadLine();

Random random = new Random();

string[] characters = new[] { "P", "L", "A", "j", "d", "b", "q", "g", "u", "e", "w", "k", "l", "p", "l", "h", "v", "i", "m", "n", "f", "z", "a", "2", "5", "9", "1", "7", "8", "3", "4", "6", "&", "@", "#", "!", "^", ":", "=", "$" };

while (true)
{
    Console.Write("\nPassword length:");
    var passwordLength = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    for (int i = 0; i < passwordLength; i++)
    {
        Console.Write(characters[random.Next(characters.Length)]);

    }


    Console.Beep();
}
