using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult TopnavPartial()
        {
            return PartialView();
        }
    }
}
