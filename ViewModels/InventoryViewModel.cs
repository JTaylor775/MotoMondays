using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MotoMondays.Models;

namespace MotoMondays.ViewModels
{
    public class InventoryViewModel
    {
        public int MotorcycleID { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public int InventoryID { get; set; }
        public Inventory Inventory { get; set; }

        public InventoryViewModel(int motorcycleID, Motorcycle motorcycle, int inventoryID, Inventory inventory)
        {
            MotorcycleID = motorcycleID;
            Motorcycle = motorcycle;
            InventoryID = inventoryID;
            Inventory = inventory;
        }
    }
}
