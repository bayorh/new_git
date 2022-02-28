using System.Collections.Generic;
using WebProjectRevision.Dtos;

namespace WebProjectRevision.interfaces.IServices
{
    public interface IWorkerService
    {
        bool AddWorker(CreateWorkerRequestModel model);
        bool UpdateWorker(UpdateWorkerREquestMOdel model);
        void Delete(int id);
        WorkerDto GetWoker(int id);
        List<WorkerDto> GetWorkers();
    }
}