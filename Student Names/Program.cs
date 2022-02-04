using System;

namespace Student_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[35];// stores up to 35 inputed data
            string answer = string.Empty;// similar to " "
            string name = string.Empty;
            int count = 0;
            double average = 0, numStudents = 0, lenghtStudents = 0;

            Console.WriteLine("Would you like to enter student name? Yes or -1");
            answer = Console.ReadLine();

            if (answer != "-1")// is not -1
            {
                do
                {
                    Console.WriteLine("Enter in student full name");
                    name = Console.ReadLine();
                    while (name == string.Empty)
                    {
                        Console.WriteLine("You did not enter in a name please try agian");
                        Console.WriteLine("Enter student full name");
                        name = Console.ReadLine();
                    }
                    studentNames[count] = name.Trim();// dont count spaces
                    ++count; //add and store user data
                    Console.WriteLine("Would you like to enter in a name? Yes or -1");
                    answer = Console.ReadLine();
                } while (answer != "-1");
            }
            else
            {
                studentNames = null;
            }

            if (studentNames == null)
            {
                Console.WriteLine("There are no students");
            }
            else
            {
                Array.Sort(studentNames, (x, y) => String.Compare(x, y, StringComparison.CurrentCultureIgnoreCase));
                Console.WriteLine("\nThe students' names are:\n");
                for (int i = 0; i < studentNames.Length; i++)
                {
                    if (studentNames[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(studentNames[i].ToString());
                        lenghtStudents += studentNames[i].Length;// collects the amount of variable in student name
                        ++numStudents;// adds the amount of student
                    }
                }
                Console.WriteLine($"\nThe number of students is {numStudents}");
                average = lenghtStudents / numStudents;
                Console.WriteLine($"The average lenght of the students' names is: {average}");
            }


        }
    }
            
        }
    

