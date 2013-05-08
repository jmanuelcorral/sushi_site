using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Sushi.ModelBinders;

namespace site.Controllers
{
    public class GridAPIController : ApiController
    {
        //Returns A GridResponse for use with a Sushi Grid
        public GridResponse Get()
        {
            IQueryable<Models.Person> people = Models.MyRepository.GetPeople().AsQueryable();
            var results = new APIGridAdapter<Models.Person>(Request.RequestUri, people);
            return results.Process();

        }

    }
}
