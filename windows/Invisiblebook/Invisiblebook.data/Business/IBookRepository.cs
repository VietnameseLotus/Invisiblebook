using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Invisiblebook.data.Model;
namespace Invisiblebook.data.Business
{
    public interface IBookRepository
    {
        /// <summary>
        /// Saves the specified note.
        /// </summary>
        /// <param name="note">The note.</param>
        void Save(Book note);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="note">The note.</param>
        void Delete(Book note);

        /// <summary>
        /// Resets the repository.
        /// </summary>
        void RepositoryReset();

        /// <summary>
        /// Returns the entire repository.
        /// </summary>
        /// <returns>A List with all Notes</returns>
        IList<Book> FindAll();
    }
}
