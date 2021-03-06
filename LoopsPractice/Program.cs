﻿using System;
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
            //string classone;
            //string gradeletter;
            //string classtwo;

            //do
            //{
            //    Console.WriteLine("would you like to add a class to your gpa calculation? yes/no");
            //    classone = Console.ReadLine().ToLower();
            //    Console.WriteLine("what is the letter grade for the class?");
            //    gradeletter = Console.ReadLine();
            //    Console.WriteLine("do you have another class you would like to add? yes/no");
            //    classtwo = Console.ReadLine();
            //    Console.WriteLine();
            //}
            //while (classone == "yes");


            //nested loop
            //a loop inside another loop
            //the inner loop is exectuted more times than outer loop


            //create as nested loop structure that prints
            // 1234
            // 1234

            //for (int rows = 1; rows <= 2; rows++) 
            //{
            //    for (int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //    }


            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            //int multNum = 1;
            //Console.WriteLine("enter your first number");
            //int firstNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //int secondNum = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= firstNum; i++)
            //{
            //    for(int j = 1; j <= secondNum; j++)
            //    {
            //        Console.Write(multNum * j + " ");

            //    }
            //    multNum += 1;
            //    Console.WriteLine();

            //}
            //print a triangle
            //outer loop will go line by line
            //inner loop will go over different elemnets in the line
            //result should look like:
            //1
            //12
            //123
            //1234....

            //for (int rows = 1; rows <= 4; rows++)
            //{
            //    for (int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //    {

            //ask user how many rows they want
            //int n = int.Parse(Console.ReadLine());
            //for(int row= 1; row<=  n; row++)
            //    //{
            //    Console.Write(col + " ");
            //}
            //    Console.WriteLine();
            //    //

            //Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number
            //you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //}

            // Write a program that takes your favorite foods and prints them out one at a time. (Use a foreach loop.)

            //string[] favoriteFoods = { "pizza", "burritos", "chips" };

            //foreach (string food in favoriteFoods )
            //{
            //    Console.WriteLine(food);
            //}

            //Write a console application that asks the user for an integer. If that integer is evenly divisible by 3
            //then write “You Won!” If it isn’t,
            //write “You Lost.” Keep asking them for a number (looping) until they win.

            //i know i need to ask user for an integer, get input and save it

            //Console.WriteLine("please enter an integer (whole number).");
            //int userNum = int.Parse(Console.ReadLine());

            //"evenly divisible" is a good indicator of modulus
            //we have to check if the input % 3
            //we need a conditional and if the input % 3 == 0 we need to write "you won" and exit the loop
            //if their input % 3 is not equal to zero, have to let them know they lost and ask them for another integer
            //repeat this, until they win

            //while(userNum % 3 != 0)
            //{
            //    Console.WriteLine("you lost");
            //    Console.WriteLine("please enter another integer");
            //    userNum = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("you won");

            //Create an array of lucky numbers(just any numbers you like). Using a foreach loop, print the following:
            //If the array holds the numbers 3, 5, 7, 11, 15, then the printed result should say. your lucky number is ...

            //int[] luckyNumbers = { 3, 5, 7, 11, 15 };
            //foreach (int num in luckyNumbers)
            //    Console.WriteLine("Your Lucky Number Is: " + num);


            //    Create an array of your favorite movies.Print out each movie in the list,
            //    unless the move starts with a vowel. Hint: Research.startsWith()


            //string[] favMovies = { "Old School", "Star Wars", "Anchorman", "Replacements", "Avatar", "Super Troopers" };
            //foreach (string movie in favMovies)
            //{
            //    if (movie.StartsWith("A"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }
            //}


            //write an application that asks the user for word or phrase,
            //print the number of each vowels in that word to the console
            //output: "your phrase has __ a's
            //       " your phrase has __e's
            //        etc


            //Console.WriteLine("Please enter a word or phrase.");
            //string[] word = { Console.ReadLine() };
            //int vowelCount = 0;
            //foreach(char vowel in word)


            //Ask the user if he / she / they would like to check the patient in for his / her / their appointment
            //Console.WriteLine("Would you like to check in for you appt?");
            //string answer = Console.ReadLine();
            
            //    //Using a While Loop, run the following sequence only if the user's answer is not YES
            //while (answer == "yes")
            //{
            //    //Print "PATIENT CHECK IN SYSTEM"
            //    //Ask the user for the client's full name
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Whatis your full first name?");
            //    string fName = Console.ReadLine();
            //    Console.WriteLine("What is your 6-digit patient id number?");
            //    Console.ReadLine();
            //    Console.WriteLine("What is you appointment time?");
            //    int time = int.Parse(Console.ReadLine());
             //Ask the user for the client's 6-digit patient ID
                //Ask the user for the client's appointment time (i.e. 2:00 PM)
                //Ask the user if he / she / they would like to check the patient in for his / her / their appointment
            //}



        }

    }
}







