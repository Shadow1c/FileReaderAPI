using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using System.ComponentModel.DataAnnotations;

namespace FileReaderAPI.Model
{
    public class Order
    {
        [Required]
        public string Number { get; set; }
        [Required]
        public string ClientCode { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        [Format("dd/MM/yyyy")]
        public DateTime OrderDate { get; set; }
        [Format("dd/MM/yyyy")]
        public DateTime ShipmentDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool Confirmed { get; set; }
        [Required]
        public double Value { get; set; }
    }
}
