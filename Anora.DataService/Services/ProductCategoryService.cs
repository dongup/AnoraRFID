//using Anora.DataService.Protos;
//using AnoraRFID.DataAccess.DAL;
//using AnoraRFID.DataAccess.DAL.Entities;
//using Grpc.Core;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Anora.DataService.Services
//{
//    public class ProductCategoryService : Model.ProductCategoryBase
//    {
//        private readonly AppDbContext _context;
//        public ProductCategoryService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public override async Task<bool> Add(ModelRequest request, ServerCallContext context)
//        {
//            ModelEntity newItem = new ModelEntity();
//            newItem.MODEL_NAME = request.Name;
//            _context.MODEL.Add(newItem);
//            _context.SaveChanges();

//            return bool;
//        }
//    }
//}
