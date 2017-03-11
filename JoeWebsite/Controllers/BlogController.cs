///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: BlogController.cs
////
//// Date Created: 12/17/2016
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 12/17/2016     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;

namespace Website.Controllers
{
    /// <summary> The blog controller
    /// </summary>
    public class BlogController : Controller
    {
        /// <summary> Returns the view for the blog
        /// </summary>
        /// <returns></returns>
        public ActionResult Blog()
        {
            return View();
        }
    }
}