﻿using System;
using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain.Transport.Railway
{
    public class RailwaySystem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(5000)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string MapPicture { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}