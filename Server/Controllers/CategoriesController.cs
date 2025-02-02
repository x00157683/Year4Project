﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController: ControllerBase        //localhost:5001/api/controller
    {
        private readonly AppDBContext _appDBContext;

        public CategoriesController(AppDBContext appDBContext)
        {

            _appDBContext = appDBContext;

   
        }
        //                 http//website.com/api/categories/get url

        [HttpGet]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task <IActionResult> Get()
        {

            List<Category> categories = await _appDBContext.Categories.ToListAsync();


            return Ok(categories);
        }
                                                                    

    }
}
