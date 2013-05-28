using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Invisiblebook.data.Model;
namespace Invisiblebook.data.Business
{
    public class BookRepository : IBookRepository
    {
        private IList<Book> _bookStore;
        private readonly string _dataFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteRepository"/> class.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        public BookRepository(string fileName)
        {
            fileName = string.Concat(fileName + ".an");
            _dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            Deserialize();
        }

        /// <summary>
        /// Saves the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void Save(Book book)
        {
            if (!_bookStore.Contains(book))
                _bookStore.Add(book);

            Serialize();
        }

        /// <summary>
        /// Deletes the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void Delete(Book book)
        {
            _bookStore.Remove(book);

            Serialize();
        }

        /// <summary>
        /// Resets the repository.
        /// </summary>
        public void RepositoryReset()
        {
            File.Delete(_dataFile);
            _bookStore = new List<Book>();
        }

        /// <summary>
        /// Returns the entire repository.
        /// </summary>
        /// <returns>A List with all Notes</returns>
        public IList<Book> FindAll()
        {
            return _bookStore;
        }

        /// <summary>
        /// Serializes all the books to a file.
        /// </summary>
        private void Serialize()
        {
            using (var stream = File.Open(_dataFile, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, _bookStore);
            }
        }

        /// <summary>
        /// Deserializes all books or creates an empty List.
        /// </summary>
        private void Deserialize()
        {
            if (File.Exists(_dataFile))
                using (var stream = File.Open(_dataFile, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    _bookStore = (IList<Book>)formatter.Deserialize(stream);
                }
            else
                _bookStore = new List<Book>();
        }
    }
}
