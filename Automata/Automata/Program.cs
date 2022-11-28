using Automata;
using System.IO.Pipes;

PDA pda = new PDA();
int ans;
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Which one do you like to test\n0: Terminate\n1: Symbol test\n2:Palindrome");
    ans = Convert.ToInt32(Console.ReadLine());

    if(ans == 1)
    {
        Console.WriteLine("Enter string");
        string input = Console.ReadLine();


        if ( pda.CheckSymbol(input))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Balance"); 
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not Balance");
        }
    } else if(ans == 2)
    {
        Console.WriteLine("Enter string");
        string input = Console.ReadLine();


        if (pda.CheckPalindrome(input))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Palindrome!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not Palindrome");
        }
        
    } 

} while (ans != 0);
