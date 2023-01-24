using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CarSharing_Angajati.Models
{
    
    public partial class Employees
    {

        [Key] public int EmpId { get; set; }
        [Column(TypeName = "Nvarchar(50)")]
        [DisplayName("Name:")]
        [Required]
        public string EmpName { get; set; }

        [DisplayName("BirthDate:")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? EmpBirthDate { get; set; }  = DateTime.Now;

        [DisplayName("IDNP:")]
        [MaxLength(14)]
        [MinLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "IDNP must be numeric.")]
        [Required]    
        public string EmpIDNP { get; set; }

        [Column(TypeName = "Nvarchar(10)")]
        [DisplayName("Gender:")]
        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "Nvarchar(50)")]
        [DisplayName("Email:")]
        public string? EmpEmail { get; set; }

        [Column(TypeName = "Nvarchar(150)")]
        [DisplayName("Adress:")]
        [Required]
        public string EmpAdress { get; set; }

        [DisplayName("Phone Number:")]
        [MaxLength(10)]
        [MinLength(9)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number must be numeric.")]
        [Required]
        public string EmpPhoneNumber { get; set; }

        [Column(TypeName = "Nvarchar(50)")]
        [DisplayName("Driver License:")]
        [Required] 
        public string EmpDriverLicense { get; set; }

        [Column(TypeName = "Nvarchar(50)")]
        [DisplayName("Employee Position:")]
        [Required]
        public string? EmpPosition { get; set; }

    }
}
