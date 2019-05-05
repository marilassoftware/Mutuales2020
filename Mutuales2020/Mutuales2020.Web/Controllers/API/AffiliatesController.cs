namespace Mutuales2020.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Mutuales2020.Web.Data;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[Controller]")]
    public class AffiliatesController : Controller
    {
        private readonly IRepository repository;

        public AffiliatesController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAffiliate([FromBody] List<Mutuales.Common.Models.Affiliate> Affiliate)
        {
            var JSONLista = JsonConvert.SerializeObject(Affiliate);
            var respuesta = this.repository.AddAffiliateSp(JSONLista);
            return Ok(respuesta);
        }


    }
}