using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppAtividadeMvp.Models;
using AppAtividadeMvp.DAL;

namespace AppAtividadeMvp.Controllers
{
    public class SacReportController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new SacReportDAL().Listar());
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                SacReportDAL dal = new SacReportDAL();
                SacReport sacReport = dal.Consultar(id);
                return Ok(sacReport);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        public IHttpActionResult Post([FromBody] SacReport SacReport)
        {
            try
            {
                SacReportDAL dal = new SacReportDAL();
                dal.Inserir(SacReport);

                string location = Url.Link("DefaultApi", new { controller = "sacreport", id = SacReport.numeroTicket });

                return Created(new Uri(location), SacReport);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                SacReportDAL dal = new SacReportDAL();
                dal.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Put([FromBody] SacReport sacReport)
        {
            try
            {
                SacReportDAL dal = new SacReportDAL();
                dal.Alterar(sacReport);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
