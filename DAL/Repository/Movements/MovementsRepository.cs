using DAL.Helper;
using Microsoft.Xrm.Sdk;
using System.Web.Services.Description;

namespace DAL.Repository.Movements
{
    public class MovementsRepository : IMovementsRepository
    {
        IOrganizationService _service = OrganizationServiceFactory.GetCrmService();
        public DataCollection<Entity> GetAllMovements()
        {
            string query = @"<fetch top=""50"">
                              <entity name=""m99_movement"">
                                <attribute name=""m99_movedproduct"" />
                                <attribute name=""m99_name"" />
                                <attribute name=""m99_movedquntity"" />
                                <attribute name=""m99_movedtype"" />
                              </entity>
                            </fetch>";

            var result = _service.FetchMultiple(query);

            return result;
        }

        public bool AddMovement(Entity movementModel)
        {
            try
            {
                Entity Movement = new Entity("m99_movement");
                Movement["m99_name"] = movementModel["m99_name"];
                Movement["m99_movedproduct"] = movementModel["m99_movedproduct"];
                Movement["m99_movedquntity"] = movementModel["m99_movedquntity"];
                Movement["m99_movedtype"] = movementModel["m99_movedtype"];
                _service.Create(Movement);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
