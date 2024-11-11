using BLL.Models;
using DAL.Repository.Movements;
using DAL.Repository.Product;
using DLL.Models;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace BLL.Service.Movements
{
    public class MovementsService : IMovementsService
    {
        private readonly IMovementsRepository movementsRepository;
        private readonly IProductRepository productRepository;

        public MovementsService(IMovementsRepository movementsRepository, IProductRepository productRepository)
        {
            this.movementsRepository = movementsRepository;
            this.productRepository = productRepository;
        }

        public List<MovementsModel> Movements()
        {
            DataCollection<Entity> FetchDataResult = movementsRepository.GetAllMovements();

            List<MovementsModel> Movements = new List<MovementsModel>();
            ProductModel productModel;

            foreach (Entity entity in FetchDataResult)
            {
                var ProductEntityRefernce = entity.GetAttributeValue<EntityReference>("m99_movedproduct");
                var Product = productRepository.GetProductById(ProductEntityRefernce.Id);
                productModel = new ProductModel
                {
                    Name = Product.GetAttributeValue<string>("m99_name"),
                    CurrentStock = Product.GetAttributeValue<int>("m99_quntity")
                };
                var optionst = entity.GetAttributeValue<OptionSetValue>("m99_movedtype");
                Movements.Add(new MovementsModel
                {
                    MovedName = entity.GetAttributeValue<string>("m99_name"),
                    MovedProductId = entity.GetAttributeValue<EntityReference>("m99_movedproduct").Id,
                    MovedQuntity = entity.GetAttributeValue<int>("m99_movedquntity"),
                    MovmentType = entity.GetAttributeValue<OptionSetValue>("m99_movedtype").Value,
                    Product = productModel,
                });
            }

            return Movements;

        }
    }
}
