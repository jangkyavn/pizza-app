using PizzaApp.Service.Interfaces;
using PizzaApp.WebAPI.Infrastructures;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaApp.WebAPI.Controllers
{
    [RoutePrefix("api/topping")]
    public class ToppingController : ApiControllerBase
    {
        private readonly IToppingService _toppingService;

        public ToppingController(
            IErrorService errorService,
            IToppingService toppingService) : base(errorService)
        {
            _toppingService = toppingService;
        }

        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _toppingService.GetAll();
                var response = request.CreateResponse(HttpStatusCode.OK, model);

                return response;
            });
        }
    }
}
