using System;
namespace Learning_Experiment_1
{
    /// <summary>
    /// A class to center text using a spacer character
    /// </summary>
    public class CenterPrinter
    {
        private char spacer;
        /// <summary>
        /// This constructor defaults the spacer character to a hyphen ('-')
        /// </summary>
        public CenterPrinter() : this('-') { }

        /// <summary>
        /// This constructor allows the user to select the spacer character
        /// </summary>
        /// <param name="spacer"> The spacer character </param>
        public CenterPrinter(char spacer)
        {
            this.spacer = spacer;
        }

        /// <summary>
        /// This method centers a message using spacer characters
        /// </summary>
        /// <param name="message">The message to be centered</param>
        /// <param name="length">The length of the centered text, including spacers</param>
        /// <returns> A string of length <code>length</code> with the message centered using spacer characters.</returns>
        public string GetCentered(string message, int length)
        {
            string result = "";
            if (length <= message.Length)
                return message;
            int halfLength = (length - message.Length) / 2;
            result += RepeatChar(this.spacer, halfLength) + message + RepeatChar(this.spacer, halfLength);
            if ((length - message.Length) % 2 == 1)
                result += spacer;
            return result;
        }

        /// <summary>
        /// This message prints the message centered using spacer characters
        /// </summary>
        /// <param name="message">The message to be printed</param>
        /// <param name="length">The length of the printed string</param>
        public void PrintCentered(string message, int length)
        {
            string centeredMessage = GetCentered(message, length);
            Console.WriteLine(centeredMessage);
            
        }

        /// <summary>
        /// Creates a string of length <code>count</code> using character <code>c</code> repeated
        /// </summary>
        /// <param name="c">The character to be strung together</param>
        /// <param name="count">The number of times the character will be repeated</param>
        /// <returns>A string of character <code>c</code> repeated <code>count</code> times</returns>
        public string RepeatChar(char c, int count)
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

