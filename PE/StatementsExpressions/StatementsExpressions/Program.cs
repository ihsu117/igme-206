/*
 * Ivan Hsu
 * PE - Statements & Expressions
 * 
 */

//Namespace declaration
namespace StatementsExpressions
{
    //Class declaration
    internal class Program
    {
        //Main
        static void Main(string[] args)
        {
            //Print name & label
            Console.WriteLine("Name: Dexter Morgan");

            //First stat + newline operator | 20% of total
            Console.WriteLine("\nDexterity: " + (50 * .2));

            //Second stat | Half of first stat
            Console.WriteLine("Charisma " + (50 * .2)/2);

            //Third stat | Just 7
            Console.WriteLine("Health: " + 7);

            //Fourth stat | Sum of 2nd & 1st stat minus 2
            Console.WriteLine("Strength: " + (((50 * .2)/2) + 7 - 2));

            //Fifth stat | Remainder of total after subtracting the sum of stats 1 - 4
            Console.WriteLine("Intelligence: " +
                (
                   50 - (
                        (50 * .2) +
                        ((50 * .2) / 2) + 7 +
                        (((50 * .2)/2) + 7 - 2)
                   )
                )
            );

            Console.WriteLine("\nTOTAL: 50");

        }
    }
}
