/*
using PlatformDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace PlatformDemo.ModelValidations
{
    public class Ticket_EnsureDueDateForTicketOwner : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //var ticket = (Ticket)validationContext.ObjectInstance;
            var ticket = validationContext.ObjectInstance as Ticket;

            if (ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner))
            {
                if (!ticket.DueDate.HasValue)                 
                    return new ValidationResult("Due Date is required when the ticket has an owner");              

            }
            return ValidationResult.Success;
        }
    }
}
*/