using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class TodoListPanel:ViewComponent
    {
        TodoListManager todoListManager = new TodoListManager(new EfTodoListDal());
        public IViewComponentResult Invoke()
        {
            var values = todoListManager.TGetList();
            return View(values);
        }
    }
}
