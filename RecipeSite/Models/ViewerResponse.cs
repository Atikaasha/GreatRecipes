using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipeSite.Models
{
    public class ViewerResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Please let us know your opinion")]
        public bool? DoYouLike { get; set; }
    }
}
