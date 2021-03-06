﻿///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: Blog.cs
////
//// Date Created: 12/17/2016
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 12/17/2016     Initial
//// 03/14/2016     Updated model to have foreignkey relationship
///////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Blog Content")]
        public string Content { get; set; }
    }
}