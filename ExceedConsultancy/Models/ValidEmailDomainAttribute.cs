using System.ComponentModel.DataAnnotations;

namespace ExceedConsultancy.Models
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        public readonly string AllowedDomain;
        public ValidEmailDomainAttribute(string allowedDomains)
        {
            AllowedDomain = allowedDomains.Trim();
        }
        public override bool IsValid(object value)
        {
            if (value == null) { return false; }
            string val = value.ToString();
            if (string.IsNullOrEmpty(val))
            {
                return false;
            }
            if (val.ToLower().EndsWith(AllowedDomain))
            {
                return true;
            }
            return false;
        }
    }
}
