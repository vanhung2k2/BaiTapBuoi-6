using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public int Gpa { get; set; }


        
        public Student() { }

        public Student(int id, string name, string grade , int gpa)
        {
            Id = id;
            Name = name;
            Grade = grade;
            Gpa = gpa;
        }

        public override string? ToString()
        {
            return $"{Id} | {Name} | {Grade} | {Gpa} ";
        }
    }
}
