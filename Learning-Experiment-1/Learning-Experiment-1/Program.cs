using System;

namespace Learning_Experiment_1
{
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
