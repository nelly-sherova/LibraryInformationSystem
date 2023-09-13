namespace LibraryInformationSystem.Models
{
    public class Book
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
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
        public ICollection<Files> Files { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public string? Namination { get; set; }
        public int PageCount { get; set; }
        
    }
}
