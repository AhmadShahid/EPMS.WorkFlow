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
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerNo{ get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        public string ContactNo { get; set; }


        public string Adress { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public long RequestBy{ get; set; }

        [Required]
        public long RequestType { get; set; }

        public  DateTime CreatedOn { get; set; }


    }
}
