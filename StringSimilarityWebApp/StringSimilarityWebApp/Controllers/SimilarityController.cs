using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using F23.StringSimilarity;
using Newtonsoft.Json;
using StringSimilarityWebApp.BusinessLogic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StringSimilarityWebApp.Controllers
{
    public class SimilarityController : ApiController
    {
        [HttpGet]
        [System.Web.Http.Route("api/{param}/distance")]
        public string GetDistanceOutput(string param)
        {
           StringSimilarityWebApp.OperationsUtil.ComputeThresholds(param);
           string result = "";
           result = System.Text.Json.JsonSerializer.Serialize(StringSimilarityWebApp.OperationsUtil.distance_d);
           return result;
        }

        [HttpGet]
        [System.Web.Http.Route("api/{param}/similarity")]
        public string GetSimilarityOutput(string param)
        {
            StringSimilarityWebApp.OperationsUtil.ComputeThresholds(param);
            string result = "";
            result = System.Text.Json.JsonSerializer.Serialize(StringSimilarityWebApp.OperationsUtil.similarity_d);
            return result;
        }
    }
}
