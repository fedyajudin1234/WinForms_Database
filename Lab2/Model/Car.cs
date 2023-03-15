using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Car
    {
        [JsonPropertyName("car_id")]
        public virtual int Car_Id { get; set; }
        [JsonPropertyName("car_mark")]
        public virtual string Car_Mark { get; set; }
        [JsonPropertyName("car_model")]
        public virtual string Car_Model { get; set; }
        [JsonPropertyName("car_number")]
        public virtual string Car_Number { get; set; }
        [JsonPropertyName("car_load")]
        public virtual int Car_Load { get; set; }
        [JsonPropertyName("car_cargo_type")]
        public virtual string Car_Cargo_Type { get; set; }
        [JsonPropertyName("car_condition")]
        public virtual int Car_Condition { get; set; }
    }
}
