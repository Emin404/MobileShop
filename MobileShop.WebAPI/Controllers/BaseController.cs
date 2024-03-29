﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
 
    
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel,TSearch> : ControllerBase
    {
        private readonly IService<TModel, TSearch> _service;
        public BaseController(IService<TModel,TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<TModel> Get([FromQuery]TSearch search)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return _service.GetById(id);
        }

    }
}