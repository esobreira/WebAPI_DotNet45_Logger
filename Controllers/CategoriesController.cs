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
    public class CategoriesController : ApiController
    {
        private const string CATEGORIES = "Categories";
        private readonly ILogger _logger;

        public CategoriesController(ILogger logger)
        {
            _logger = logger;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            _logger.Log(LogLevel.Info, $"{CATEGORIES} : {MethodBase.GetCurrentMethod().Name}");

            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            _logger.Log(LogLevel.Info, $"{CATEGORIES} : {MethodBase.GetCurrentMethod().Name}");

            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
            _logger.Log(LogLevel.Info, $"{CATEGORIES} : {MethodBase.GetCurrentMethod().Name}");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
            _logger.Log(LogLevel.Info, $"{CATEGORIES} : {MethodBase.GetCurrentMethod().Name}");
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _logger.Log(LogLevel.Info, $"{CATEGORIES} : {MethodBase.GetCurrentMethod().Name}");
        }
    }
}