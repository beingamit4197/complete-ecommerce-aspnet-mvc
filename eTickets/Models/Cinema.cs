using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display( Name = "Cinema Logo")]
        [Required(ErrorMessage = "Logo is Require")]

        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is Require")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 chars.")]

        public string Name { get; set; }
        
        [Display( Name = "Description")]
        [Required(ErrorMessage = "Description is Require")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
