using System;
using System.Collections;
namespace UsingHashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring Hahtable
            Hashtable studenttHT = new Hashtable();
            Student std1 = new Student() { Id = 1, Name = "Saurabh", Age = 12 };
            Student std2 = new Student() { Id = 2, Name = "Vivek", Age = 11 };
            Student std3 = new Student() { Id = 3, Name ="Lata", Age=13 };
            Student std4 = new Student() { Id = 4, Name = "Dimpi", Age = 16 };

            //Adding Enteries to Hashtable
            studenttHT.Add(std1.Id,std1);
            studenttHT.Add(std2.Id,std2);
            studenttHT.Add(std3.Id,std3);
            studenttHT.Add(std4.Id,std4);

            Console.WriteLine("---------Method 1 : Casting Entries into Student obj------------");

            //Method 1 : Casting Entries into Student obj and Retrieving Values from Hashtable 
            foreach (DictionaryEntry entry in studenttHT)
            {
                // We have to use Explicit casting to convert Entry to Student Object
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}, Name: {temp.Name},  Age: {temp.Age}");

            }

            Console.WriteLine("----------Method 2 : Directly using studenttHT.Values-----------");

            //Method 2 : Directly using ht.values and Retrieving Values from Hashtable 
            foreach (Student student in studenttHT.Values)
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name},  Age: {student.Age}");
            }

        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Student()
            {
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
            }
        }
    }
}
