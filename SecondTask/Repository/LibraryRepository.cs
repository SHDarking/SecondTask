using SecondTask.Interfaces;

namespace SecondTask.Repository
{
    public class LibraryRepository : IRepository
    {
        private readonly LibraryContext _libraryContext;
        public LibraryRepository(LibraryContext context)
        {
            _libraryContext = context;
        }
    }
}
