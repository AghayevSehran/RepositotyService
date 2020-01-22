using System;
using System.ComponentModel.DataAnnotations;

namespace SampleArch.Model
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        // ScaffoldColumn(false) is used So that ASP.NET MVC 
        //Scaffolding will NOT generate controls for this in Views
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }


        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdatedDate { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
    }
}
