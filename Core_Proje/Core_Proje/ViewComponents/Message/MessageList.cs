using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Message
{
    public class MessageList : ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = userMessageManager.GetUserMEssageWithUserService();
            return View(values);
        }
    
    }
}
