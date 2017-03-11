///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: EmailService.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace JoeWebsite
{
    /// <summary> Manages the email system
    /// </summary>
    public class EmailService : IIdentityMessageService
    {
        /// <summary> Sends a email async
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }
}