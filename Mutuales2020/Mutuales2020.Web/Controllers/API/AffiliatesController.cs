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

        [HttpGet]
        public async Task<IActionResult> get()
        {
            return Ok("Ok");
        }

        [HttpPost]
        public async Task<IActionResult> PostAffiliate([FromBody] List<Mutuales.Common.Models.Affiliate> Affiliate)
        {
            string respuesta = string.Empty;
            try
            {
                var JSONLista = JsonConvert.SerializeObject(Affiliate);
                respuesta = this.repository.AddAffiliateSp(JSONLista);
            }
            catch (Exception ex)
            {

            }
            return Ok(respuesta);
        }
    }
}