using BLL.Models;
using BLL.ViewModel;
using DAL.Repository.Movements;
using DAL.Repository.Product;
using DLL.Models;
using Microsoft.Xrm.Sdk;
using System;
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
                    CurrentStock = Product.GetAttributeValue<int>("m99_quntity"),
                   ProductId= Product.GetAttributeValue<Guid>("m99_productid")
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

        public bool AddPMovement(AddMovemetnVM model)
        {
            try
            {
                Entity entity = new Entity("m99_movement");

                // Setting the movement name
                entity["m99_name"] = model.MovedName;

                // Setting the product reference
                entity["m99_movedproduct"] = new EntityReference("m99_product", model.MovedProductId);

                // Setting the movement type (In/Out)
                entity["m99_movedtype"] = new OptionSetValue((int)model.MovmentType);

                // Setting the quantity moved
                entity["m99_movedquntity"] = model.MovedQuntity;

                // Call the repository to save the movement
                movementsRepository.AddMovement(entity);

                return true;
            }
            catch (Exception ex)
            {
                // Log exception if necessary
                return false;
            }
        }

    }
}
