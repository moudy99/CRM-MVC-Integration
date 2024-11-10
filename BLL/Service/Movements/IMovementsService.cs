using BLL.Models;
using System.Collections.Generic;

namespace BLL.Service.Movements
{
    public interface IMovementsService
    {
        List<MovementsModel> Movements();
    }
}
