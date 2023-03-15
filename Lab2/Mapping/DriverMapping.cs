using FluentNHibernate.Mapping;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Mapping
{
    public class DriverMapping: ClassMap<Driver>
    {
        public DriverMapping()
        {
            Table("driver");
            Id(x => x.Driver_Id).GeneratedBy.Increment().Column("driver_id");
            Map(x => x.Driver_Name);
            Map(x => x.Driver_Surname);
            Map(x => x.Driver_Class);
            Map(x => x.Driver_Experience);
            Map(x => x.Car_Id);
            Map(x => x.Employee_Id);
        }
    }
}
