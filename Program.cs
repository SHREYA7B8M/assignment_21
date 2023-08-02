using System;
using System.Collections.Generic;
using System.Threading;

namespace assignment_21
{
    class Program
    {
        static List<string> days = new List<string> {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        static List<string> months = new List<string> {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        static List<string> fruits = new List<string> {
            "Apple", "Mango", "Pear", "Orange", "Grapes","Banana","Muskmelon","Watermelon","Strawberry","Lychee"
        };

        static Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>
        {
            { "Trendy", "currently fashionable or popular." },
            { "Family", "A group of people who are related to each other." },
            { "Friend", "A person with whom one has a bond of mutual affection." },
            { "Explore", "To travel through (an unfamiliar area) in order to learn about it." },
            { "Surprise", "The feeling that you have when something happens that you do not expect" }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("---------------Welcome to Learning-----------");

            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayWords);

            daysThread.Start();
            monthsThread.Start();
            fruitsThread.Start();
            wordsThread.Start();

            daysThread.Join();
            monthsThread.Join();
            fruitsThread.Join();
            wordsThread.Join();

            Console.WriteLine("\nEnd of session, kids!!");
            Console.ReadKey();
        }

        static void DisplayDays()
        {
            foreach (string day in days)
            {
                Console.WriteLine("\nDay: " + day);
                Thread.Sleep(2000);
            }
        }

        static void DisplayMonths()
        {
            Thread.Sleep(5000); 
            foreach (string month in months)
            {
                Console.WriteLine("Month: " + month);
                Thread.Sleep(2000);
            }
        }

        static void DisplayFruits()
        {
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
                Thread.Sleep(1000);
            }
        }

        static void DisplayWords()
        {
            Thread.Sleep(500); 
            foreach (var word in wordsAndMeanings)
            {
                Console.WriteLine("Word: " + word.Key + ", Meaning: " + word.Value);
                Thread.Sleep(1000);
            }
        }
    }
}
