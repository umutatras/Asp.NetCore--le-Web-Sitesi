using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminTwoController : Controller
    {
    
        public PartialViewResult LeftSideBar()
        {
            return PartialView();
        }
    }
}
