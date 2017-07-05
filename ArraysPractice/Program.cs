﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////declaring an array without initializing
            //int[] myFirstArray;
            ////declaring and initializing a second array
            //string[] myStringArray = { "first", "second", "third", "fourth" };
            ////declare and initialize a char array with the letters of your last name
            //char[] myLastName = { 'c', 'o', 'r', 'r', 'i', 'g', 'a', 'n' };
            ////print three elements of my array
            //Console.WriteLine(myLastName[0]);
            //Console.WriteLine(myLastName[6]);
            //Console.WriteLine(myLastName[7]);

            ////create the following arrays and print using the correct index numbers
            ////array of top ten vacay spots
            //string[] topTenVacaySpots = { "Rome", "Cancun", "London", "Miami", "Orlando", "San Francisco", "Myrtle Beach", "Branson", "Paris", "New York City" };
            ////print the first and last spots
            //Console.WriteLine(topTenVacaySpots[0]);
            //Console.WriteLine(topTenVacaySpots[9]);
            ////make the array of the ages of three children you know
            ////print each child's age
            //int[] childrensAges = { 6, 1, 3 };
            //Console.WriteLine(childrensAges[0]);
            //Console.WriteLine(childrensAges[1]);
            //Console.WriteLine(childrensAges[2]);
            ////make array of gpas on 4.0 scale of 8 students - don't have to print
            //double[] gpa = { 1, 1.2, 2, 4, 3.5, 3, 2.8, 3.2 };
            ////make array of first letter of 4 of your classmates names 
            //char[] initials = { 's', 'j', 'm', 'f' };
            ////print all four on same line
            //Console.Write(initials[0]);
            //Console.Write(initials[1]);
            //Console.Write(initials[2]);
            //Console.WriteLine(initials[3]);
            //Console.WriteLine(initials);
            //Console.WriteLine("{0}{1}{2}{3}", initials[0], initials[1], initials[2], initials[3]);

            ////declare an array without yet knowing the elements - this makes space for 21 elements
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];
            ////dataType[] nameOfArray = new dataType[# of elements];

            ////adding elements to array
            ////nameOfArray[index] = Element;
            //studentsInClass[0] = "Jordan";

            ////allow users to enter students into array
            //Console.WriteLine("Please enter in the name of the next student.");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("The student in the second seat is {}.", studentsInClass[1]);

            //Console.WriteLine("Please enter the age of the person in the first seat.");
            ////create a new int array with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chik-fil-a" };
            //Console.WriteLine(restaurantsInMall.Length);

            ////for .Length practice create a char array of letters in your middle name and print the # of chars

            //char[] middleName = { 'e', 'l', 'i', 'z', 'a', 'b', 'e', 't', 'h' };
            //Console.WriteLine(middleName.Length);

            //Declare and initialize a string array
            //Using the Length property print the second to last element in the array

            //string[] name = { "Clare", "Elizabeth", "Corrigan" };
            //Console.WriteLine(name[name.Length - 2]);
            ////or
            //int numNames = name.Length;
            //Console.WriteLine(name[numNames - 2]);

            ////Indexof method to search an array for specified value returning index position of first matching value found
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf method to search an array for specified value returning index position of last matching value found
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);

        }
    }
}
