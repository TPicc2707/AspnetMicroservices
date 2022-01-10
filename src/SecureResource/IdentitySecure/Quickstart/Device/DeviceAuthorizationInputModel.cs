using IdentitySecure.Quickstart.Consent;

namespace IdentitySecure.Quickstart.Device
{
    public class DeviceAuthorizationInputModel : ConsentInputModel
    {
        public string UserCode { get; set; }
    }
}