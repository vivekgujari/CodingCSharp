using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Coding
{
    public class JsonDataCreationAndConsumption
    {
        public class Student
        {
            public string Name { get; set; }
            public string Roll_no { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Student(string Name, string Roll_no, DateTime DateOfBirth)
            {
                this.Name = Name;
                this.Roll_no = Roll_no;
                this.DateOfBirth = DateOfBirth;
            }
            public Student(string Name, string Roll_no)
            {
                this.Name = Name;
                this.Roll_no = Roll_no;
            }

            public Student()
            { 
            }
        }
        public static string JsonCreation()
        {
            Student s = new Student("Vivek Gujari", "6", new DateTime(1992, 03, 21));
            string result = JsonSerializer.Serialize(s);
            return result;
        }

        public static void JsonConsume()
        {
            Student s = new Student("Vivek Gujari", "6", new DateTime(1992, 03, 21));
            string result = JsonSerializer.Serialize(s);

            Student obj = JsonSerializer.Deserialize<Student>(result);
            Console.WriteLine(obj.Name +  " " + obj.Roll_no + " " + obj.DateOfBirth);
        }

    }
}
