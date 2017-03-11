///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: ForgotPasswordViewModel.cs
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
    /// <summary> Forget password view model
    /// </summary>
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
