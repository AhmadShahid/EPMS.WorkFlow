using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPMS.WorkFlow.Web.ViewModels.MaintenanceRequest
{
    public class MaintenanceRequestVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Customer Phone Num")]
        [Phone()]
        public string ContactNo { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "Address")]
        public string Adress { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public int RequestBy { get; set; }


        [StringLength(500)]
        [Display(Name = "Reason")]
        public string RequestReason { get; set; }

    
        public DateTime CreatedOn { get; set; }

    }
}