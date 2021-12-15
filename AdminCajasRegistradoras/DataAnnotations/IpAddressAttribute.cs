using System.Net;
using System.ComponentModel.DataAnnotations;

namespace AdminCajasRegistradoras.DataAnnotations
{
    public class IpAddressAttribute : ValidationAttribute
    {
        
        public override bool IsValid(object? value)
        {
            var ipAddress = value as string;
            return IPAddress.TryParse(ipAddress, out _);
        }

    }
}
