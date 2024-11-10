using Microsoft.Xrm.Sdk;

namespace DAL.Repository.Movements
{
    public interface IMovementsRepository
    {
        DataCollection<Entity> GetAllMovements();
    }
}
