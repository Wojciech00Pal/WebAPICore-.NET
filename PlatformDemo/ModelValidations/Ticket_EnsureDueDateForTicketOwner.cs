using PlatformDemo.models;
using System.ComponentModel.DataAnnotations;

namespace PlatformDemo.ModelValidations
{
    public class Ticket_EnsureDueDateForTicketOwner:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;
            if(ticket != null && !string.IsNullOrWhiteSpace(ticket.Owner))
            {
                if(!ticket.DueDate.HasValue)
                {
                    //we have owner but no duedate
                    return new ValidationResult("Due date is required, when ticket has an owner");
                }
              //return new ValidationResult("lolo");
            }
            return ValidationResult.Success;
        }

    }
}
