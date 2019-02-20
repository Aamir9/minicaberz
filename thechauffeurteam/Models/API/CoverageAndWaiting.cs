using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace thechauffeurteam.Models.API
{
    public class CoverageAndWaiting
    {

        public int id { get; set; }


        
        public string postCode { get; set; }

        public string waiting { get; set; }

        public int CabOfficeId { get; set; }

        [ForeignKey("CabOfficeId")]
        public CabOffice CabOffice { get; set; }
    }
}