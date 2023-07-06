﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaShop.Domain.DomainModels
{
    public class Product : BaseEntity
    {

        [Required]
        [Display(Name = "Име на филмот")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Постер")]
        public string ProductImage { get; set; }
        [Required]
        [Display(Name = "Цена на билет")]
        public int Price { get; set; }
        [Required]
        [Display(Name = "Рејтинг")]
        public int Rating { get; set; }
        [Required]
        [Display(Name = "Датум на емитување")]
        public DateTime data { get; set; }
        public virtual ICollection<ProductInShoppingCart> ProductInShoppingCarts { get; set; }
        public IEnumerable<ProductInOrder> ProductInOrders { get; set; }

    }
}