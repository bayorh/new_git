using System.Collections.Generic;

namespace WebProjectRevision.Dtos
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public List<WorkerDto> Workers { get; set; } = new List<WorkerDto>();
    }
    public class CreateDepartmentRequestModel
    {
        public string DepartmentName { get; set; }
        
        public string DepartmentCode { get; set; }
    }
    public class UpdateDepartmentRequestModel
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
    }

}
