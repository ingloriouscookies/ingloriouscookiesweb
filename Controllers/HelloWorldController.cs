﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IngloriousCookiesWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {

        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        public string Get()
        {
            return "Hello World!";
        }

    }
}
