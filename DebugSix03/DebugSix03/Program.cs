﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Finds whether a book dealer carries a requested book

using static System.Console;
class DebugSix03
{
    static void Main()
    {
        string[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
        int x;
        string entryString;
        Write("What book are you looking for? ");
        entryString = Console.ReadLine();
        x = Array.BinarySearch(books, entryString);
        if (x < 0)
        {
            WriteLine("{0} not found", entryString);
        }
        else
        {
            WriteLine("Yes, we carry {0}", entryString);
        }
    }
}