using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   //------------------------------------Printing Output--------------------------------------


            //Prints Greeting output 
            Console.WriteLine("Hello World!");


            //------------------------------------String variables--------------------------------------


            //Declares string variable 'aFriend' and assigns -Bill as value and prints result
            string aFriend = "-Bill";
            Console.WriteLine(aFriend);
            
            //Reassigns aFriend string variable to Maria and reprints output"
            aFriend = "Maria";
            Console.WriteLine(aFriend);


            //--------------------------------Concatenation of Strings--------------------------------


            //Arithmetically concatenates string arguments to write a new greeting from aFriend
            Console.WriteLine("Hello " + aFriend);


            //------------------------------------String Interpolation--------------------------------

            //Uses string interpolation to call aFriend variable upon detection of special sequence {var}
            Console.WriteLine($"Hello {aFriend}");

            //String interpolation to call two Friend string variables in the same command line
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            //-----------------------------------string.Length------------------------------------------


            //Calls .Length command as an interpolated string to show length property of variables
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


            //------------------------------------The Trim Function-------------------------------------


            //Prints greeting with initial white space
            string greeting = "     Hello World!     ";
            Console.WriteLine($"[{greeting}]");

            //Trims leading white space
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Trims trailing white space
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Trims all white space
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");


            //------------------------------------The Replace Function------------------------------------

            //Replaces 'Hello' portion of string with 'Greetings' string
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);


            //------------------------------------Altering Case with ToUpper, ToLower-----------------------

            //Converts all characters in a string to either lower or upper case 
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //------------------------------------Searching strings using Contains--------------------------

            //Returns boolean value based on search within string
            string songLyrics = "You say goodbye, and I say hello!";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));


            //Using StartsWith and EndsWith as an alternative search method
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("hello!"));



        }
    }
}
