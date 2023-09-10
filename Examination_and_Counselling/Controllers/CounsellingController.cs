using Microsoft.AspNetCore.Mvc;

namespace Examination_and_Counselling_Process.Controllers
{
    public class CounsellingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
