using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Data
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50, MinimumLength =2)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}