﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Model.Requests
{
    public class ModeliInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
