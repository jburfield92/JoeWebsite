///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: SendCodeViewModel.cs
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

namespace JoeWebsite.ViewModels.AccountsViewModels
{
    /// <summary> Send Code View Model
    /// </summary>
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}