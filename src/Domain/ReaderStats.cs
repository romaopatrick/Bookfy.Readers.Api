namespace Bookfy.Readers.Api.Domain
{
    public class ReaderStats
    {
        public required long PagesRead { get; set; }
        public required long BooksRead { get; set; }
    }
}