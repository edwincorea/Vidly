﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        
        // Navigation property
        public MembershipType MembershipType { get; set; }

        // For optimizations, we declare a foreign key. By convention: ClassName+Id
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } 
    }
}