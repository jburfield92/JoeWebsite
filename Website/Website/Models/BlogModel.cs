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

namespace Website.Models
{
    /// <summary> Model for blog posts
    /// </summary>
    public class BlogModel
    {
        public class Blog
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime LastUpdate { get; set; }
            public Category PostCategory { get; set; }
            public List<Image> Images { get; set; }
        }
    }
}