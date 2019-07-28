using LinqToSQL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinqToSQL.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchByDays() {
            return View();
        }

        [HttpPost]
        public ActionResult SearchByDays(DaysModel model) 
        {
            QvApp_RawdaDeductionEntities3 context = new QvApp_RawdaDeductionEntities3();

            var EndDays = model.numOfDaysToEnd;

            var data = from form in context.DUC_Form
                       where SqlFunctions.DateDiff("day", SqlFunctions.GetDate(), form.EndDate) < EndDays
                       && SqlFunctions.DateDiff("day", SqlFunctions.GetDate(), form.EndDate) > 0
                       select form;

            ViewBag.forms = data;
            return View("SearchByDaysResult");
        }

        public ActionResult PopularProjects(DaysModel model)
        {
            QvApp_RawdaDeductionEntities3 context = new QvApp_RawdaDeductionEntities3();

            /*select ProjectID , count(*) as NumberOfForms, DUC_Project.Name
	from DUC_FormPackageProject inner join DUC_Project on DUC_Project.ID = DUC_FormPackageProject.ProjectID
	group by ProjectID, DUC_Project.Name*/

            var data1 = from project in context.DUC_Project
                       join form in context.DUC_Form
                       on project.ID equals form.ProjectID
                       group project by new { project.ID, project.Name } into groupedProjects
                       select new ProjectModel
                       {
                           ID = groupedProjects.Key.ID,
                           Name = groupedProjects.Key.Name,
                           NumberOfForms = groupedProjects.Count()
                       };

            var data2 = from project in context.DUC_Project
                        join formProject in context.DUC_FormPackageProject
                        on project.ID equals formProject.ProjectID
                        group project by new { project.ID, project.Name } into groupedProjects
                        select new ProjectModel
                        {
                            ID = groupedProjects.Key.ID,
                            Name = groupedProjects.Key.Name,
                            NumberOfForms = groupedProjects.Count()
                        };

            var combinedData = data1.Union(data2)
                .GroupBy(s => new { s.ID, s.Name })
                .Select(s => new ProjectModel {
                    ID = s.Key.ID,
                    Name = s.Key.Name,
                    NumberOfForms = s.Sum(sa => sa.NumberOfForms)
                });

            var orderedcombinedData = combinedData.OrderByDescending(s => s.NumberOfForms);

            ViewBag.forms = orderedcombinedData;
            return View();
        }
    }
}