
class WhileLoop 
{
    public static void Program()
    {
        int Answer = new Random().Next(1,99);
        Console.WriteLine("Gissa på en siffra mellan 1 och 99");

        int Guess = Convert.ToInt32(Console.ReadLine());

        // Vi kör denna kod medan användaren har gissat fel
        while (Answer != Guess)
        {
            Console.WriteLine("Fel!");
            if (Answer>Guess)
            {
                Console.WriteLine("Gissa högre");
            }
            else 
            {
                Console.WriteLine("Gissa lägre");
            }

            // Innan vi hoppar till rad 12 igen för en ny jämförelse
            // måste vi fråga användaren om en ny gissning
            Guess = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Rätt!");
    }
}