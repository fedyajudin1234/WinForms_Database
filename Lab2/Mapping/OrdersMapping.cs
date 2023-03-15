using System;
using Lab2.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Lab2.Mapping
{
    public class OrdersMapping: ClassMap<Orders>
    {
        public OrdersMapping()
        {
            Table("orders");
            Id(x => x.Order_Id).GeneratedBy.Increment().Column("order_id");
            Map(x => x.Client_Id);
            Map(x => x.Driver_Id);
        }
    }
}
