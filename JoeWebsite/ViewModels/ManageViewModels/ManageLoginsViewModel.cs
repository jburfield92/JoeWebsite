///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: ManageLoginsViewModel.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Collections.Generic;

namespace JoeWebsite.ViewModels.ManageViewModels
{
    /// <summary> Manage Logins View Model
    /// </summary>
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }
}