using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Driver
    {
        public virtual int Driver_Id { get; set; }
        public virtual string Driver_Name { get; set; }
        public virtual string Driver_Surname { get; set; }
        public virtual int Driver_Class { get; set; }
        public virtual int Driver_Experience { get; set; }
        public virtual int Car_Id { get; set; }
        public virtual int Employee_Id { get; set; }
    }
}
