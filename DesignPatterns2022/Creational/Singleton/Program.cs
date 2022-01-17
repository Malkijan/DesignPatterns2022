﻿using System;

namespace DesignPatterns2022.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Database firstInstanceRequest = Database.GetInstance();
            Database secondInstanceRequest = Database.GetInstance();

            bool isEquals = firstInstanceRequest == secondInstanceRequest;

            Console.WriteLine($"Database referance is equals: {isEquals}"); //output: Database referance is equals: True
            Console.ReadLine();
        }
    }
}
