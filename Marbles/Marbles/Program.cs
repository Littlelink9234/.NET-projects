using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Marbles
{
    public class Marbles
    {        
        static void Main(string[] args)
        {
            int red, green, blue, orange;
            red = PromptInt("Ratio red marbles?");
            green = PromptInt("Ratio green marbles?");
            blue = PromptInt("Ratio blue marbles?");
            orange = PromptInt("Ratio orange marbles?");

            int[] results = Solve(red, green, blue, orange, 1000);
            WriteOutStats(results);
            Console.ReadLine();
        }

        private static readonly Random mRandom = new Random(); // use to generate random color marble

        public const int RED_MARBLE = 1;
        public const int BLUE_MARBLE = 2;
        public const int GREEN_MARBLE = 3;
        public const int ORANGE_MARBLE = 4;

        public static int[] Solve(int red, int green, int blue, int orange, int count)
        {
            // TOOD: Return an array of integers of length [count]
            // each element in the array should contain a value from 1 to 4
            // the value represents a marble color (see constants above)
            // using the passed in values, you need to infer the probablility of each colored marble.
            // You should then *randomly* generate [count] number of marbles based on that probability
            int[] marbleArray = new int[count];
            float[] ratios = new float[count];

            for (int i=0; i < count; i++)
            {
                marbleArray[i] = mRandom.Next(RED_MARBLE, ORANGE_MARBLE + 1);
            }

            

            // (i.e. if you were passed the values 10, 5, 5, 1 for the red, green, blue and orange parameters respectively
            // you should have approximately 10 red marbles for every 5 green and for every five blue marbles, and
            // there should 10 red marbles for approximately every orange marble you get)
         
        }

        public static void WriteOutStats(int[] results)
        {
            // TODO: output the total number of red, green, blue and orange marbles based on the array of results passed into you.
            // This array is the same array you generated in the Solve function above.
            // Also, separately output the number of red marbles in the first 100 marbles in your array.

            //int[] resultsArray = Solve();
        }

        public static int PromptInt(string message)
        {
            int ret = -1;
            while (true)
            {
                Console.WriteLine(message);
                string str = Console.ReadLine();
                if (Int32.TryParse(str, out ret))
                    break;
                else
                    Console.WriteLine("'{0}' is invalid", str);
            }
            return ret;
        }
    }
}

