using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Employee
    {
        public virtual int Employee_Id { get; set; }
        public virtual string Employee_Name { get; set; }
        public virtual string Employee_Surname { get; set; }
        public virtual string Employee_Address { get; set; }
        public virtual DateTime Employee_Date_Of_Birth { get; set; }
        public virtual string Employee_Job { get; set; }
        public virtual int Employee_Salary { get; set; }
        public virtual string Employee_Hire_Number { get; set; }
        public virtual DateTime Employee_Hire_Date { get; set; }
    }
}
