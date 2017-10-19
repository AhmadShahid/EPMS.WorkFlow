using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Core.Entities
{
    public class MaintenanceWorklist
    {
        [Required]
        public int Id { get; set; }

        //Foreign key for Standard
        public int MaintenanceRequestId { get; set; }

        public MaintenanceRequest MaintenanceRequest { get; set; }
        public DateTime? AssignDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedOn { get; set; }

        public long UserId { get; set; }

        public  bool IsCompleted { get; set; }
        public DateTime? CompletedOn { get; set; }
        public long Priorty { get; set; }

        public long Status { get; set; }

    }
}
