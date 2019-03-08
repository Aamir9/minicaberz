using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thechauffeurteam.Models.ViewModel
{
    public class jobVM
    {

        public int id { get; set; }

        public int? PassengerId { get; set; }

        public Passenger passenger { get; set; }


        
        public string PassengerName { get; set; }
        public string PassengerPhone { get; set; }


        public string postcode { get; set; }
        public string DriverId { get; set; }
        public string DriverName { get; set; }
        public string dateAndTime { get; set; }


        [Required(ErrorMessage ="Pick Up address is required")]
        public string pickUp { get; set; }


        [Required(ErrorMessage = "Drop Off address is required")]
        public string DropUP { get; set; }

        public string CarType { get; set; }

        public string JobType { get; set; }



        public string textDurantion { get; set; }

        public string Price { get; set; }

        public string DriverMessage { get; set; }

        public int? status { get; set; }

        public int? Hours { get; set; }

        public int? Mile { get; set; }
    }
}