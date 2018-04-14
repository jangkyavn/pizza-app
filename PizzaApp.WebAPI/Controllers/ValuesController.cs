using PizzaApp.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PizzaApp.WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        IToppingService _toppingService;

        public ValuesController(IToppingService toppingService)
        {
            _toppingService = toppingService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var model = _toppingService.GetAll();

            var count = model.Count();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
