using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_part2
{
    internal class Nurses : Employees
    {
        int OverTimeHours;
        public Nurses(int EmpId, string EmpName, int empAge, int NoOfDays,  string EmpGender ,int OverTimeHours) : base(EmpId, EmpName, empAge, NoOfDays,  EmpGender)
        {
            this.OverTimeHours = OverTimeHours;
        }
        public int SetOverTimeHours(int overload)
        {
            EmpSalary += overload * 50;
            return EmpSalary;
        }

        public override int CalculateSalary()
        {
            if (NoOfDays >= 4 && NoOfDays <= 6)
            {
                EmpSalary = 1000;
                return EmpSalary;
            }
                
            else if (NoOfDays < 4)
            {
                EmpSalary = 400;
                return EmpSalary;
            }
            return EmpSalary;
        }
        public override string PrintData()
        {
            return ("ID: " + EmpId + " Name: " + EmpName + " Age: " + EmpAge + " Gender: " + EmpGender + " Dayes: " + NoOfDays + " Salary: " + EmpSalary + " OverTimeHours: " + OverTimeHours);
        }
    }
}
