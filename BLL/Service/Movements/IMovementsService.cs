using BLL.Models;
using BLL.ViewModel;
using System.Collections.Generic;

namespace BLL.Service.Movements
{
    public interface IMovementsService
    {
        List<MovementsModel> Movements();
        bool AddPMovement(AddMovemetnVM model);
    }
}
