﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookStore.Models.Classes
{
    public class Order
    {
        [BindNever] 
        public int OrderId { get; set; }

        [BindNever] 
        public ICollection<CartLine> Lines { get; set; }
        
        [Required(ErrorMessage = "Please, enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please, enter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please, enter a country name")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }

        [BindNever] 
        public OrderStatus Status { get; set; } = OrderStatus.InProcess;
    }

    public enum OrderStatus
    {
        InProcess,
        Rejected,
        Adopted,
        Delivered,
        ReturnRequest
    }
}