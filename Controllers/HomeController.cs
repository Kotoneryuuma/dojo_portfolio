using Microsoft.AspNetCore.Mvc;

namespace HelloASp
{
    public class HomeController : Controller
    {
        [HttpGet]       //type of request
        [Route("")] 
        public ViewResult index(){
            return View("index");
        }

        [HttpGet]       //type of request
        [Route("projects")] 
        public ViewResult List(){
            return View("list");
        }

        [HttpGet]       //type of request
        [Route("contact")] 
        public ViewResult Contact(){
            return View("contact");
        }

    }
}