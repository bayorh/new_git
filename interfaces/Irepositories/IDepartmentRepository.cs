using System.Collections.Generic;
using WebProjectRevision.Entities;

namespace WebProjectRevision.interfaces.Irepositories
{
    public interface IDepartmentRepository
    {
         Department Create (Department department); 
         Department Update (Department department); 
         Department Get(int  id);
         List<Department> Getall();
         void Delete (Department department);

    }
}