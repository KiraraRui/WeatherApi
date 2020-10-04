using System.Collections.Generic;
using System.Web.Http;
using WeatherApi.Data;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    public class PlaceController : ApiController
    {
        private DataContext dataContext;
        public PlaceController()
        {
            dataContext = new DataContext();
        }

        // GET api/values
        [Route("api/getall")]
        public List<Place> GetAll()
        {
            return dataContext.GetAllPlaces();
        }

        // GET api/values/5
        [Route("api/get")]
        public Place Get(int id)
        {
            return dataContext.GetPlace(id);
        }

       
    }
}
