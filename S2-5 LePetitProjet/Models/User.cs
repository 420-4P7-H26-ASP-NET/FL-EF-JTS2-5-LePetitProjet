using System.Text.RegularExpressions;

namespace S2_5_LePetitProjet.Models
{
    public class User
    {
        private string _email;
        private string _password;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email
        {
            get { return _email; }
            set
            {
                string pattern = @".+@.+\..+";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(value))
                {
                    _email = value;
                }
            }
        }
        public string Password { get; set; } //regex
        public string Role { get; set; }
    }
}
