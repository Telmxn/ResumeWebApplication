using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [StringLength(maximumLength:50,MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:60,MinimumLength =3)]
        public string Surname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int ProjectsComplete { get; set; }
        [Required]
        public int CupsOfCoffee { get; set; }
        [Required]
        public int AwardsAmount { get; set; }
        [Required]
        public int HappyCustomers { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string Work { get; set; }
        [Required]
        public ICollection<Service> Services { get; set; }
        [Required]
        public ICollection<Skill> Skills { get; set; }
        [Required]
        public ICollection<Project> Projects { get; set; }
    }
}