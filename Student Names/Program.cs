using System;

namespace Student_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[35];
            string answer = string.Empty;
            int i = 0;
            do
            {
                Console.WriteLine("Please enter student full");
                studentName[i] = Console.ReadLine();
                i++;//increase and store in array 
            } while (answer == "-1");
            {
                Console.WriteLine(studentName.Length);
            }
        }
    }
}
