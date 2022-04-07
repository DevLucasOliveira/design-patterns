using System;
using System.Diagnostics;

namespace SingleResponsibilityPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");
            Console.WriteLine(journal);

            var persistence = new Persistence();
            var fileName = @"c:\temp\journal.txt";
            persistence.SaveToFile(journal, fileName, true);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                }
            };
            process.Start();
        }
    }
}
