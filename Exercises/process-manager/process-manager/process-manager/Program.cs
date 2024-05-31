using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace process_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] prList = Process.GetProcesses();

            Console.WriteLine ("select an operation" + "\n" + "1.start process" + "\n" + "2.show list of processes\n3.kill process\n4.show the parent of a process");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Enter a process name");
                    String input2 = Console.ReadLine();

                    try
                    {
                        Process.Start(input2);
                        prList = Process.GetProcesses();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("an error occured" + e.Message);
                    }
                    Console.ReadKey();
                    break;

                case 2:
                    foreach (Process p in prList)
                    {
                        Console.WriteLine(p.Id + " " + p.ProcessName);
                    }
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Enter a process id");
                    int input3 = int.Parse(Console.ReadLine());


                    foreach (Process p in prList)
                    {
                        if (p.Id == input3)
                        {
                            p.Kill();
                            Console.WriteLine("Successfull");
                        }
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Enter a process id");
                    int input4 = int.Parse(Console.ReadLine());


                    foreach (Process p in prList)
                    {
                        if (p.Id == input4)
                        {
                            Console.WriteLine(p.Handle);
                        }
                    }
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
