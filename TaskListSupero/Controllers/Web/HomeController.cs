using System.Web.Mvc;
using TaskListSupero.Models;

namespace TaskListSupero.Controllers
{
    public class HomeController : Controller
    {
        ITaskListSuperoRepository _repository;

        public HomeController(ITaskListSuperoRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}