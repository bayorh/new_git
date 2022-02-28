using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebProjectRevision.Context;
using WebProjectRevision.Entities;
using WebProjectRevision.interfaces.Irepositories;

namespace WebProjectRevision.implementations.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly WebAppRevisionContext _workerContext;
        public WorkerRepository(WebAppRevisionContext workerContext)
        {
            _workerContext = workerContext;
        }
        public Worker Create(Worker worker)
        {
            _workerContext.Workers.Add(worker);
            _workerContext.SaveChanges();
            return worker;
        }

        public Worker Get(int id)
        {
            return _workerContext.Workers.Include(d => d.Department).FirstOrDefault(w => w.Id == id);
        }

        public List<Worker> GetAll()
        {
            return _workerContext.Workers.Include(d => d.Department).ToList();
        }

        public void Remove(Worker worker)
        {
            _workerContext.Workers.Remove(worker);
            _workerContext.SaveChanges();

        }

        public Worker Update(Worker worker)
        {
            _workerContext.Workers.Update(worker);
            _workerContext.SaveChanges();
            return worker;

        }
    }
}