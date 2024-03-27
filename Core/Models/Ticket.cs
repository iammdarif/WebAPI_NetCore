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

        [Ticket_EnsureDueDatePresent]
        [Ticket_EnsureDueDateOnCreation]
        [Ticket_EnsureDueDateAfterReportdate]
        public DateTime? DueDate { get; set; }

        [Ticket_EnsureReportDatePresent]
        public DateTime? ReportDate { get; set; }

        public Project Project { get; set; }

        /// <summary>
        /// When creating a ticket, if due date is entered, 
        /// it has to be in the future
        /// </summary>
        /// <returns></returns>
        public bool ValidateDueDate()
        {
            if (TicketId.HasValue) return true;
            if (!DueDate.HasValue) return true;

            return (DueDate.Value > DateTime.Now);
        }

        /// <summary>
        /// When owner is assigned, the reportdate has to be present
        /// </summary>
        /// <returns></returns>
        public bool ValidateReportDatePresence()
        { 
            if(string.IsNullOrWhiteSpace(Owner)) return true;

            return ReportDate.HasValue;
        }

        /// <summary>
        /// When owner is assigned, the duedate has to be present
        /// </summary>
        /// <returns></returns>
        public bool ValidateDueDatePresence()
        {
            if (string.IsNullOrWhiteSpace(Owner)) return true;

            return DueDate.HasValue;
        }

        /// <summary>
        /// When duedate and reportdate are present, the due date ha to be 
        /// on later or equal to reportdate
        /// </summary>
        /// <returns></returns>
        public bool ValidateDueDateAfterReportDate()
        {
            if (!DueDate.HasValue || !ReportDate.HasValue) return true;

            return DueDate.Value.Date >= ReportDate.Value.Date;
        }

    }
}
