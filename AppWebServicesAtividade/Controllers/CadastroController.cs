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
    public class CadastroController : ApiController
    {

        public IHttpActionResult Get()
        {
            return Ok(new CadastroDAL().Listar());
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                CadastroDAL dal = new CadastroDAL();
                Cadastro Cadastro = dal.Consultar(id);
                return Ok(Cadastro);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        public IHttpActionResult Post([FromBody] Cadastro Cadastro)
        {
            try
            {
                CadastroDAL dal = new CadastroDAL();
                dal.Inserir(Cadastro);

                string location = Url.Link("DefaultApi", new { controller = "cadastro", id = Cadastro.idUser });

                return Created(new Uri(location), Cadastro);

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
                CadastroDAL dal = new CadastroDAL();
                dal.Excluir(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult Put([FromBody] Cadastro cadastro)
        {
            try
            {
                CadastroDAL dal = new CadastroDAL();
                dal.Alterar(cadastro);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
