using DAL.Helper;
using Microsoft.Xrm.Sdk;

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
    }
}
