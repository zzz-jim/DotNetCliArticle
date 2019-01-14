﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeyWorld.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public string SayHey()
        {
            return "Hey, world!";
        }
    }

}