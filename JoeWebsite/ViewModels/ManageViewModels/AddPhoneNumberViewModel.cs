///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: AddPhoneNumberViewModel.cs
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

namespace JoeWebsite.ViewModels.ManageViewModels
{
    /// <summary> Add Phone Number View Model
    /// </summary>
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}