﻿using YellowOak.TreeBuilder;

namespace YellowOak
{
    internal sealed class Program
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Main()
        {
            var startTime = Environment.TickCount;
            FromFile fName = new FromFile(@"C:\Users\Alexey\Desktop\C#\htmlparser\bin\Debug\net8.0/file.html");

            var oak = new Oak();
            oak.Load(fName);
            
            oak.GrowTree();
            
            //
            //Console.WriteLine(oak.PrintTree());
            
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Program timing is: {Environment.TickCount - startTime}ms");

            Console.ReadKey();
        }
    }        
}
