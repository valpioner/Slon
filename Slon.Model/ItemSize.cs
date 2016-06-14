using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slon.Model
{
    public class ItemSize
    {
        public Item Item { get; set; }

        [Required]
        [Key, Column(Order = 1)]
        public int ItemId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public Enums.ItemSizeEnum ItemSizeId { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}