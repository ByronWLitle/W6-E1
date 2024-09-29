using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W6_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\temp\output.txt"; //sets path to a temp folder in C: drive
            string content = ""; //string variable named content to hold value
            Console.WriteLine("Enter content for file: "); //Prompts user to enter content for file
            content = Console.ReadLine(); //Takes user input and stores in string variable "content"
            File.WriteAllText(fileName, content); //Creates a txt file named output and sends to temp folder in C: drive
            Console.WriteLine(); //Space for visibility
            Console.WriteLine($"There are {CountWords(fileName)} word(s) in file."); //Outputs amount of words in file by calling method CountWords
            Console.ReadLine(); //Pauses program to allow user to view
        }
        public static int CountWords(string file) //Parameter takes file path/destination
        {
            string fileGrab = File.ReadAllText(file); //fileGrab reads all text directed from file variable
            string[] fileWords = fileGrab.Split(new char[] { ' ', }); //Creates an array of words from file by splitting up the text by spaces
            int total = fileWords.Length; //total variable is the amount of words by getting how long the array is of fileWords
            return total; //Returns total variable for output
        }
    }
}
