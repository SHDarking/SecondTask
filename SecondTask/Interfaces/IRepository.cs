using SecondTask.Models;

namespace SecondTask.Interfaces
{
    public interface ILibraryRepository
    {
        public List<Book> GetAllBooks(string order);
        public List<Book> GetTopBooks(string genre);
        public Book? GetBookWithReviews(int id);
        public Task DeleteBook(int id);
        public Task<int> AddBook(Book book);
        public Task<int> UpdateBook(Book book);
        public Task<int> AddReview(Review review);
        public Task<int> AddRating(Rating rating);



    }
}
