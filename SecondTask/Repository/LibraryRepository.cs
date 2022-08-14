using Microsoft.EntityFrameworkCore;
using SecondTask.Interfaces;
using SecondTask.Models;

namespace SecondTask.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly LibraryContext _libraryContext;
        public LibraryRepository(LibraryContext context)
        {
            _libraryContext = context;
        }

        public async Task<int> AddBook(Book book)
        {
            await _libraryContext.Books.AddAsync(book);
            await _libraryContext.SaveChangesAsync();
            return book.Id;
        }

        public async Task<int> UpdateBook(Book book)
        {
            _libraryContext.Books.Update(book);
            await _libraryContext.SaveChangesAsync();
            return book.Id;
        }

        public async Task<int> AddRating(Rating rating)
        {
            await _libraryContext.Ratings.AddAsync(rating);
            await _libraryContext.SaveChangesAsync();
            return rating.Id;
        }
        

        public async Task<int> AddReview(Review review)
        {
            await _libraryContext.Reviews.AddAsync(review);
            await _libraryContext.SaveChangesAsync();
            return review.Id;
        }

        public async Task DeleteBook(int id)
        {
            _libraryContext.Books.Remove(new Book { Id = id });
            await _libraryContext.SaveChangesAsync();
        }

        public List<Book> GetAllBooks(string order) => _libraryContext.Books.Where(elem => elem.Author == order).ToList();

        public Book? GetBookWithReviews(int id) => _libraryContext.Books.Include(elem => elem.Reviews).Where(elem => elem.Id == id).FirstOrDefault();

        public List<Book> GetTopBooks(string genre) => _libraryContext.Books
            .Include(elem => elem.Ratings)
            .Include(elem => elem.Reviews)
            .Where(elem => elem.Genre == genre && elem.Reviews.Count > 10)
            .OrderByDescending(elem => elem.Ratings.Sum(rate => rate.Score))
            .Take(10)
            .ToList();
        
    }
}
