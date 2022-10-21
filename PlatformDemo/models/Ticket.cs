using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo.models
{
    public class Ticket
    {
        [FromQuery(Name ="tid")]
        public int TicketId { get; set; }
        [FromQuery(Name = "pid")]
        public int ProjectId { get; set; }
        [FromQuery(Name = "tit")]
        public string Title { get; set; }
        public string description { get; set; }
    }
}