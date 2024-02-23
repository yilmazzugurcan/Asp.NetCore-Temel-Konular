using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController: Controller {


        public IActionResult Details(int id){

        var  kurs =Repository.GetById(id);
        return View(kurs);
    }

    // course/list
    public IActionResult List(){
       
        return View("CourseList",Repository.Courses);
    }



}