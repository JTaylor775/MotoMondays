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
        public string VINNumber { get; set; }
        [Required(ErrorMessage = "Manufacturer is Required")]
        [DisplayName("Manufacturer")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Model is required")]
        [DisplayName("Model")]
        public string ModelType { get; set; }
        [Required(ErrorMessage = "Year is Required")]
        [DisplayName("Year")]
        public DateTime Year { get; set; }

        public Motorcycle()
        {
        }

        public Motorcycle(int motorcycleId, string vINNumber, string manufacturer, string modelType, DateTime year)
        {
            MotorcycleID = motorcycleId;
            VINNumber = vINNumber;
            Manufacturer = manufacturer;
            ModelType = modelType;
            Year = year;
        }
    }
}
