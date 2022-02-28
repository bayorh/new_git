using System.Collections.Generic;

namespace WebProjectRevision.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string  DepartmentCode { get; set; }
        public List<Worker> Workers { get; set; }
    }
}