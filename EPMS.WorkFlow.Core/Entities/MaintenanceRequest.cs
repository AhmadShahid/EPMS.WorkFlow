using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Core.Entities
{
    public class MaintenanceRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }

        [Required]
        public string ContactNo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(250)]
        public string Email { get; set; }

        [Required]
        public int RequestBy{ get; set; }

        [Required]
        [MaxLength(500)]
        public string RequestReason { get; set; }

        public DateTime CreatedOn { get; set; }


    }
}
