///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: BlogModel.cs
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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JoeWebsite.Models
{
    /// <summary> Model for blog posts
    /// </summary>
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Blog Title")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public Category PostCategory { get; set; }

        public List<Image> Images { get; set; }

        [Required]
        [Display(Name = "Blog Content")]
        public string Content { get; set; }
    }
}