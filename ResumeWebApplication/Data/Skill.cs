using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Data
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Percent { get; set; }
        public Author Author { get; set; }
        public int AuhtorId { get; set; }
    }
}