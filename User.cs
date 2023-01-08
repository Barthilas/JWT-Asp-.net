namespace JwtWebApi
{
    /// <summary>
    /// Real life store in DB.
    /// </summary>
    public class User
    {
        public string Username { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
