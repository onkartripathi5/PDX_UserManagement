﻿using System.ComponentModel.DataAnnotations;

namespace PdxUsers.Models
{
    public class User
    {
        public int Id { set; get; }
        [Required]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Mobile { set; get; }

        public string Role { set; get; }

        public string Location { set; get; }

        public string lastLogin { set; get; }
    }
}