﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjetoJL_API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    public class PedidoController : ApiController
    {
        // GET: api/Pedido
        [Route("api/pedido/filtro")]
        public IHttpActionResult Get(string filtro)
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pedido/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pedido
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pedido/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pedido/5
        public void Delete(int id)
        {
        }
    }
}
