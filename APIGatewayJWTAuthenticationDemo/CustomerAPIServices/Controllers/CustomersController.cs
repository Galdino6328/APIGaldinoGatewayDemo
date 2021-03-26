﻿namespace CustomersAPIServices.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "API Galdino", "Thalyson Galdino" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"API Galdino - {id}";
        }
    }
}
