///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: SmsService.cs
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
    /// <summary> manages sms system
    /// </summary>
    public class SmsService : IIdentityMessageService
    {
        /// <summary> Sends a sms async
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}