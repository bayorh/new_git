using System.Collections.Generic;
using System.Linq;
using WebProjectRevision.Dtos;
using WebProjectRevision.Entities;
using WebProjectRevision.interfaces.Irepositories;
using WebProjectRevision.interfaces.IServices;

namespace WebProjectRevision.implementations.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public bool CreateDepartment(CreateDepartmentRequestModel model)
        {
            var department = new Department
            {
                DepartmentName = model.DepartmentName,
                DepartmentCode = model.DepartmentCode,
            };
            _departmentRepository.Create(department);
            return true;

        }
        public DepartmentDto GetDepartment(int id)
        {
            var department = _departmentRepository.Get(id);
            return new DepartmentDto
            {
                Id = department.Id,
                DepartmentCode = department.DepartmentCode,
                DepartmentName = department.DepartmentName
            };
        }

        public List<DepartmentDto> GetAllDepartment()
        {
            return _departmentRepository.Getall().Select(d => new DepartmentDto
            {
                Id = d.Id,
                DepartmentCode = d.DepartmentCode,
                DepartmentName = d.DepartmentName
            }).ToList();
        }
        public void RemoveDepartment(int id)
        {
            var department = _departmentRepository.Get(id);
            _departmentRepository.Delete(department);

        }
        public bool UpdateDepartment(UpdateDepartmentRequestModel model)
        {
            var department = _departmentRepository.Get(model.Id);
            department.DepartmentCode = model.DepartmentCode;
            department.DepartmentName = model.DepartmentName;
            _departmentRepository.Update(department);
            return true;
        }
    }
}