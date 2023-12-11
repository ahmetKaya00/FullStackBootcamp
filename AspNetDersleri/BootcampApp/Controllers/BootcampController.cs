using BootcampApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootcampApp.Controllers;

public class BootcampController: Controller{

    public IActionResult Details(int? id){
        if(id==null){
            return Redirect("/Bootcamp/List");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
    }
    public IActionResult List(){      
        return View(Repository.Bootcamps);
    }


}
