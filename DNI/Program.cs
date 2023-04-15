﻿using System;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
        }

        /// <summary>
        /// Returns the letter corresponding to a given DNI/NIF number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(int number)
        {
            string letters = "TRWAGMYFPDXBNJZSQVHLCKE";
            int index = number % 23;
            return letters[index];
        }
    }
}
