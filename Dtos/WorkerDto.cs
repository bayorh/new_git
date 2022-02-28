using WebProjectRevision.Entities;
using WebProjectRevision.Enums;

namespace WebProjectRevision.Dtos
{
    public class WorkerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentName { get; set; } 
        
    }
    public class CreateWorkerRequestModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender sex { get; set; }
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } 


    }
     public class UpdateWorkerREquestMOdel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public string PhoneNumber { get; set; }
    }
    

}