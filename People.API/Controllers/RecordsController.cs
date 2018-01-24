using People.API.Infrastructure;
using System;
using System.Net;
using System.Web.Http;

namespace People.API.Controllers
{
    public class RecordsController : ApiController
    {
        private readonly IPeopleService _peopleService;
        public RecordsController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            try
            {
                return Content(HttpStatusCode.OK, _peopleService.GetPeopleList());
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpPost]
        public IHttpActionResult Index([FromBody]string delimetedPersonRecord)
        {
            try
            {
                return Content(HttpStatusCode.OK, _peopleService.AddToPeopleList(delimetedPersonRecord));
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        public IHttpActionResult Gender()
        {
            try
            {
                return Content(HttpStatusCode.OK, _peopleService.GetPeopleListByGender());
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        public IHttpActionResult BirthDate()
        {
            try
            {
                return Content(HttpStatusCode.OK, _peopleService.GetPeopleListByBirthdate());
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e);
            }
        }

        [HttpGet]
        public IHttpActionResult Name()
        {
            try
            {
                return Content(HttpStatusCode.OK, _peopleService.GetPeopleListByName());
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
