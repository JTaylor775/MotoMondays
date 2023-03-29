using BookFace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotoMondays.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        [Required(ErrorMessage = "Schedule is Required")]
        [DisplayName("Employee Schedule")]
        public string ScheduleDays { get; set; }
        [Required(ErrorMessage = "Hours is Required")]
        [DisplayName("Employee Hours")]
        public string ScheduleHours { get; set; }
        [Required(ErrorMessage = "Wage is Required")]
        [Range(7.25, 100.00, ErrorMessage = "Wage must be between $7.25 and $100")]
        [DisplayName("Hourly Wage")]
        public decimal Wage { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

        public Schedule()
        {
        }
        public Schedule(int scheduleId, string scheduleDays, string scheduleHours, decimal wage, int userId)
        {
            ScheduleID = scheduleId;
            ScheduleDays = scheduleDays;
            ScheduleHours = scheduleHours;
            Wage = wage;
            UserID = userId;
        }
    }
}