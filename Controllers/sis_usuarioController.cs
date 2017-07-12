using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Models;

namespace Controllers
{
    public class sis_usuarioController : ApiController
    {
        // GET: api/sis_usuario
        public IHttpActionResult Getsis_usuario()
        {
            var usr = new SIS_USUARIO();

            usr.id = 1;
            usr.NOME = "Teste GET";
            usr.PWD = "123";
            usr.ADMIN = "S";

            return Ok(usr);
        }

        // GET: api/acoes/5
        [ResponseType(typeof(SIS_USUARIO))]
        public IHttpActionResult Getsis_usuario(int id)
        {
            var usr = new SIS_USUARIO();

            usr.id = id;
            usr.NOME = "Teste GET/id";
            usr.PWD = "12323";
            usr.ADMIN = "S";

            return Ok(usr);
        }

        // PUT: api/acoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsis_usuario(int id, SIS_USUARIO dados)
        {
            
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/acoes
        [ResponseType(typeof(SIS_USUARIO))]
        public IHttpActionResult Postacoes(SIS_USUARIO dados)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/acoes/5
        [ResponseType(typeof(SIS_USUARIO))]
        public IHttpActionResult Deletesis_usuario(int id)
        {
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}