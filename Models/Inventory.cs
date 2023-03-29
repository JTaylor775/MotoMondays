using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoMondays.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int MotorcycleID { get; set; }
        public Motorcycle Motorcycles { get; set; }
        public decimal Miles { get; set; }
        [Required(ErrorMessage = "Preowned is Required")]
        [DisplayName("Preowned")]
        public bool PreOwned { get; set; }
        public Inventory()
        {
        }
        public Inventory(int inventoryId, int motorcycleId, decimal miles, bool preOwned)
        {
            InventoryId = inventoryId;
            MotorcycleID = motorcycleId;
            Miles = miles;
            PreOwned = preOwned;
        }
    }
}
