﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentiService _service;
        public KlijentiController(IKlijentiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Klijenti> Get([FromQuery]KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet]
        [Route("Authenticiraj/{username},{password}")]
        public Model.Models.Klijenti Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }


        [HttpPost]
        public void Insert(KlijentiInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody]KlijentiInsertRequest request)
        {
            _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Models.Klijenti GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}