﻿using ExceedConsultancy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;

namespace ExceedConsultancy.Controllers
{
    public class OrganizationStrategyController : Controller

    {
        private readonly IConfiguration _config;

        public OrganizationStrategyController(IConfiguration config)
        {
            _config = config;
        }


        public IActionResult Index()
        {
            return View();
        }

    
        }


    }
