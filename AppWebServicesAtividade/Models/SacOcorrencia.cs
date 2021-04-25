using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtividadeMvp.Models
{
    public class SacReport
    {
        public int numeroTicket { get; set; }
        //public int idCliente { get; set; }        
        //public int IdEmpreendimento { get; set; }
        //public int IdBloco { get; set; }
        //public int IdUnidade { get; set; }
        //public int Bandeira { get; set; }

        public string description { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }



        public SacReport() { }

        //public Ocorrencia(int Ticket, int Cliente, int Empreendimento, int Bloco, int Unidade, int Bandeira, string Descricao) 
        public SacReport(int Ticket, string description, string firstName, string email, string lastName)

        {
            //numeroTicket = Ticket;
            //idCliente = Cliente;
            //IdEmpreendimento = Empreendimento;
            //IdBloco = Bloco;
            //IdUnidade = Unidade;
            //this.Bandeira = Bandeira;

            numeroTicket = Ticket;
            this.description = description;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;


        }
    }
}