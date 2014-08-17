using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {

		     String text = "A class is the most powerful data type in C#."+
                            " Like a Boss, " +
                       "a class defines the data and behavior of the data type. ";
        // WriteAllText creates a file, writes the specified string to the file, 
        // and then closes the file.
        File.WriteAllText(@"C:\Users\Public\WriteText.txt", text);

        // Example #1 
        // Read the file as one string. 
        string textRead = File.ReadAllText(@"C:\Users\Public\WriteText.txt");

        string[] textR = File.ReadAllLines(@"C:\Users\Public\WriteText.txt");

        // Display the file contents to the console. Variable text is a string.
        Console.WriteLine("Contents of WriteText.txt = {0}", textRead);

        foreach (String line in textR) {
            Console.WriteLine(line);
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
        }
    }
}
