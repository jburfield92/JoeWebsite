///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: ConfigureTwoFactorViewModel.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Web.Mvc;

namespace JoeWebsite.Models.ManageViewModels
{
    /// <summary> Configure Two Factor View Model
    /// </summary>
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}