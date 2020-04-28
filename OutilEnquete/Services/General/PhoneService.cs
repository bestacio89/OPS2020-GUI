using OutilEnquete.Contracts.Services.General;
using Plugin.Messaging;

namespace OutilEnquete.Services.General
{
    public class PhoneService: IPhoneService
    {
        public void MakePhoneCall()
        {
            CrossMessaging.Current.PhoneDialer.MakePhoneCall("5554885002");
        }
    }
}
