using Slon.DTO;
using Slon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Slon.API.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly IServices<CategoryDTO> _categoryService;

        public CategoriesController()
        {
            _categoryService = new CategoryServices();
        }

        // GET: api/Categories
        public HttpResponseMessage Get()
        {
            var categories = _categoryService.GetAll();
            if (categories != null)
            {
                var categoriesDTO = categories as List<CategoryDTO> ?? categories.ToList();
                if (categoriesDTO.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, categoriesDTO);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Category not found");
        }

        // GET: api/Categories/5
        public HttpResponseMessage Get(int id)
        {
            var category = _categoryService.GetById(id);
            if (category != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, category);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No category found for this id");
        }

        // POST: api/Categories
        public int Post([FromBody]CategoryDTO categoryDTO)
        {
            return _categoryService.Create(categoryDTO);
        }

        // PUT: api/Categories/5
        public bool Put(int id, [FromBody]CategoryDTO categoryDTO)
        {
            if (id > 0)
            {
                return _categoryService.Update(id, categoryDTO);
            }
            return false;
        }

        // DELETE: api/Categories/5
        public bool Delete(int id)
        {
            if (id > 0)
            {
                return _categoryService.Delete(id);
            }
            return false;
        }
    }
}
