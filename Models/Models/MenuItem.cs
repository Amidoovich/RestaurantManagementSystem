﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemID { get; set; }
        public int RestaurantID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? ImgUrl { get; set; }
        public bool Availability { get; set; } = true;
        [ValidateNever]
        public Restaurant? Restaurant { get; set; }
        [ValidateNever]
        public FoodCategory? Category { get; set; }
        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; }
    }

}
