using FluentNHibernate.Mapping;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Mapping
{
    public class EmployeeMapping : ClassMap<Employee>
    {
        public EmployeeMapping() {
            Table("employee");
            Id(x => x.Employee_Id).GeneratedBy.Increment().Column("employee_id");
            Map(x => x.Employee_Name);
            Map(x => x.Employee_Surname);
            Map(x => x.Employee_Address);
            Map(x => x.Employee_Date_Of_Birth);
            Map(x => x.Employee_Job);
            Map(x => x.Employee_Salary);
            Map(x => x.Employee_Hire_Number);
            Map(x => x.Employee_Hire_Date);
        }
    }
}
