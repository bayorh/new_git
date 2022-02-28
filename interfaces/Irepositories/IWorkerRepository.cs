using System.Collections.Generic;
using WebProjectRevision.Entities;

namespace WebProjectRevision.interfaces.Irepositories
{
    public interface IWorkerRepository
    {
         Worker Create(Worker worker);
         Worker Update( Worker worker);
         Worker Get(int id);
         List <Worker> GetAll();
         void Remove(Worker worker);

    }
}