using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebProjectRevision.Context;
using WebProjectRevision.Entities;
using WebProjectRevision.interfaces.Irepositories;

namespace WebProjectRevision.implementations.Repositories
{

    public class DepartmentRepository : IDepartmentRepository

    {
        private readonly WebAppRevisionContext _DepartmentContext;
        public DepartmentRepository(WebAppRevisionContext DepartmentContext)
        {
            _DepartmentContext = DepartmentContext;
        }
        public Department Create(Department department)
        {
            _DepartmentContext.Departments.Add(department);
            _DepartmentContext.SaveChanges();
            return department;
        }

        public void Delete(Department department)
        {
            _DepartmentContext.Departments.Remove(department);
            _DepartmentContext.SaveChanges();

        }

        public Department Get(int id)
        {
            return _DepartmentContext.Departments.FirstOrDefault(d => d.Id == id);
        }

        public List<Department> Getall()
        {
            return _DepartmentContext.Departments.Include(w => w.Workers).ToList();
        }

        public Department Update(Department department)
        {
            _DepartmentContext.Departments.Update(department);
            _DepartmentContext.SaveChanges();
            return (department);
        }
    }
}