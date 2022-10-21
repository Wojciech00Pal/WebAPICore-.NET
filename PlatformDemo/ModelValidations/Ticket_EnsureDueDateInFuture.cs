﻿using PlatformDemo.models;
using System.ComponentModel.DataAnnotations;

namespace PlatformDemo.ModelValidations
{
    public class Ticket_EnsureDueDateInFuture:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Ticket;

            //when creating ticket due date has to be in future
            if(ticket!=null && ticket.TicketId==null)
            {
                if(ticket.DueDate.HasValue && ticket.DueDate.Value <System.DateTime.Now)
                {
                    return new ValidationResult("Due date has to be in the future.");
                }
            }

            return ValidationResult.Success;
           
        }
    }
}