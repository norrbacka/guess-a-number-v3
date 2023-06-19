
class Recursion 
{

    public static void Program(int Answer = -1)
    {
        // -1 betyder att vi ännu inte har slumpat en siffra
        if(Answer == -1)
        {
            // Så då måste vi slumpa en siffra!
            Answer = new Random().Next(1,99);

            // Och berätta för användaren att det har hänt!
            Console.WriteLine("Gissa på en siffra mellan 1 och 99");
        }

        int Guess = Convert.ToInt32(Console.ReadLine());
        if (Answer != Guess)
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

            // Ifall svaret är fel så anropar vi oss själva på nytt med svaret
            // som vi slumpade på rad 11
            // Denna gång kommer dock inte if-satsen på rad 8 att köras
            // eftersom vi skickar in vårt slumpade värde till Program-funktionen 
            Program(Answer);
        }
        else 
        {
            Console.WriteLine("Rätt!");
        }
    }
}