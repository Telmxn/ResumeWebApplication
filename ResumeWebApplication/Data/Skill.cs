using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Data
{
    public class Skill
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public byte Percent { get; set; }
        public Author Author { get; set; }
        public int AuhtorId { get; set; }
    }
}