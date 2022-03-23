using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;


namespace TicketApp.Models
{
    [Table("Ticket")]
    internal class Ticket
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public string cityFrom { get; set; }
        public string cityTo { get; set; }
        public DateTime day { get; set; }
        public string departureTime { get; set; }
        public string arrivalTime { get; set; }
        public string time { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
    }
}
