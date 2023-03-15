using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Client
    {
        [JsonPropertyName("car_id")]
        public virtual int Client_Id { get; set; }
        [JsonPropertyName("car_id")]
        public virtual string Client_Surname { get; set; }
        [JsonPropertyName("car_id")]
        public virtual string Client_Address { get; set; }
        public virtual string Client_Phone { get; set; }
        public virtual DateTime Client_Order_Date { get; set; }
        public virtual string Client_Cargo { get; set; }
        public virtual string Client_Destination_Order { get; set; }
        public virtual int Client_Price { get; set; }
    }
}
