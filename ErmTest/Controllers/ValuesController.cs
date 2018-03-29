using ErmTest.DbContexts;
using ErmTest.Models;
using ErmTest.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ErmTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ErmTestDbContext context;

        public ValuesController(ErmTestDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var people = context.People.ToList();
            return Ok(people);
        }

        [HttpPost]
        public IActionResult Post()
        {
            //var semester = new Semester
            //{
            //    AcademicYear = new AcademicYear
            //    {
            //        StartDate = new DateTime(2017, 9, 4),
            //        EndDate = new DateTime(2018, 7, 6),
            //    },
            //    StartDate = new DateTime(2017, 9, 4),
            //    EndDate = new DateTime(2018, 2, 2),
            //    Name = "First Semester"
            //};

            //context.AddRange(semester);
            //context.SaveChanges();

            return Ok();
        }
    }
}