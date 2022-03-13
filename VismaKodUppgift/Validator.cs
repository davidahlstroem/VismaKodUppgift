using System.Text.RegularExpressions;

namespace VismaKodUppgift
{
    public class Validator
    {
        public bool validateLicenseNumber(string s)
        {
            Regex regex = new Regex("^[A-Z]{3}[0-9]{3}$");
            return regex.Match(s).Success;
        }
    }
}