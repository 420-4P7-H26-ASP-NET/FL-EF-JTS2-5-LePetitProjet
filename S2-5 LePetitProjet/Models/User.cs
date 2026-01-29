namespace S2_5_LePetitProjet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } //regex
        public string Password { get; set; } //regex
        public string Role { get; set; }
    }
}
