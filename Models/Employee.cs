using System.ComponentModel.DataAnnotations;
using System;
namespace netcoreproject.Models
{
    public class Employee
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]
        public string Username {get; set;}

        public string Status {get; set;}

        public DateTime ReleaseDate { get; set; }

    }
}