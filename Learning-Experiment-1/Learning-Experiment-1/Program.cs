using System;

namespace Learning_Experiment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CenterPrinter printer = new CenterPrinter();
            printer.PrintCentered("Hello World", 20);
        }
    }
}
