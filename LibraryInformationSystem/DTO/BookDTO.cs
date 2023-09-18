using LibraryInformationSystem.Models;

namespace LibraryInformationSystem.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Publicshing { get; set; }
        public DateTime? DateOfPublished { get; set; }
        public string? PublishCity { get; set; }
        public DateTime DateOfCreated { get; set; }
        public DateTime DateOfModified { get; set; }
        public string Language { get; set; }
        public double? Price { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public ICollection<Fl> Fls { get; set; }
       
        public string? Namination { get; set; }
        public int PageCount { get; set; }
    }
}
