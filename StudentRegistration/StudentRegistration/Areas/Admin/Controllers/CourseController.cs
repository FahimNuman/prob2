using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentRegistration.Areas.Admin.Models;

namespace StudentRegistration.Areas.Admin.Controllers
{

    //[Area("Admin")]
    //public class CoursesController : Controller
    //{
    //    private readonly IConfiguration _configuration;
    //    public CoursesController(IConfiguration configuration)
    //    {
    //        _configuration = configuration;
    //    }

    //    public IActionResult Index()
    //    {
    //        var model = Startup.AutofacContainer.Resolve<CourseModel>();
    //        return View(model);
    //    }

    //    public IActionResult AddCourse()
    //    {
    //        var model = new CreateCourseModel();
    //        return View(model);
    //    }

    //    [HttpPost]
    //    public IActionResult AddCourse(CreateCourseModel model)
    //    {
    //        model.Create();
    //        return View(model);
    //    }

    //    public IActionResult GetCourses()
    //    {
    //        var tableModel = new DataTablesAjaxRequestModel(Request);
    //        var model = Startup.AutofacContainer.Resolve<CourseModel>();
    //        var data = model.GetCourses(tableModel);
    //        return Json(data);
    //    }
    }
