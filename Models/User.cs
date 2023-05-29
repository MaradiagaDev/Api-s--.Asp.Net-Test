namespace ASP.Net_Test.Models
{
    public class User
    {
        public  int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string State { get; set; }
    }
}
