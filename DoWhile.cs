
class DoWhile 
{
    public static void Program()
    {
        int Answer = new Random().Next(1,99);
        Console.WriteLine("Gissa på en siffra mellan 1 och 99");
        
        // Det går även att "deklarera" variabler utan att ge dom värden:
        int Guess; 

        do // Betyder gör detta innanför { } (fortsättning rad 26...)
        {
            // Först tar vi emot gissningen
            Guess = Convert.ToInt32(Console.ReadLine());

            if(Guess == Answer) 
            {
                // Har dom gissat rätt avbryter vi
                Console.WriteLine("Rätt!");
                break;
            }
            else 
            {
                // Annars har dom gissat fel...
                Console.WriteLine("Fel!");
                if (Answer>Guess)
                {
                    Console.WriteLine("Gissa högre");
                }
                else 
                {
                    Console.WriteLine("Gissa lägre");
                }
            }         
        }
        // Sålänge följande villkor inte är sant, dvs
        // sålänge spelarne har gissat fel
        while (Answer != Guess);
    }
}