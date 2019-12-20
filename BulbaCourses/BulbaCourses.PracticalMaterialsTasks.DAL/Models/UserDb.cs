﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourses.PracticalMaterialsTasks.DAL.Models
{
    public class UserDb
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}