﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcJqueryMobile.Models
{
    public class Chair
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
    }
}