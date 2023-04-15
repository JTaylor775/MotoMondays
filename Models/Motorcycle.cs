using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoMondays.Models
{
    public class Motorcycle
    {
        public int MotorcycleID { get; set; }
        [Required(ErrorMessage = "VIN number is Required")]
        [DisplayName("VIN Number")]
        [RegularExpression(@"[0-9]{1}[A-Z]{4}[0-9]{1}[A-Z]{2}[0-9]{1}[A-Z]{3}[0-9]{5}",
            ErrorMessage = "Invalid VIN Number. 9XXXX9XX9XXX99999")]
        public string VINNumber { get; set; }
        [Required(ErrorMessage = "Manufacturer is Required")]
        [DisplayName("Manufacturer")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Model is required")]
        [DisplayName("Model")]
        public string ModelType { get; set; }
        [Required(ErrorMessage = "Year is Required")]
        [DisplayName("Year")]
        public string Year { get; set; }

        public Motorcycle()
        {
        }

        public Motorcycle(int motorcycleId, string vINNumber, string manufacturer, string modelType, string year)
        {
            MotorcycleID = motorcycleId;
            VINNumber = vINNumber;
            Manufacturer = manufacturer;
            ModelType = modelType;
            Year = year;
        }

        public override string ToString()
        {
            return Year + " " + Manufacturer + " " + ModelType;
        }
    }
}
