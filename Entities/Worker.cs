using WebProjectRevision.Enums;

namespace WebProjectRevision.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }  //  foriegn key 
        public Department Department { get; set; } //pivot  entity
    }
}