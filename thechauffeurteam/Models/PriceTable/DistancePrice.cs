using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thechauffeurteam.Models
{
    public class DistancePrice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MileFrom { get; set; }
        [Required]
        public int MileTo { get; set; }
        [Required]
        public float SclassFirstMile { get; set; }
        [Required]
        public float SclassPerMile { get; set; }
        [Required]
        public float VclassFirstMile { get; set; }
        [Required]
        public float VclassPerMile { get; set; }
        [Required]
        public float EclassFirstMile { get; set; }
        [Required]
        public float EclassPerMile { get; set; }

    }

    public class ChauffeurPrice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MileFrom { get; set; }
        [Required]
        public int MileTo { get; set; }
        [Required]
        public float SclassFirstMile { get; set; }
        [Required]
        public float SclassPerMile { get; set; }
        [Required]
        public float VclassFirstMile { get; set; }
        [Required]
        public float VclassPerMile { get; set; }
        [Required]
        public float EclassFirstMile { get; set; }
        [Required]
        public float EclassPerMile { get; set; }

    }
    public class HourlyPrice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int HourFrom { get; set; }
        [Required]
        public int HourTo { get; set; }
        [Required]
        public float SclassPerHour { get; set; }
        [Required]
        public float VclassPerHour { get; set; }
        [Required]
        public float EclassPerHour { get; set; }


        [Required]
        public float SPerHour{ get; set; }


        [Required]
        public float EPerHour { get; set; }


        [Required]
        public float MPerHour { get; set; }

    }
    public class FixPrice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PickUp { get; set; }
        [Required]
        public string DropOff { get; set; }
        [Required]
        public float Sclass { get; set; }
        [Required]
        public float Vclass { get; set; }
        [Required]
        public float Eclass { get; set; }

    }
    public class PostCode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PostCodeValue { get; set; }
        
    }

    }