using Slon.Model;
using Slon.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slon.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public decimal? Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        //public ItemDimensionEnum DimensionId { get; set; }

        //public List<ItemOrder> ItemOrder { get; set; }
        //public List<ItemSize> ItemSizes { get; set; }
        //public List<ItemType> ItemTypes { get; set; }
    }
}
