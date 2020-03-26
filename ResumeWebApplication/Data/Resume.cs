using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Data
{
    public class Resume
    {
        public int Id { get; set; }
        public string WorkName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string WorkPlace { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public string About { get; set; }
    }
}