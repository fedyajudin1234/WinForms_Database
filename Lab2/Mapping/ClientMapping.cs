using System;
using Lab2.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Lab2.Mapping
{
    public class ClientMapping: ClassMap<Client>
    {
        public ClientMapping()
        {
            Table("client");
            Id(x => x.Client_Id).GeneratedBy.Increment().Column("client_id");
            Map(x => x.Client_Surname);
            Map(x => x.Client_Address);
            Map(x => x.Client_Phone);
            Map(x => x.Client_Order_Date);
            Map(x => x.Client_Cargo);
            Map(x => x.Client_Destination_Order);
            Map(x => x.Client_Price);
        }
    }
}
