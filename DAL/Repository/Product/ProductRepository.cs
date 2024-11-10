﻿using DAL.Helper;
using Microsoft.Xrm.Sdk;
using System;

namespace DAL.Repository.Product
{
    public class ProductRepository : IProductRepository
    {
        IOrganizationService service = OrganizationServiceFactory.GetCrmService();

        public Entity GetProductById(Guid id)
        {
            string fetchXml = $@"
                        <fetch top='1'>
                          <entity name='m99_product'>
                            <all-attributes />
                            <filter>
                              <condition attribute='m99_productid' operator='eq' value='{id}' />
                            </filter>
                          </entity>
                        </fetch>";
            Entity product = service.Fetch(fetchXml);
            return product;
        }

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
