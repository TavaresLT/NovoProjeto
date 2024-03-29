﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            _salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CarregarTabela(DateTime? minDate, DateTime? maxDate) 
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            return PartialView("_Tabela", result);
        }

        public async Task<IActionResult> SimpleSearch()
        {
            return View();
        }
        public async Task<IActionResult> GroupingSearch()
        {
            return View();
        }
    }
}
