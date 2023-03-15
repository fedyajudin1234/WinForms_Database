using FluentNHibernate.Mapping;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Mapping
{
    public class CarMapping : ClassMap<Car>
    {
        public CarMapping()
        {
            Table("car");
            Id(x => x.Car_Id).GeneratedBy.Increment().Column("car_id");
            Map(x => x.Car_Mark);
            Map(x => x.Car_Model);
            Map(x => x.Car_Number);
            Map(x => x.Car_Load);
            Map(x => x.Car_Cargo_Type);
            Map(x => x.Car_Condition);
        }
    }
}
