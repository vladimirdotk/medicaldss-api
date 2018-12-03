using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using medicaldss_api.Models.Leptospirosis;

namespace medicaldss_api.Controllers.Leptospirosis
{
    [Route("api/leptospirosis/[controller]")]
    [ApiController]
    public class NeuralNetworkController: ControllerBase
    {
        // POST api/leptospirosis/neuralnetwork
        [HttpPost]
        public ActionResult<Dictionary<string, string>> Post([FromBody] LaboratoryData model)
        {
            return new Dictionary<string, string> {
                { "coagulopathy_option", Prognosis.N_386_MLP_7_30_6(model.getMarks()) }
            };
        }
    }
}