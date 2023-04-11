using MotoMondays.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoMondays.Models
{
    public class MaintenanceTicket
    {
        public int MaintenanceTicketID { get; set; }
        [Required(ErrorMessage = "Ticket Description is required")]
        [DisplayName("Description")]
        public string TicketDescription { get; set; }
        [DisplayName("Description")]
        public DateTime DateSubmitted { get; set; }
        public bool? Completed { get; set; }
        [Required(ErrorMessage = "User Id is required")]
        [DisplayName("User Id Number")]
        public int UserID { get; set; }
        public User User { get; set; }
        public int MotorcycleID { get; set; }
        public Motorcycle Motorcycle { get; set; }

        public MaintenanceTicket()
        {
        }

        public MaintenanceTicket(int maintenanceTicketId, string ticketDescription, DateTime dateSubmitted, bool completed, int userId, int motorcycleId)
        {
            MaintenanceTicketID = maintenanceTicketId;
            TicketDescription = ticketDescription;
            DateSubmitted = dateSubmitted;
            Completed = completed;
            UserID = userId;
            MotorcycleID = motorcycleId;
        }
    }
}
