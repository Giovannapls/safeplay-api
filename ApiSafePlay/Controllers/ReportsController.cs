using ApiSafePlay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiSafePlay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly ILogger<ReportsController> _logger;

        public ReportsController(ILogger<ReportsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Report> Get()
        {
            // Replace with your data fetching logic
            return new List<Report>();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Replace with your data fetching logic
            var report = new Report { Id = id, Description = "Sample Report" };
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }

        [HttpPost]
        public IActionResult Create(Report report)
        {
            // Replace with your data saving logic
            report.Id = new Random().Next(1, 1000); // Example ID generation
            return CreatedAtAction(nameof(GetById), new { id = report.Id }, report);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Report report)
        {
            if (id != report.Id)
            {
                return BadRequest();
            }
            // Replace with your data updating logic
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Replace with your data deletion logic
            return NoContent();
        }
    }
}
