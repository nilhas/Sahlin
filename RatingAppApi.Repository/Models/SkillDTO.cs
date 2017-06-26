﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingAppApi.Business.Models
{
    public class SkillDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Expertise { get; set; }
        [Required]
        public int Value { get; set; }
       
    }
  
}
