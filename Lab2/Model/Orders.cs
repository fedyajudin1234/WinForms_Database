using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Orders
    {
        public virtual int Order_Id { get; set; }
        public virtual int Client_Id { get; set; }
        public virtual int Driver_Id { get; set; }
    }
}
