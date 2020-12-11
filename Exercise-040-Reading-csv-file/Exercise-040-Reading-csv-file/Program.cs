using Exercise_040_Reading_csv_file.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the path of a .csv file containing the data of sold items. Each item has a name, unit price and quantity, separated by 
             *commas.You must generate a new file called "summary.csv", located in a subfolder called "out" from the original folder of the source file,
             *containing only the name and the total value for that item (unit price multiplied by quantity).*/

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            /* Source File:                                      Output file (out/summary.csv):
             * TV LED,1290.99,1                                  TV LED,1290.99
             * Video Game Chair,350.50,3                         Video Game Chair,1051.50
             * Iphone X,900.00,2                                 Iphone X,1800.00
             * Samsung Galaxy 9,850.00,2                         Samsung Galaxy 9,1700.00*/
        }
    }
}