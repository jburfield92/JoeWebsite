///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: Category.cs
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

namespace JoeWebsite.Models
{
    /// <summary> A category for a blog post
    /// </summary>
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}