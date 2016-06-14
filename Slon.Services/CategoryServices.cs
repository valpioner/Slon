using AutoMapper;
using Slon.DataAccess;
using Slon.DTO;
using Slon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Slon.Services
{
    public class CategoryServices : IServices<CategoryDTO>
    {
        private readonly UnitOfWork _unitOfWork;

        public CategoryServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public CategoryDTO GetById(int id)
        {
            var category = _unitOfWork.Categories.GetByID(id);
            if (category != null)
            {
                Mapper.CreateMap<Category, CategoryDTO>();
                var categoryModel = Mapper.Map<Category, CategoryDTO>(category);
                return categoryModel;
            }
            return null;
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            var categories = _unitOfWork.Categories.GetAll().ToList();
            if (categories.Any())
            {
                Mapper.CreateMap<Category, CategoryDTO>();
                var categoriesModel = Mapper.Map<List<Category>, List<CategoryDTO>>(categories);
                return categoriesModel;
            }
            return null;
        }

        public int Create(CategoryDTO categoryDTO)
        {
            using (var scope = new TransactionScope())
            {
                var category = new Category
                {
                    Name = categoryDTO.Name
                };

                _unitOfWork.Categories.Create(category);
                _unitOfWork.Save();

                scope.Complete();

                return category.Id;
            }
        }

        public bool Update(int id, CategoryDTO categoryDTO)
        {
            var success = false;
            if (categoryDTO != null)
            {
                using (var scope = new TransactionScope())
                {
                    var category = _unitOfWork.Categories.GetByID(id);
                    if (category != null)
                    {
                        category.Name = categoryDTO.Name;

                        _unitOfWork.Categories.Update(category);
                        _unitOfWork.Save();

                        scope.Complete();

                        success = true;
                    }
                }
            }
            return success;
        }

        public bool Delete(int id)
        {
            var success = false;
            if (id > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var category = _unitOfWork.Categories.GetByID(id);
                    if (category != null)
                    {

                        _unitOfWork.Categories.Delete(category.Id);
                        _unitOfWork.Save();

                        scope.Complete();

                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
