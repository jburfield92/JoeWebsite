///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: ApplicationDbContext.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace JoeWebsite.Models
{
    /// <summary> Application DbContext object
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Blog> Blogs { get; set; }

        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}