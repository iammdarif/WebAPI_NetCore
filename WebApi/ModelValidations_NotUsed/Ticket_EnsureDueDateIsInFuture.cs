/*

using PlatformDemo.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PlatformDemo.ModelValidations
{
    public class Ticket_EnsureDueDateIsInFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;

            if (ticket != null && ticket.DueDate.HasValue) 
            {
                if (ticket.DueDate.Value <= DateTime.UtcNow)
                {
                    return new ValidationResult("Due date should not be in the past. ");
                }
            }

            return ValidationResult.Success;
        }
    }
}
*/