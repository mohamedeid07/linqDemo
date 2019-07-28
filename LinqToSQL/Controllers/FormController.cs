using LinqToSQL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LinqToSQL.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            QvApp_RawdaDeductionEntities3 context = new QvApp_RawdaDeductionEntities3();

            var EndDays = 30;

            var data = from form in context.DUC_Form
                       where SqlFunctions.DateDiff("day", SqlFunctions.GetDate(), form.EndDate) < EndDays 
                       && SqlFunctions.DateDiff("day", SqlFunctions.GetDate(), form.EndDate) > 0
                       select form.EndDate;

            ViewBag.forms = data;
            return View();
        }
    }

   
}