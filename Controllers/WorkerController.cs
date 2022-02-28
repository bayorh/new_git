using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebProjectRevision.Dtos;
using WebProjectRevision.interfaces.IServices;

namespace WebProjectRevision.Controllers
{
    public class WorkerController : Controller
    {
        private readonly IWorkerService _workerService;
        private readonly IDepartmentService _departmentService;

        public WorkerController(IWorkerService workerService, IDepartmentService departmentService)
        {
            _workerService = workerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var worker = _workerService.GetWorkers();
            return View(worker);
        }
        [HttpGet]
        public IActionResult Create()
        {
             var department = _departmentService.GetAllDepartment();
             ViewData["Department"] = new SelectList(department,"Id","DepartmentName"); 
            return View();
        }
         [HttpPost]
        public IActionResult Create(CreateWorkerRequestModel model)
        {
            _workerService.AddWorker(model);
             
            return RedirectToAction ("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var worker = _workerService.GetWoker(id);
             if (worker == null)
            {
                return NotFound();
            }
            return View(worker);
        }
         [HttpPost]
        public IActionResult Update(UpdateWorkerREquestMOdel model)
        {
            _workerService.UpdateWorker(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
         public IActionResult Delete(int id)
        {
          var worker=   _workerService.GetWoker(id);
            if (worker == null)
            {
                return NotFound();
            }

            return View(worker);
        }
        [HttpPost , ActionName ( "Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _workerService.Delete(id);
            return RedirectToAction("index");
        }
         [HttpGet]
        public IActionResult Details(int id)
        {
            var worker = _workerService.GetWoker(id);
             if (worker == null)
            {
                return NotFound();
            }
            return View(worker);
        }

    }
}