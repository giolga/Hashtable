using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "El Kumi", 99f);
            Student stud2 = new Student(2, "Alex", 90f);
            Student stud3 = new Student(3, "Max", 82f);
            Student stud4 = new Student(4, "Charles", 100f);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent = (Student)studentsTable[1];

            Console.WriteLine(storedStudent);

            foreach (DictionaryEntry entry in studentsTable)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }

        public override string ToString()
        {
            return $"Student Id {Id}, Name {Name}, GPA {GPA}";
        }
    }
}
