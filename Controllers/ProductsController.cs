using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace WebAPI_NLogger.Controllers
{
    public class ProductsController : ApiController
    {
        private const string PRODUCTS = "ProductsController";
        private readonly LogSingleton _logInstance = LogSingleton.Instance;

        //private readonly ILogger _logger;

        //public ProdutctsController(ILogger logger)
        //{
        //    _logger = logger;
        //}

        public ProductsController()
        {

        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            _logInstance.Log($"{PRODUCTS} : {MethodBase.GetCurrentMethod().Name}");

            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            _logInstance.Log($"{PRODUCTS} : {MethodBase.GetCurrentMethod().Name}");

            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            _logInstance.Log($"{PRODUCTS} : {MethodBase.GetCurrentMethod().Name}");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            _logInstance.Log($"{PRODUCTS} : {MethodBase.GetCurrentMethod().Name}");
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _logInstance.Log($"{PRODUCTS} : {MethodBase.GetCurrentMethod().Name}");
        }
    }
}