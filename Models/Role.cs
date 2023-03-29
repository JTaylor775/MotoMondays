using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoMondays.Models
{
    public class Role : IdentityRole<int>
    {
        public override int Id { get; set; }
        public override string Name { get; set; }

        public Role() { }

        public Role(string name)
        {
            Name = name;
        }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

        
