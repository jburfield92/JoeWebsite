///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: ForgotViewModel.cs
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
    /// <summary> Forgot View Model
    /// </summary>
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}