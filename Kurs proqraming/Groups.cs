using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_proqraming
{
    class Groups
    {
        public string GroupsName { get; set; }
        public int Day { get; set; }
        public List<Students> StudentList { get; set; }

        public Groups()
        {
            StudentList = new List<Students>();
        }

        public void AddStudent()
        {
            Console.WriteLine("/n****************");
            Console.Write("Please write student name:");
            string name = Console.ReadLine();
            if (name.Length > 2)
            {
                Students stu = new Students(name);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("/nStudent added succesfully");

            }
            else
            {

            }
        }
    }
}