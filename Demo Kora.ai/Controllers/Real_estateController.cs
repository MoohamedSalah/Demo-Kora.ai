using Microsoft.AspNetCore.Mvc;

namespace Demo_Kora.ai.Controllers
{
    public class Real_EstateController : Controller
    {
       
        public IActionResult Index() {  return Redirect("/Real_Estate/index.html"); }
    }
}
