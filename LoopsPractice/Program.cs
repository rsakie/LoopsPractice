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

            int product = 1;
            for(int i = 1; i <=10; i++)
            {
                product = (product *i);
            }
            Console.WriteLine(product);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);
        }
    }
}
