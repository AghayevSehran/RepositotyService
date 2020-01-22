using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleArch.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Country Name")]
        public string Name { get; set; }

        public virtual IEnumerable<Person> Persons { get; set; }
    }
}