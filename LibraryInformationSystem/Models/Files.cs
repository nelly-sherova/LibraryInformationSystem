namespace LibraryInformationSystem.Models
{
    public class Files
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Book Book { get; set; }
    }
}
