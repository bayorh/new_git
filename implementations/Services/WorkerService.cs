using System.Collections.Generic;
using System.Linq;
using WebProjectRevision.Dtos;
using WebProjectRevision.Entities;
using WebProjectRevision.interfaces.Irepositories;
using WebProjectRevision.interfaces.IServices;

namespace WebProjectRevision.implementations.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository  _workerRepository;
         
        public WorkerService(IWorkerRepository  workerRepository)
        {
            _workerRepository = workerRepository; 
        }
        public bool AddWorker(CreateWorkerRequestModel model) 
        {
            // map the model to the properties of the domain class
            var worker = new Worker
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                PhoneNumber = model.PhoneNumber,
                Age = model.Age,
                Sex = model.sex,
                DepartmentId =model.DepartmentId,
                Department = model.Department           
            };
            _workerRepository.Create(worker);
            return  true;
            
        }

        public void Delete(int id)
        {
            var worker = _workerRepository.Get(id);
            _workerRepository.Remove(worker);

        }

        public WorkerDto GetWoker(int id)
        {
            var worker = _workerRepository.Get(id);
            return new WorkerDto
            {
                Id = worker.Id,
                FirstName = worker.FirstName,
                MiddleName = worker.MiddleName, 
                LastName = worker.LastName,
                Age = worker.Age,
                Sex = worker.Sex,
                PhoneNumber = worker.PhoneNumber,
                DepartmentName = worker.Department.DepartmentName
                
            };
        }

        public List<WorkerDto> GetWorkers()
        {
            return _workerRepository.GetAll().Select(w => new WorkerDto
            {
                Id = w.Id,
                FirstName = w.FirstName,
                LastName = w.LastName,
                MiddleName = w.MiddleName,
                Age = w.Age,
                Sex = w.Sex,
                PhoneNumber = w.PhoneNumber,
                DepartmentName = w.Department.DepartmentName
            }).ToList();
        
        }

        public bool UpdateWorker(UpdateWorkerREquestMOdel model)
        {
            var worker = _workerRepository.Get(model.Id);
            worker.Age = model.Age;
            worker.FirstName = model.FirstName;
            worker.PhoneNumber = model.PhoneNumber;
            worker.LastName = model.LastName;
            worker.MiddleName = model.MiddleName;
            worker.Sex = model.Sex;
            _workerRepository.Update(worker);
            return true;

        }
    }
}