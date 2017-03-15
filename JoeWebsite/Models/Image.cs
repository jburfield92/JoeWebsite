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
//// 03/14/2016     Updated model to have foreignkey relationship
///////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoeWebsite.Models
{
    /// <summary> A single image for a blog post
    /// </summary>
    public class Image
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public byte[] Content { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        
        [Required]
        public bool IsCoverImage { get; set; }
        
        [ForeignKey("Blog")]
        public int BlogId { get; set; }

        [Required]
        public Blog Blog { get; set; }
    }
}