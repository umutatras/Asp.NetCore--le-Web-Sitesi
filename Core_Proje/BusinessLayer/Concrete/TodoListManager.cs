using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TodoListManager : ITodoListService
    {
        ITodoListDal _todoListDal;

        public TodoListManager(ITodoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public void Tadd(TodoList t)
        {
            _todoListDal.Insert(t);
        }

        public void TDelete(TodoList t)
        {
            _todoListDal.Delete(t);
        }

        public TodoList TGetByID(int id)
        {
           return _todoListDal.GetById(id);
        }

        public List<TodoList> TGetList()
        {
            return _todoListDal.GetList();
        }

        public void TUpdate(TodoList t)
        {
            _todoListDal.Update(t);
        }
    }
}
