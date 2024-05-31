using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_read_write
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select 1 or 2\n1.Write to JSON\n2.Read from JSON");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter student information in the following manner:");
                        Console.WriteLine("first-name,last-name,height,weight");
                        String input = Console.ReadLine();
                        String[] values = input.Split(',');
                        Student std1 = new Student(values[0], values[1], values[2], values[3]);
                        string json = JsonConvert.SerializeObject(std1);
                        String path = @"D:";

                        File.WriteAllText(path, json);
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter path");
                    String path2 = Console.ReadLine();
                    String file = File.ReadAllText(path2);
                    var jsonObj = JsonConvert.DeserializeObject(file);
                    //I don't know what to do with this object
                    Console.WriteLine(jsonObj);
                    Console.ReadKey();
                    break;

            }
        }

        class Student
        {
            public String fname;
            public String lname;
            public String height;
            public String weight;

            public Student(String fname, String lname, String height, String weight)
            {
                this.fname = fname;
                this.lname = lname;
                this.height = height;
                this.weight = weight;
            }
        }
    }
}
