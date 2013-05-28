using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invisiblebook.Model
{
    public class Book
    {
        #region private var
        private int _ID;
        private string _Name;
        private string _Author;
        private string _ReleaseYear;
        private string _Publisher;

        private Category _Category;

        private Media _AudioName; //Not be blank
        private Media _AudioDescription; //Can be blank

        private List<Chapter> _Chapters;
        #endregion

        #region Constructor
        public Book()
        {
            _ID = -1;
        }
        public Book(int id, string name, string author, string releaseYear, string publisher, Media audioName, Media audioDescription)
        {
            _ID = id;
            _Name = name;
            _Author = author;
            _ReleaseYear = releaseYear;
            _Publisher = publisher;
            _AudioName = audioName;
            _AudioDescription = audioDescription;
        }
        #endregion

        #region Properties

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string ReleaseYear
        {
            get { return _ReleaseYear; }
            set { _ReleaseYear = value; }
        }

        public Category Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        /// <summary>
        /// Audio của tên sách, không thể trống
        /// </summary>
        public Media AudioName
        {
            get { return _AudioName; }
            set { _AudioName = value; }
        }
        /// <summary>
        /// Audio của mô tả sách, Không thể trống
        /// </summary>
        public Media AudioDescription
        {
            get { return _AudioDescription; }
            set { _AudioDescription = value; }
        }
        /// <summary>
        /// Danh sách chapter, có thể trống nếu không có chapter nào
        /// </summary>
        public List<Chapter> Chapters
        {
            get { return _Chapters; }
            set { _Chapters = value; }
        }
        #endregion

        #region Operations
        /// <summary>
        /// Thêm một chapter mới vào danh sách chapter
        /// </summary>
        /// <param name="chapter">Chapter muốn thêm</param>
        /// <returns>True nếu thêm thành công</returns>
        public bool AddChapter(Chapter chapter)
        {
            int chapterCountBefore = _Chapters.Count;
            _Chapters.Add(chapter);
            return (_Chapters.Count > chapterCountBefore);
        }
        /// <summary>
        /// Loại bỏ một chapter ra khỏi danh sách chapter
        /// </summary>
        /// <param name="chapter">Chapter muốn loại bỏ</param>
        /// <returns>True nếu loại bỏ thành công</returns>
        public bool RemoveChapter(Chapter chapter)
        {
            int chapterCountBefore = _Chapters.Count;
            _Chapters.Remove(chapter);
            return (_Chapters.Count < chapterCountBefore);
        }
        /// <summary>
        /// Loại bỏ chapter ở vị trí possiton
        /// </summary>
        /// <param name="possiton">Vị trí muốn bỏ</param>
        /// <returns>True nếu loại bỏ thành công</returns>
        public bool RemoveChapterAt(int possiton)
        {
            int chapterCountBefore = _Chapters.Count;
            _Chapters.RemoveAt(possiton);
            return (_Chapters.Count < chapterCountBefore);
        }
        #endregion

    }
}
