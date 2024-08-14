using Microsoft.AspNetCore.Mvc;

namespace Demo_Kora.ai.Controllers
{
    public class BankingController : Controller
    {
       
        public IActionResult Index() {  return Redirect("/Banking/index.html"); }
    }
}
