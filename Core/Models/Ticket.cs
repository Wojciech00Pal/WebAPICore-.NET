using Core.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class Ticket
    {
        public int? TicketId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [Ticket_EnsureReportDatePresent]
        public DateTime? ReportDate { get; set; }
        [Ticket_EnsureDueDateAfterReportDate]
        [Ticket_EnsureDueDatePresent]
        [Ticket_EnsureFutureDueDateOnCreation]
        public DateTime? DueDate { get; set; }

        public Project Project { get; set; }

        //due date in the future should be
        public bool ValidateFutureDueDate()
        {
            if (TicketId.HasValue) return true;
            if(!DueDate.HasValue) return true;

            return (DueDate.Value > DateTime.Now);
        }
        //when owner is assigned to ticket,the report date has to be present
        public bool ValidateReportDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return ReportDate.HasValue;
        }
        //when owner is assigned to ticket,the duedate date has to be present

        public bool ValidateDueDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return DueDate.HasValue;
        }
        //when duedate and reportday are present,duedate has to be later than reportDate
        public bool ValidateDueDateAftrReportDate()
        {
            if (!DueDate.HasValue || !ReportDate.HasValue) return true;

            return (DueDate.Value.Date >= ReportDate.Value.Date);

        }

    }
}
