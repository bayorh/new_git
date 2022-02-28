using System.Collections.Generic;
using WebProjectRevision.Dtos;

namespace WebProjectRevision.interfaces.IServices
{
    public interface IDepartmentService
    {
        bool CreateDepartment(CreateDepartmentRequestModel model);
        bool UpdateDepartment(UpdateDepartmentRequestModel model);
        void RemoveDepartment(int id);
        DepartmentDto GetDepartment(int id);
        List<DepartmentDto> GetAllDepartment();
    }
}