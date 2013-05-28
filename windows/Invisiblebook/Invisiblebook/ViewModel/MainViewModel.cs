﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Invisiblebook.Business;
using Invisiblebook.Model;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
namespace Invisiblebook.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IChapterRepository _chapterRepository;

        private ObservableCollection<Book> _books;
        private ObservableCollection<Category> _categories;
        private ObservableCollection<Chapter> _chapters;

        private Category _selectedCategory;
        private Book _selectedBook;
        private Chapter _selectedChapter;

        public RelayCommand AddNoteCommand { get; private set; }
        public RelayCommand<Book> EditNoteCommand { get; private set; }
        public RelayCommand<Book> DeleteNoteCommand { get; private set; }
        public RelayCommand DeleteAllNotesCommand { get; private set; }
        public RelayCommand CategoryOptionsCommand { get; private set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IChapterRepository chapterRepository ,IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _chapterRepository = chapterRepository;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;

            Chapters = new ObservableCollection<Chapter>(_chapterRepository.FindAll());
            Books = new ObservableCollection<Book>(_bookRepository.FindAll());
            Categories = new ObservableCollection<Category>(_categoryRepository.FindAll());

            SelectedBook = new Book();
            SelectedCategory = new Category();
            SelectedChapter = new Chapter();
        }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>The notes.</value>
        public ObservableCollection<Chapter> Chapters
        {
            get
            {
                return _chapters;
            }
            set
            {
                RaisePropertyChanging("Chapters");
                _chapters = value;
                RaisePropertyChanged("Chapters");
            }
        }
        /// <summary>
        /// Gets or sets the selected category.
        /// </summary>
        /// <value>The selected category.</value>
        public Chapter SelectedChapter
        {
            get { return _selectedChapter; }
            set
            {
                RaisePropertyChanging("SelectedChapter");
                _selectedChapter = value;
                RaisePropertyChanged("SelectedChapter");
            }
        }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>The notes.</value>
        public ObservableCollection<Book> Books
        {
            get
            {
                return _books;
            }
            set
            {
                RaisePropertyChanging("Books");
                _books = value;
                RaisePropertyChanged("Books");
            }
        }
        /// <summary>
        /// Gets or sets the selected category.
        /// </summary>
        /// <value>The selected category.</value>
        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                RaisePropertyChanging("SelectedBook");
                _selectedBook = value;
                RaisePropertyChanged("SelectedBook");
            }
        }
        /// <summary>
        /// Gets or sets the selected category.
        /// </summary>
        /// <value>The selected category.</value>
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                RaisePropertyChanging("SelectedCategory");
                _selectedCategory = value;
                RaisePropertyChanged("SelectedCategory");
            }
        }
        

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>The categories.</value>
        public ObservableCollection<Category> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                RaisePropertyChanging("Categories");
                _categories = value;
                RaisePropertyChanged("Categories");
            }
        }
        public override void Cleanup()
        {

            base.Cleanup();
        }
    }
}