using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Slon.Model
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public Enums.OrderStatus StatusId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public User Customer { get; set; }
        
        public int? CourierId { get; set; }
        [ForeignKey("CourierId")]
        public User Courier { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime DateStatusChanged { get; set; }
        public DateTime? DateClosed { get; set; }

        public string Notes { get; set; }

        [Required]
        public decimal InitialPrice { get; set; }
        [Required]
        public decimal ExtraPrice { get; set; }
        [Required]
        public decimal DeliveryPrice { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public Enums.PaymentSelection? PaymentSelectionId { get; set; }

        [Required]
        public bool IsPayed { get; set; }

        [Required]
        public bool IsClosed { get; set; }

        public IList<ItemOrder> ItemOrder { get; set; }
    }
}