using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAtividadeMvp.Models;

namespace AppAtividadeMvp.DAL
{
    public class SacReportDAL
    {
        private static Dictionary<long, SacReport> bancoOcorrencia = new Dictionary<long, SacReport>();
        private static int contadorBanco = 2;

        static SacReportDAL()
        {
            SacReport ocorrencia = new SacReport();
            //ocorrencia.numeroTicket = 1;
            //ocorrencia.IdBloco = 2;
            //ocorrencia.IdEmpreendimento = 30;
            //ocorrencia.IdUnidade = 23;
            //ocorrencia.idCliente = 5;
            ocorrencia.description = "Nao consegui acessar o tutorial do Ifood";
            //ocorrencia.Bandeira = 3;

            ocorrencia.numeroTicket = 1;
            ocorrencia.firstName = "Renan";
            ocorrencia.lastName = "Mendes";
            ocorrencia.email = "teste@teste.com";

            bancoOcorrencia.Add(1, ocorrencia);
        }

        public void Inserir(SacReport ocorrencia)
        {
            contadorBanco++;
            ocorrencia.numeroTicket = contadorBanco;
            bancoOcorrencia.Add(contadorBanco, ocorrencia);
        }

        public SacReport Consultar(int numeroTicket)
        {
            return bancoOcorrencia[numeroTicket];
        }

        public IList<SacReport> Listar()
        {
            return new List<SacReport>(bancoOcorrencia.Values);
        }

        public void Excluir(int numeroTicket)
        {
            bancoOcorrencia.Remove(numeroTicket);
        }

        public void Alterar(SacReport ocorrencia)
        {
            bancoOcorrencia[ocorrencia.numeroTicket] = ocorrencia;
        }
    }
}