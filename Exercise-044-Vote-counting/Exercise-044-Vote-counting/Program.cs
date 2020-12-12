using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise_044_Vote_counting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*When counting votes in an election, several voting records are generated containing the candidate's name and the amount of votes he obtained 
             *in a ballot box. Make a program to read the voting records from a file, and then generate a consolidated report with the totals of each 
             *candidate.*/

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
            /*INPUT FILE EXAMPLE:                                           OUTPUT:
             * Alex Blue,15                                                 Alex Blue: 76
             * Maria Green,22                                               Maria Green: 71
             * Bob Brown,21                                                 Bob Brown: 61
             * Alex Blue,30
             * Bob Brown,15
             * Maria Green,27
             * Maria Green,22
             * Bob Brown,25
             * Alex Blue,31                                                           */
        }
    }
}
