using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtividadeMvp.Models
{
    public class Cadastro
    {
        //public DateTime AtividadeIni{ get; set; }
        //public DateTime AtividadeFim { get; set; }
        //public string TipoAtividade { get; set; }
        //public string Assunto { get; set; }
        //public int IdEmpreendimento { get; set; }
        //public int IdBloco { get; set; }
        //public int IdUnidade { get; set; }
        public int idUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }


        public Cadastro() { }

        //public Assistencia(DateTime Inicio, DateTime Fim, string Tipo, string Assunto, int Empreendimento, int Bloco, int Unidade, string NameFirst, string Email)
        public Cadastro(string firstname, string email, string lastName, string password)

        {
            //AtividadeIni = Inicio;
            //AtividadeFim = Fim;
            //TipoAtividade = Tipo;
            //this.Assunto = Assunto;
            //IdEmpreendimento = Empreendimento;
            //IdBloco = Bloco;
            //IdUnidade = Unidade;
            this.firstName = firstName;
            this.email = email;
            this.password = password;
            this.lastName = lastName;
        }

    }
}