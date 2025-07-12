using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_part2
{
    internal class Doctors : Employees
    {
        protected int Experience;
        protected int NoOfPatients;

        public Doctors(int EmpId, string EmpName, int empAge, int NoOfDays, string EmpGender, int Experience, int NoOfPatients) : base(EmpId, EmpName, empAge, NoOfDays, EmpGender)
        {
            this.Experience = Experience;
            this.NoOfPatients = NoOfPatients;
        }

        public int Exp(int Experience)
        {

            if (Experience < 10)
            {
                Experience = 10;
                return Experience;
            }
            else if (Experience > 20)
            {
                Experience = 20;
                return Experience;
            }
            return Experience;
        }

        public int Patients(int NoOfPatients)
        {
            if (NoOfPatients< 10)
            {
                NoOfPatients = 10;
                return NoOfPatients;
            }
            else if (NoOfPatients > 20)
            {
                NoOfPatients = 20;
                return NoOfPatients;
            }
            return NoOfPatients;
        }
        public override int CalculateSalary()
        {
            if (Experience >= 5 && Experience <= 10)
            {
                if (NoOfPatients >= 10 && NoOfPatients <= 20)
                {
                    if (NoOfDays >= 3 && NoOfDays <= 6)
                    {
                        EmpSalary = 2000;
                        return EmpSalary;
                    } 
                }
            }
            else if (Experience > 10)
            {
                EmpSalary = 2500;
                return EmpSalary;
            }
               

            return EmpSalary;
        }

        public override string PrintData()
        {
            return ("ID: " + EmpId + " Name: " + EmpName + " Age: " + EmpAge + " Gender: " + EmpGender + " Dayes: " + NoOfDays + " Salary: " + EmpSalary + " Experience: " + Experience + " Patients: "+ NoOfPatients);
        }
    }
}
