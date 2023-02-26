using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodb_desktop_client.utils
{
    /// <summary>
    /// Класс, предоставляющий методы валидации данных
    /// </summary>
    public class ValidateUtil
    {
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
