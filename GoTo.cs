
class GoTo 
{
    public static void Program()
    {
        Random rnd = new Random();
        int Answer = rnd.Next(1,99);
        Console.WriteLine("Gissa på en siffra mellan 1 och 99");
        Question:
        int Guess = Convert.ToInt32(Console.ReadLine());
        if (Answer==Guess)
        {
            Console.WriteLine("Rätt!");
        }
        else
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
            goto Question;
        }
    }
}