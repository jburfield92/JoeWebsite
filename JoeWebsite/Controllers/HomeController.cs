///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: HomeController.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;

namespace JoeWebsite.Controllers
{
    /// <summary> Home page controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary> Default load
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary> Load projects page
        /// </summary>
        /// <returns></returns>
        public ActionResult Projects()
        {
            return View();
        }

        /// <summary> Load resume page
        /// </summary>
        /// <returns></returns>
        public ActionResult Resume()
        {
            return View();
        }
    }
}