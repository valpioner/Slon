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
    public class ItemServices : IServices<ItemDTO>
    {
        private readonly UnitOfWork _unitOfWork;

        public ItemServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public ItemDTO GetById(int id)
        {
            var item = _unitOfWork.Items.GetByID(id);
            if (item != null)
            {
                Mapper.CreateMap<Item, ItemDTO>();
                var itemDTO = Mapper.Map<Item, ItemDTO>(item);
                return itemDTO;
            }
            return null;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            var items = _unitOfWork.Items.GetAll().ToList();
            if (items.Any())
            {
                Mapper.CreateMap<Item, ItemDTO>();
                var itemsDTO = Mapper.Map<List<Item>, List<ItemDTO>>(items);
                return itemsDTO;
            }
            return null;
        }

        public int Create(ItemDTO itemDTO)
        {
            using (var scope = new TransactionScope())
            {
                var item = new Item
                {
                    Name = itemDTO.Name
                };

                _unitOfWork.Items.Create(item);
                _unitOfWork.Save();

                scope.Complete();

                return item.Id;
            }
        }

        public bool Update(int id, ItemDTO itemDTO)
        {
            var success = false;
            if (itemDTO != null)
            {
                using (var scope = new TransactionScope())
                {
                    var item = _unitOfWork.Items.GetByID(id);
                    if (item != null)
                    {
                        item.Name = itemDTO.Name;

                        _unitOfWork.Items.Update(item);
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
                    var item = _unitOfWork.Items.GetByID(id);
                    if (item != null)
                    {

                        _unitOfWork.Items.Delete(item.Id);
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
