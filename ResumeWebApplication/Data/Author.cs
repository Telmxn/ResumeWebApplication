using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeWebApplication.Data
{
    public class Author
    {
        public Author()
        {
            Services = new HashSet<Service>();
            Skills = new HashSet<Skill>();
            Projects = new HashSet<Project>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ProjectsComplete { get; set; }
        public int CupsOfCoffee { get; set; }
        public int AwardsAmount { get; set; }
        public int HappyCustomers { get; set; }
        public string Website { get; set; }
        public string About { get; set; }
        public string Work { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}