using DAL.Helper;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Product
{
    public class ProductRepository : IProductRepository
    {
            IOrganizationService service = OrganizationServiceFactory.GetCrmService();
        public DataCollection<Entity> GetProductList()
        {
            string query = @"
                            <fetch top=""50"">
                              <entity name='m99_product'>
                                <attribute name='m99_name'/>
                                <attribute name='m99_quntity'/>
                              </entity>
                            </fetch>
                            ";

            var res = service.FetchMultiple(query);
            return res;
        }
    }
}
