﻿using System;

namespace Learning_Experiment_1
{
    /// <summary>
    /// A class to contain the main method
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args">The command line arguments</param>
        static void Main(string[] args)
        {
            CenterPrinter printer = new CenterPrinter();
            printer.PrintCentered("Hello World", 20);
        }
    }
}
