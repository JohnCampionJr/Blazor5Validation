﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor5Validation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor5Validation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult Index(Person model)
        {
            //if (model.EmailAddress.Contains("nonymous.com"))
            //{
            //    ModelState.AddModelError(nameof(model.EmailAddress), "We do not allow emails from this domain.");
            //    return BadRequest(ModelState);
            //}

            return Ok(new PersonResult { IsSuccessful = true, Message = "Looks good to the server." });

        }
    }


}
