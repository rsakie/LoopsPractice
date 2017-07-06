using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //when would you use a loop
            //why would you use a loop
            //nested loops
            //infinite loops
            //keywords break and continue

            //for loop
            //can be used for counting and or...
            // ITERATING through an array (or other collection typs)
            //looks like this
            //for(initalizer; condition; updater)
            //{
            //   do something
            //}

            //for(int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i= 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            ////the .split() method takes a string and turns it into an array of smaller
            ////strings(substring). it defaults the split spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //create an array called days with the elements mon, tues,wed
            //using a FOR LOOP, print the elements of the days array
            //string[] days = { "sunday", "monday", "tuesday", "wednesday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}


            //    //start with string" once upon a time" and creats an array called
            //    //storyWords using a For loop, print each word
            //string story = "Once Upon a time" ;
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}
            //determine the product (multiplication) of 1 through 10 using a For loop
            //print the product to the screen

            //int product = 1;
            //for(int i = 1; i <=10; i++)
            //{
            //    product = product *i;
            //}
            //Console.WriteLine(product);
            //// or
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //Foreach Loop - used to iterate over a collection (ex. list or array)
            //you can think of a structure of a foreach loop as a the statement:
            //for each item in the collection, do something
            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach (int grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "June" };
            ////always start with the keyword foreach
            //foreach(string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow temp variables to know to assign
            //itself to each element in the collection (like an array), one at a time


            //creat an array of 6 musicians
            //using a foreach loop, print each musicians name

            //string[] Musicians = { "acdc", "kiss", "beatles", "ffdp", "bad company", "rise against" };
            //foreach(String artist in Musicians)
            //{
            //    Console.WriteLine(artist);
            //}

            // while loop - When to use a while loop
            // when you want a chunk of code to run only if a condition is met first
            // WHILE something is TRUE

            //string[] favRestaurants = { "chipotle", "papajohns pizza", "red lobster" };
            //foreach(string food in favRestaurants)
            //{
            //    Console.WriteLine(food);
            //}


            //Console.WriteLine("what is your first name?");
            //String firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "ROBERT") 
            //{
            //    Console.WriteLine("dude you are amazing! ");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain.ToUpper() == "YES")
            //{
            //    Console.WriteLine("Its a Rematch");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //a Do While loop is similar to a While loop, however
            //the Do-While loop is used when you want a chunk of code to run
            //AT LEAST ONCE, but repeat only if the while condition is met

            //structure of a do while loop looks like this:
            //do
            //{
            // do Something
            //}
            //while(condition);

            //string  playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //lets pretend code for the game is here
            //    Console.WriteLine("Great Game!!");
            //    Console.WriteLine("Do you want to play again? YES?NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            //ask the user for the class(in school) that they would like to add their
            //gpa calculation.
            //ask the user for the letter grade for the class(no + or -)
            //ask the user if they have another class they would like to add their 
            //gpa calculation.
            //using a do-while loop, repeat the code if the user says "YES"

            do
            {
                Console.WriteLine("Would you like to add your GPA calculation? YES?NO");
                string classOne = Console.ReadLine();
                Console.WriteLine("What is the letter grade for the class?");
                string gradeLetter = Console.ReadLine();
                Console.WriteLine("Do you have another class you would like to add? YES/NO");
                string classTwo = Console.ReadLine();
            }
            



        }
    }
}
