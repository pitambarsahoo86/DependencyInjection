﻿using System;

namespace MefExample
{
    internal class Program
    {
        private static void Main()
        {
            var container = new CentralContainer();
            container.ComposeComponents();
            container.Producer.Execute();
            container.Consumer.Consume();
            Console.ReadLine();
        }
    }
}