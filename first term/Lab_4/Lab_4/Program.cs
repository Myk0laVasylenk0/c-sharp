



using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string Word, Result, confirmation;
        char Char;
        int i;

        do
        {
            try
            {
                Console.WriteLine("Enter your word here: ");
                Word = Console.ReadLine();
                Console.WriteLine("Enter your char to remove: ");
                Char = char.Parse(Console.ReadLine());
                Result = "";

                foreach (char c  in Word)
                {
                    if (c != Char)
                    {
                        Result += c;
                    }
                    
                }

                Console.WriteLine(Result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Proceed? [y]/n");
                confirmation = Console.ReadLine();

            }
            //Console.WriteLine("Proceed? [y]/n");
            //confirmation = Console.ReadLine();
       
        }
        while (confirmation == "y");

        
    }
}




