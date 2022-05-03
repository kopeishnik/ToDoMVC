using Microsoft.AspNetCore.Mvc;
using ToDoMVC1.Models;

namespace ToDoMVC1.Controllers
{
    public class TasksController : Controller
    {
        private ITasksRepository repository;
        public TasksController(ITasksRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View("Index", repository.Tasks);
    }
}
