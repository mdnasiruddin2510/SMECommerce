﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Models.CategoryModels
{
    public class CategoryCreate
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public string Reference { get; set; }

    }
}
