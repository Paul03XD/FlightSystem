using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Firmy")]
    public class Firma : IDataErrorInfo
    {
        public int? id { get; set; }
        [Column("nazwa")]
        public string nazwa { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string placowka { get; set; }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public string this[string pole]
        {
            get
            {
                Regex regLogin = new Regex(@"^([\w0-9]){5,20}$");
                Regex regPassword = new Regex(@"^[\w_.-]{5,20}$");
                switch (pole)
                {
                    case "nazwa":
                        if (String.IsNullOrEmpty(nazwa))
                            return "Wprowadź nazwę firmy.";
                        break;
                    case "login":
                        if (String.IsNullOrEmpty(login))
                            return "Wprowadź login firmy.";
                        else if (!regLogin.IsMatch(login))
                            return "Login musi mieć 5-20 znaków. Dozwolone znaki specjalne: _";
                        break;
                    case "password":
                        if (String.IsNullOrEmpty(password))
                            return "Wprowadź hasło.";
                        else if (!regPassword.IsMatch(password))
                            return "Hasło musi mieć 5-20 znaków.";
                        break;
                    case "placowka":
                        if (String.IsNullOrEmpty(placowka))
                            return "Wprowadź adres placówki.";
                        break;
                }
                return "";
            }
        }
    }
}
