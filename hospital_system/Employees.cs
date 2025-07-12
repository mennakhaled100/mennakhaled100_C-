using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_part2
{
    public abstract class Employees
    {
        protected int EmpId;
        protected string EmpName;
        protected int EmpAge;
        protected int NoOfDays;
        protected int EmpSalary;
        protected string EmpGender ;

        public Employees(int EmpId , string EmpName, int EmpAge, int NoOfDays, string EmpGender)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
            this.NoOfDays = NoOfDays;
            this.EmpGender = EmpGender;
        }
        public int ID
        {
            get { return this.EmpId; }
        }
        public string Name
        {
            get { return this.EmpName; }
        }
        public int Age
        {
            get { return this.EmpAge; }
        }
        public int Days
        {
            set
            {
                if (value < 3)
                    value = 3;
                else if (value > 6)
                    value = 6;
            }
            get { return this.NoOfDays; }
        }
        
        public string Gender
        {
            get { return this.EmpGender; }
        }
        public virtual string PrintData()
        {
            return ("ID: " + EmpId + " Name: " + EmpName + " Age: " + EmpAge + " Gender: " + EmpGender + " Dayes: " + NoOfDays + " Salary: " + EmpSalary);
        }
       
        public abstract int CalculateSalary();

    }
}
