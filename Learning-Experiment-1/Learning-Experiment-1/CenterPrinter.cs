using System;
namespace Learning_Experiment_1
{
    public class CenterPrinter
    {
        private char spacer;
        public CenterPrinter() : this('-') { }
        public CenterPrinter(char spacer)
        {
            this.spacer = spacer;
        }

        public string GetCentered(string message, int length)
        {
            string result = "";
            if (length <= message.Length)
            {
                return message;
            }
            int halfLength = (length - message.Length) / 2;
            result += MultiplyChar(this.spacer, halfLength) + message + MultiplyChar(this.spacer, halfLength);
            if ((length - message.Length) % 2 == 1)
                result += spacer;
            return result;
        }

        public void PrintCentered(string message, int length)
        {
            string centeredMessage = GetCentered(message, length);
            Console.WriteLine(centeredMessage);
            
        }
        public string MultiplyChar(char c, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += c;
            }
            return result;
        }
    }
}

