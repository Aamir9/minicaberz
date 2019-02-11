using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thechauffeurteam.Models.ViewModel
{
    public class CabOfficeVM
    {
        [Key]
        public int Id { get; set; }

        public string Status { get; set; }



        [DataType(DataType.Text)]
        [Required(ErrorMessage = "please enter Principal Contact for Correspondence/Owner")]
        public string CabofficeOwner { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your Cab office name")]
        public string CabOfficeName { get; set; }




        [Required(ErrorMessage = "Please enter your Dispatch System Name")]
        public string DispachSystemName { get; set; }



        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your  Cab office Phone")]
        public string CabOfficePhoneNo { get; set; }



        [DataType(DataType.Text)]

        [Required(ErrorMessage = "Please enter your  Cab office fax")]
        public string CabOfficeFax { get; set; }





        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your  Cab Office email")]
        public string CabOfficeEmail { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your  Cab Office address")]
        public string CabOfficeAddress { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your  Cab office city ")]
        public string CabOfficeCity { get; set; }


        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Please enter your  Cab office Postcode ")]
        public string CabOfficePostCode { get; set; }


        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [Required(ErrorMessage = "Please enter your start date")]

        public string CabOfficeBusinessStartDate { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your  License Number ")]
        public string CabOfficeLicenseNumber { get; set; }

        [DataType(DataType.Text)]

        public string CabOfficeBusiessType { get; set; }

        public bool AcceptDiractPayment { get; set; }

        public bool LikeAccount { get; set; }

        //FLEET Detail

        [Required(ErrorMessage = "Please enter your number of Saloon ")]
        [Range(0, 99, ErrorMessage = "value must be postive")]
        public int NumberOfSaloon { get; set; }

        [Required(ErrorMessage = "Please enter your number of Estate ")]
        [Range(0, 99, ErrorMessage = "value must be postive")]
        public int NumberOfEstate { get; set; }


        [Required(ErrorMessage = "Please enter your number of MPV ")]
        [Range(0, 99, ErrorMessage = "value must be postive")]
        public int NumberOfMPV { get; set; }


        [Required(ErrorMessage = "Please enter your number of Other ")]
        [Range(0, 99, ErrorMessage = "value must be postive")]
        public int NumberOfOtherVehicle { get; set; }


        //INVOICE
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your address")]
        public string InvAddress { get; set; }



        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your invoice city")]
        public string InvCity { get; set; }



        [DataType(DataType.Text)]
        public string InvPostCode { get; set; }



        [Required(ErrorMessage = "Please enter your invoice Principal Contact")]
        [DataType(DataType.Text)]
        public string InvPrincipalContact { get; set; }


        [Required(ErrorMessage = "Please enter your Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string InvPhone { get; set; }



        [Required(ErrorMessage = "Please enter your Invoice fax")]
        public string InvFax { get; set; }



        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email")]
        public string InvEmail { get; set; }

        //CONTROLLER LOGIN ACCOUNT
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your firt name")]
        public string UserFirstName { get; set; }


        [Required(ErrorMessage = "Please enter your last name")]
        [DataType(DataType.Text)]
        public string UserLastName { get; set; }



        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string UserMobile { get; set; }



        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }




        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]

        public string UserPassword { get; set; }




        [Required(ErrorMessage = "Confirm Password is required")]

        [Compare("UserPassword")]
        [DataType(DataType.Password)]
     
        public string confirmPassword { get; set; }




        //REFERENSE
        [DataType(DataType.Text)]

        [Required(ErrorMessage = "please enter your  Business Name")]
        public string RefBusinessName { get; set; }



        [Required(ErrorMessage = "please enter your  Business address")]
        [DataType(DataType.Text)]
        public string RefBusinessAddress { get; set; }




        [DataType(DataType.Text)]
        [Required(ErrorMessage = "please enter your  Business City")]
        public string RefBusinessCity { get; set; }



        [DataType(DataType.Text)]

        public string RefBusinessPostCode { get; set; }



        [Required(ErrorMessage = "please enter your  Business Phone Number")]

        [DataType(DataType.PhoneNumber)]
        public string RefBusinessPhone { get; set; }


        [Required(ErrorMessage = "Please enter your Business Fax Number")]
        [DataType(DataType.Text)]
        public string RefBusinessFax { get; set; }



        [Required(ErrorMessage = "please enter your  Business Email")]
        [DataType(DataType.EmailAddress)]
        public string RefBusinessEmail { get; set; }


    }
}