﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_lineas.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = String.Empty;

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;



    }
}
