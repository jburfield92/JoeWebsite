///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: Image.cs
////
//// Date Created: 12/17/2016
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 12/17/2016     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel.DataAnnotations;

namespace JoeWebsite.Models
{
    /// <summary> A single image for a blog post
    /// </summary>
    public class Image
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public byte[] Content { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        
        [Required]
        public bool IsCoverImage { get; set; }

        public int idBlog { get; set; }
    }
}