using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtividadeMvp.Models
{
    public class SacReport
    {
        public int numeroTicket { get; set; }
        public string description { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }



        public SacReport() { }

        public SacReport(int Ticket, string description, string firstName, string email, string lastName)

        {
            numeroTicket = Ticket;
            this.description = description;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;


        }
    }
}