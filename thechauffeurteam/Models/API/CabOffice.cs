using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace thechauffeurteam.Models.API
{
    public class CabOffice
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string CabofficeOwner { get; set; }
        public string CabOfficeName { get; set; }
        public string DispachSystemName { get; set; }
        public string CabOfficePhoneNo{ get; set; }
        public string CabOfficeFax{ get; set; }
        public string CabOfficeEmail{ get; set; }
        public string CabOfficeAddress { get; set; }
        public string CabOfficeCity { get; set; }
        public string CabOfficePostCode { get; set; }
        
        public string CabOfficeBusinessStartDate { get; set; }
        public string CabOfficeLicenseNumber { get; set; }
        
        public string CabOfficeBusiessType { get; set; }

        public bool AcceptDiractPayment { get; set; }

        public bool LikeAccount { get; set; }

        //FLEET Detail
        
        public int NumberOfSaloon { get; set; }
        
        public int NumberOfEstate { get; set; }
        
        public int NumberOfMPV { get; set; }
        
        public int NumberOfOtherVehicle { get; set; }

    
        //INVOICE
      
        public string InvAddress { get; set; }
        
        public string InvCity { get; set; }

       
        public string InvPostCode { get; set; }
        
        public string InvPrincipalContact{ get; set; }
        
         public string InvPhone{ get; set; }
        
        public string InvFax{ get; set; }
        
        public string InvEmail{ get; set; }

        //CONTROLLER LOGIN ACCOUNT
   
        public string UserFirstName { get; set; }
        
        public string UserLastName { get; set; }
        
        public string UserMobile { get; set; }
        
        public string UserEmail { get; set; }
        
    
       public string UserPassword { get; set; }
        
        public string RefBusinessName { get; set; }

        public string RefBusinessAddress { get; set; }


        public string RefBusinessCity { get; set; }

        
        public string RefBusinessPostCode { get; set; }
        
        public string RefBusinessPhone { get; set; }
        
        public string RefBusinessFax { get; set; }
        
        public string RefBusinessEmail { get; set; }




    }
}