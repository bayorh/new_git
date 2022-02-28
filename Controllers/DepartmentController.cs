using Microsoft.AspNetCore.Mvc;
using WebProjectRevision.Dtos;
using WebProjectRevision.interfaces.IServices;

namespace WebProjectRevision.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var department = _departmentService.GetAllDepartment();
            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateDepartmentRequestModel model)
        {
            _departmentService.CreateDepartment(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }
        [HttpPost]
        public IActionResult Update(UpdateDepartmentRequestModel model)
        {
            _departmentService.UpdateDepartment(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);

        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _departmentService.RemoveDepartment(id);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var department = _departmentService.GetDepartment(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }


    }

}