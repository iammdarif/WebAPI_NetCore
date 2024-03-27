/*
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PlatformDemo.Models;

namespace PlatformDemo.Filters
{
    public class Ticket_ValidateDatesActionFilter : ActionFilterAttribute //Ticket_EnsureEnteredDate
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var ticket = context.ActionArguments["ticket"] as Ticket;

            if (ticket != null && 
                !string.IsNullOrWhiteSpace(ticket.Owner))
            {
                bool isValid = true;

                if(ticket.EnteredDate.HasValue == false)
                   { 
                    context.ModelState.AddModelError("EnteredDate", "Entered Date is required."); 
                    isValid = false;
                    }
                    

                if (ticket.EnteredDate.HasValue && 
                    ticket.DueDate.HasValue && 
                    ticket.EnteredDate > ticket.DueDate)
                   { 
                    context.ModelState.AddModelError("EnteredDate", "Due date has to be greater than Entered Date.");
                    isValid &= false;
                    }

                //var problemDetails = new ValidationProblemDetails(context.ModelState)
                //{
                //    Status = StatusCodes.Status400BadRequest,
                //};

                if ((!isValid))
                {
                    context.Result = new BadRequestObjectResult(context.ModelState);
                }              

                
            }
        }
    }
}
*/