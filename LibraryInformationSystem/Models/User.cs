namespace LibraryInformationSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegister { get; set; }
        public Char Type { get; set; }
        public Role Role { get; set; }
        public Direction? Direction { get; set; }
        public Faculty? Faculty { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }


    }
}
