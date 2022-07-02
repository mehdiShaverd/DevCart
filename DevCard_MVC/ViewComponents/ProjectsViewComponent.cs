using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>
            {
                new Project(id:1, name:"تاکسی", description:"درخواست آنلاین تاکسی برای سفر های درون شهری", image:"project-1.jpg", client:"Atriya"),
                new Project(id:2, name:"زودفود", description:"درخواست آنلاین غذا برای سراسر کشور", image:"project-2.jpg", client:"ZoodFood"),
                new Project(id:3, name:"مدارس", description:"سیستم مدیریت یکپارچه مدارس", image:"project-3.jpg", client:"MONOP"),
                new Project(id:4, name:"فضاپیما", description:"برنامه مدیریت فضاپیما های ناسا", image:"project-4.jpg", client:"NASA"),
            };
            return View("_Projects", projects);
        }
    }
}
