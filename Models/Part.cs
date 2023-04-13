using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoMondays.Models
{
    public class Part
    {
        public int PartID { get; set; }
        [Required(ErrorMessage = "Part name is required")]
        [DisplayName("Part Name")]
        public string PartName { get; set; }
        [Required(ErrorMessage = "In stock is required")]
        [DisplayName("In stock")]
        public bool InStock { get; set; }

        public Part()
        {
        }

        public Part(int partId, string partName, bool inStock)
        {
            PartID = partId;
            PartName = partName;
            InStock = inStock;
        }
    }
}
