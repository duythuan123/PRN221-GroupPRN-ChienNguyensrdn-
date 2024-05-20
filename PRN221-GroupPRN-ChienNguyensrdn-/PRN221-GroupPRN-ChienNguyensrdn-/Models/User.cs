using System.ComponentModel.DataAnnotations;

namespace PRN221_GroupPRN_ChienNguyensrdn_.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Guest,
        Buyer,
        Seller,
        Administrator
    }
}
