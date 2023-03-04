﻿using Microsoft.AspNetCore.Identity;

namespace Restaurant.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Address { get; set; }
    }
}
