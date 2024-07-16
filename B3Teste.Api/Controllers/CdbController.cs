using B3.CdbCalc.Application.Interfaces;
using B3.CdbCalc.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace B3Teste.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CdbController : ControllerBase
    {
        private readonly ICdbCalc cdbCalc;

        public CdbController(ICdbCalc _cdbCalc)
        {
            cdbCalc = _cdbCalc;
        }

        [HttpGet("valores/{valorInicial}/{prazoResgate}")]
        [ProducesResponseType(typeof(IEnumerable<(decimal, decimal)>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IEnumerable<Cdb> GetWithdrwalValues(decimal valorInicial, decimal prazoResgate)
        {
            var result = cdbCalc.DenominateValue(valorInicial, prazoResgate);

            return result;
        }
    }
}
