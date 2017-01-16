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

namespace Website
{
    /// <summary> A single image for a blog post
    /// </summary>
    public class Image
    {
        public byte[] Content { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsCoverImage { get; set; }
        public int idBlog { get; set; }
    }
}