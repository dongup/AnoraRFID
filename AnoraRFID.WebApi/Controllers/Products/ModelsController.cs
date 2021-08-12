using AnoraRFID.DataAccess;
using AnoraRFID.DataAccess.DAL;
using AnoraRFID.DataAccess.DAL.Entities;
using AnoraRFID.DataAccess.Models;
using AnoraRFID.DataAccess.Models.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnoraRFID.WebApi.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ApiControllerBase
    {
        public ModelsController(AppDbContext context)
        {

        }

        [HttpGet]
        public ResponseModel<PaginationResponse<ModelResponse>> Get(string keyword, int pageIndex, int pageItem)
        {
            var rspns = new ResponseModel<PaginationResponse<ModelResponse>>();
            var items = _context.MODEL
                .Select(x => new ModelResponse()
                {
                    MODEL_ID = x.MODEL_ID,
                    MODEL_NAME = x.MODEL_NAME
                });

            return rspns.Succeed(new PaginationResponse<ModelResponse>(items, pageItem, pageIndex));
        }

        [HttpGet("{id}")]
        public ResponseModel<ModelResponse> Get(int id)
        {
            var rspns = new ResponseModel<ModelResponse>();
            var item = _context.MODEL
                .Where(x => x.MODEL_ID == id)
                .Select(x => new ModelResponse()
                {
                    MODEL_ID = x.MODEL_ID,
                    MODEL_NAME = x.MODEL_NAME
                }).FirstOrDefault();

            return rspns.Succeed(item);
        }

        [HttpPost]
        public ResponseModel<bool> Post(ModelRequest request)
        {
            var rspns = new ResponseModel<bool>();
            var newItem = new ModelEntity();
            newItem.MODEL_NAME = request.MODEL_NAME;
            _context.MODEL.Add(newItem);
            _context.SaveChanges();

            return rspns.Succeed(true);
        }

        [HttpPut("{id}")]
        public ResponseModel<bool> Put(int id, ModelRequest request)
        {
            var rspns = new ResponseModel<bool>();
            var item = _context.MODEL.Find(id);
            if (item == null) return rspns.NotFound(false);

            item.MODEL_NAME = request.MODEL_NAME;
            _context.SaveChanges();

            return rspns.Succeed(true);
        }

        [HttpPut("{id}")]
        public ResponseModel<bool> Delete(int id)
        {
            var rspns = new ResponseModel<bool>();
            var item = _context.MODEL.Find(id);
            if (item == null) return rspns.NotFound(false);

            item.IS_DELETED = true;
            item.DELETED_DATE = DateTime.Now;
            _context.SaveChanges();

            return rspns.Succeed(true);
        }
    }
}
