using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome young mage..."); // This single line comment is next to the first print statement
            Console.WriteLine("You have now entered the domain of");
            Console.WriteLine("neomeiji!");
            Console.WriteLine();
            Console.WriteLine("What's my favourite number??!?");
            Console.WriteLine("It's..." + (495 + 134 + 148) + "!");
            Console.WriteLine();

            /* This is a multi-line comment
            * And this comment is between the blocks of code
            * that outputs the 2 types of print statements. 
            This is what's known as a comment block */

            Console.Write("Greetings, young mage! Please enter your name: ");
            Console.Write("Merlin (the Write() method will print the message on the same line)");
            Console.WriteLine();

            // Variables are containers for storing data values and there are different types of variables defined with different keywords
            /* To create a variable, specify the type and assign it a value e.g., type variableName = value; */

            string name = "neomeiji"; // The variable is called "name" of type "string", with the value of "neomeiji"
            Console.WriteLine(name);

            int myNum = 777; // Variable that stores a number
            Console.WriteLine(myNum);
            Console.WriteLine();

            // Constants are variables that cannot be changed / overwritten after they are assigned a value
            // Constants are declared using the "const" keyword before the variable type and are unchangeable + read-only

            string constant = "The following is a constant variable: ";
            const int myConstant = 150;
            Console.WriteLine(constant + myConstant); // This will print the value of the constant variable
            // myConstant = 100; // This line will cause an error because myNum is a constant and cannot be changed after its initial assignment

            Console.WriteLine(); // New empty line

            int numNum; // You can declare (create) a variable without a value, and assign one to it later 
            numNum = 999;
            Console.WriteLine(numNum);

            int myNumber = 77; // Assigning a new value to an existing variable overwrites the previous value = 77 > 100 
            myNumber = 100;
            Console.WriteLine(myNumber);

            // Declaring variables of other types:

            int nummyNum = 2000;
            double myDoubleNumber = 2.00;
            char myLetter = 'B';
            bool myBoolyBool = true;
            string myMessage = "Greetings!";
            Console.WriteLine($"{nummyNum}, {myDoubleNumber}, {myLetter}, {myBoolyBool}, {myMessage}");
            Console.WriteLine();
            /* I got this error because Console.WriteLine does not support passing multiple arguments of different types directly 
             * unless you use string formatting or concatenation.
             * 
             * When several variables of different types as separate arguments are passed to Console.WriteLine, it expects either a single string or a format string with corresponding arguments.
             * 
             * String interpolation ($"") combines all the variables into a single string, 
             * which Console.WriteLine can print without type conversion issues. Also had to change braces to curly braces.*/

            // Display Variables

            string wizard = "Grand Wizard!";
            Console.WriteLine("Hello " + wizard);
            Console.WriteLine();

            string firstName = "Solid ";
            string lastName = "Snake";
            string fullName = firstName + lastName; // Concatenation of strings
            Console.WriteLine(fullName);
            Console.WriteLine();

            int x = 10;
            int y = 90;
            Console.WriteLine(x + y); // Adding two integer variables together with the WriteLine() Method > For numeric values, the + character works as a mathematical operator

            Console.WriteLine(); // New empty line

            int a = 100;
            int b = 400;
            int c = a + b;
            Console.WriteLine(c); // Adding two integer variables together and storing the result in a new variable (500)

            int e = 1, f = 2, g = 3;
            Console.WriteLine(e + f + g); // Adding three integer variables together and printing the result (6)

            int j, k, l;
            j = k = l = 100;
            Console.WriteLine(j + k + l); // Assigning the same value to multiple variables and printing the result (300)

        }
    }
}