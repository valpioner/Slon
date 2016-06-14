using Slon.DataAccess;
using Slon.DTO;
using Slon.Model;
using Slon.Persistence;
using Slon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Slon.API.Controllers
{
    public class ItemsController : ApiController
    {
        private readonly IServices<ItemDTO> _itemService;

        public ItemsController()
        {
            _itemService = new ItemServices();
        }

        // GET: api/Items
        public HttpResponseMessage Get()
        {
            var items = _itemService.GetAll();
            if (items != null)
            {
                var itemsDTO = items as List<ItemDTO> ?? items.ToList();
                if (itemsDTO.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, itemsDTO);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "item not found");
        }

        // GET: api/Items/5
        public HttpResponseMessage Get(int id)
        {
            var item = _itemService.GetById(id);
            if (item != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, item);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No item found for this id");
        }

        // POST: api/Items
        public int Post([FromBody]ItemDTO itemDTO)
        {
            return _itemService.Create(itemDTO);
        }

        // PUT: api/Items/5
        public bool Put(int id, [FromBody]ItemDTO itemDTO)
        {
            if (id > 0)
            {
                return _itemService.Update(id, itemDTO);
            }
            return false;
        }

        // DELETE: api/Items/5
        public bool Delete(int id)
        {
            if (id > 0)
            {
                return _itemService.Delete(id);
            }
            return false;
        }
    }
}
