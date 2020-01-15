using Microsoft.AspNetCore.Mvc;

// TODO: edit the Index Action to return the Lucky7 class output as "new ContentResult" rather than a view
namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        // GET: /<controller>/
        //[Route("Spinner/Index/{id:range(1,9)")]
        public IActionResult Index(int id = 7)
        {
            return new ContentResult{ Content=new Lucky7().Output(id), ContentType="text/html"};
        }
    }
}
