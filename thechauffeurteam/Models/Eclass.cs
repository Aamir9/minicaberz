using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thechauffeurteam.Models
{
    public class Eclass
    {
        public int id { get; set; }

        public float FirstMile { get; set; }

        [Required(ErrorMessage ="per miles is required")]
        public float PerMiles { get; set; }
    }
}