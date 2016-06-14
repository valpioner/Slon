using Slon.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slon.Model
{
    //[Table("tblItems")]
    public class Item
    {
        //[Column("id")]
        //[Column(Order = 1)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        //[StringLength(50)]
        public string Description { get; set; }

        [Required]
        //[StringLength(50)]
        public string Img { get; set; }
        
        public decimal? Price { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public ItemDimensionEnum DimensionId { get; set; }

        public IList<ItemOrder> ItemOrder { get; set; }
        public IList<ItemSize> ItemSizes { get; set; }
        public IList<ItemType> ItemTypes { get; set; }

        //public IList<ItemDimensionEnum> ItemDimensions { get; set; }


    }
}