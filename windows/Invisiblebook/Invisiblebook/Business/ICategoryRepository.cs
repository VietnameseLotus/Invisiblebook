﻿using System;
using System.Collections.Generic;
using Invisiblebook.Model;

namespace Invisiblebook.Business
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Looking a category by ID
        /// </summary>
        /// <param name="id">The category id.</param>
        /// <returns>A category or null</returns>
        Category GetById(int id);

        /// <summary>
        /// Returns the entire repository.
        /// </summary>
        /// <returns>A List with all categories</returns>
        IList<Category> FindAll();

        /// <summary>
        /// Replace the old cotegories list with a new one.
        /// </summary>
        /// <param name="categories">The categories.</param>
        void SaveAll(IList<Category> categories);

        /// <summary>
        /// Resets the repository.
        /// </summary>
        void RepositoryReset();
    }
}
