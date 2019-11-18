using System;
using System.ComponentModel.DataAnnotations;

namespace Web_API_Application.Model
{
    public class Bike
    {
        [Key]
        public int Bike_Id { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }
        public Decimal Bike_Price { get; set; }
    }
}
