using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slon.Model
{
    public class ItemType
    {
        public Item Item { get; set; }

        [Required]
        [Key, Column(Order = 1)]
        public int ItemId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public Enums.ItemTypeEnum ItemTypeId { get; set; }
    }
}