using System;
using System.Data;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PivotGridPartial(
            string menuItemName,
            string fieldID,
            string fieldValueIndex)
        {
            if (menuItemName == "Filter")
            {
                ViewData["fieldID"] = fieldID;
                ViewData["fieldValueIndex"] = fieldValueIndex;
            }
            return PartialView("_PivotGridPartial", GetData(4));
        }
        DataTable GetData(int rowCount)
        {
            DataTable dt = new DataTable();
            Random _r = new Random();
            dt.Columns.Add("Row", typeof(int));
            dt.Columns.Add("Column", typeof(string));
            dt.Columns.Add("Data", typeof(int));
            for (int i = 0; i < rowCount; i++)
                dt.Rows.Add(i, "Column"+i, _r.Next(10));
            return dt;
        }
    }
}
