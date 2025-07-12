using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task4_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                //Doctors
                Console.WriteLine($"Enter id of d{i}: ");
                int EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter name of d{i} :");
                string EmpName = Console.ReadLine();
                Console.WriteLine($"Enter age of d{i}: ");
                int EmpAge = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter NoOfDays of d{i}: ");
                int NoOfDays = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter gender of d{i} : ");
                string EmpGender = Console.ReadLine();
                Console.WriteLine($"Enter nofpatient of d{i}: ");
                int NoOfPatients = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter experience of d{i}: ");
                int Experience = int.Parse(Console.ReadLine());
                
                Doctors d = new Doctors(EmpId, EmpName, EmpAge, NoOfDays,  EmpGender, Experience, NoOfPatients);
                Console.WriteLine($"Data of d{i}");
                d.Exp(Experience);
                d.Patients(NoOfPatients);
                
                d.CalculateSalary();
                Console.WriteLine(d.PrintData());
                d.Exp(Experience);
                d.Patients(NoOfPatients);

                d.CalculateSalary();
                i++;
            } while (i < 0);
            //Nurses
            int x = 1;
            do
            {
                Console.WriteLine($"Enter id of n{x}: ");
                int EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter name of n{x} :");
                string EmpName = Console.ReadLine();
                Console.WriteLine($"Enter age of n{x}: ");
                int EmpAge = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter NoOfDays of n{x}: ");
                int NoOfDays = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter gender of n{x} : ");
                string EmpGender = Console.ReadLine();
                Console.WriteLine($"Enter  overload of n{x}: ");
                int OverTimehours = int.Parse(Console.ReadLine());

                Nurses n = new Nurses(EmpId, EmpName, EmpAge, NoOfDays, EmpGender, OverTimehours);
                Console.WriteLine($"Data of n{x}");
                n.SetOverTimeHours(OverTimehours);
                n.CalculateSalary();
                Console.WriteLine(n.PrintData());
                n.SetOverTimeHours(OverTimehours);
                n.CalculateSalary();
                x++;
            } while (x < 3);

        }

    }
}
