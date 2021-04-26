using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAtividadeMvp.Models;

namespace AppAtividadeMvp.DAL
{
    public class CadastroDAL
    {

        private static Dictionary<long, Cadastro> bancoCadastro = new Dictionary<long, Cadastro>();
        private static int contadorBanco = 1;

        static CadastroDAL()
        {
            Cadastro tecnico = new Cadastro();
            tecnico.idUser = 1;
            tecnico.firstName = "Renan";
            tecnico.lastName = "Mendes";
            tecnico.email = "renan@renan.com";
            tecnico.password = "senha@123";

            bancoCadastro.Add(1, tecnico);
        }

        public void Inserir(Cadastro cadastro)
        {
            contadorBanco++;
            cadastro.idUser = contadorBanco;
            bancoCadastro.Add(contadorBanco, cadastro);
        }

        public Cadastro Consultar(int IdUser)
        {
            return bancoCadastro[IdUser];
        }

        public IList<Cadastro> Listar()
        {
            return new List<Cadastro>(bancoCadastro.Values);
        }

        public void Excluir(int IdUser)
        {
            bancoCadastro.Remove(IdUser);
        }

        public void Alterar(Cadastro cadastro)
        {
            bancoCadastro[cadastro.idUser] = cadastro;
        }
    }
}