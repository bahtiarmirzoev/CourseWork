namespace ServiceDataLayer.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();  
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public ICollection<UserCars> UserCars { get; set; } = new List<UserCars>();

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
