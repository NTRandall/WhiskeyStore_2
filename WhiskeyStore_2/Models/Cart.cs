﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WhiskeyStore_2.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        
        public string CartId { get; set; }

        public int ProductId { get; set; }
        public int Count { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateCreated { get; set; }

        public virtual Products Product { get; set; }


    }
}