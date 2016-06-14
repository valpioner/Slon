using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slon.Model
{
    public class ItemOrder
    {
        public Item Item { get; set; }
        public Order Order { get; set; }

        [Required]
        [Key, Column(Order = 1)]
        public int ItemId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int OrderId { get; set; }

        [Required]
        public Enums.ItemSizeEnum SizeId { get; set; }
        [Required]
        public Enums.ItemTypeEnum TypeId { get; set; }

        [Required]
        public decimal Count { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}