class ForLoop 
{
    public static void Program()
    {
        int Answer = new Random().Next(1, 99);
        Console.WriteLine("Gissa på en siffra mellan 1 och 99");

        // Det går även att "deklarera" variabler utan att ge dom värden:
        int Guess;
        for (
            // Första saken (1) i en for-loop är "startvärdet", 
            // dvs vi måste be användaren gissa
            Guess = Convert.ToInt32(Console.ReadLine()); 

            // Andra saken (2) i en for-loop är "jämförelsen" dvs vilkoret
            // i detta fall om användaren har gissat rätt
            Answer != Guess; 

            // Tredje saken (3) i en for-loop är vad vi ska göra om villkoret ej är uppfyllt
            // dvs om användaren har gissat fel!
            // Och då ska vi be den gissa på nytt
            // Så egentligen samma sak som vi vill göra på 1.
            Guess = Convert.ToInt32(Console.ReadLine())
        )
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

        Console.WriteLine("Rätt!");
    }
}
