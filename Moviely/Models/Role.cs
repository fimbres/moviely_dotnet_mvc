﻿using Microsoft.AspNetCore.Identity;

namespace Moviely.Models
{
    public class Role : IdentityRole
    {
        public Role() : base() { }
        public Role(string name) : base(name) { }
    }
}
