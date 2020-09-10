using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_proqraming
{
    class Program
    {
        static void Main(string[] args)
        {
            Groups Groups = new Groups();
            string userInput;
            int Input;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please selectone of the bellow/n");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show student and add group");
                Console.WriteLine("3.Add and list group");
                Console.WriteLine("4.Show teacher list");
                Console.WriteLine("Exit");
                Console.Write(">>>>>>");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput,out Input))
                {
                    switch (Input)
                    {
                        case 1:
                            Groups.AddStudent();
                            break;
                        case 2:
                            foreach (var stu in Groups.StudentList)
                            {
                                Console.WriteLine("Id:{0},Name:{1}", stu.Id, stu.FullName);
                            }
                            break;
                            default:
                            break;

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
            } while (userInput != "5");
        }
       
    }
} 

