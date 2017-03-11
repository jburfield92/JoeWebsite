///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: FilterConfig.cs
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

namespace JoeWebsite
{
    /// <summary> Filter config
    /// </summary>
    public class FilterConfig
    {
        /// <summary> Register global filters
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
