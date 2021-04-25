using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtividadeMvp.Models
{
    public class Cadastro
    {
        public int idUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }


        public Cadastro() { }

        public Cadastro(string firstname, string email, string lastName, string password)

        {
            this.firstName = firstName;
            this.email = email;
            this.password = password;
            this.lastName = lastName;
        }

    }
}