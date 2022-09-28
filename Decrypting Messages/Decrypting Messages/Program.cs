namespace Decrypting_Messages
{
    ﻿using System;
    
    internal class Program
    {
        static void Main(string[] args)
        {         
            int key = int.Parse(Console.ReadLine());
            int nLines = int.Parse(Console.ReadLine());

            int sum = 0;
            string result = "";

            for (int i = 0; i < nLines; i++)
            {
                char characters = char.Parse(Console.ReadLine());

                sum = (int)characters + key;
                result += (char)sum;
            }
            Console.WriteLine(result);
        }
    }
}
