class ForEachLoop 
{
    public static void Program()
    {
        // Slumpa svaret
        int Answer = new Random().Next(1, 99);
        Console.WriteLine("Gissa på en siffra mellan 1 och 99");
   
        // För varje gissning...
        foreach (int Guess in ReadGuesses())
        {
            if (Answer != Guess)
            {
                Console.WriteLine("Fel!");
                if (Answer > Guess)
                {
                    Console.WriteLine("Gissa högre");
                }
                else 
                {
                    Console.WriteLine("Gissa lägre");
                }
            }
            else
            {
                // Här har vi rätt svar, så då kan vi avbryta foreach-loopen
                Console.WriteLine("Rätt!");
                break;
            }
        }
    }

    public static IEnumerable<int> ReadGuesses()
    {
        while(true) // i all evighet
        {
            // Ta emot en gissning från användaren 
            // och returnera den som en int
            yield return Convert.ToInt32(Console.ReadLine());
        }
    }
}
