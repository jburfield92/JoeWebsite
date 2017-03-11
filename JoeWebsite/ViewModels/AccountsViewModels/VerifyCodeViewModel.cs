///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: VerifyCodeViewModel.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.ComponentModel.DataAnnotations;

namespace JoeWebsite.ViewModels.AccountsViewModels
{
    /// <summary> Verify Code View Model
    /// </summary>
    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
}