using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Invisiblebook.data.Model
{
    public class Chapter
    {
        #region private var
        private int _ID;
        private string _Name;
        private Media _AudioName;
        private Media _AudioContent; //Can be blank
        #endregion

        #region Constructor
        public Chapter()
        {
            _ID = -1;
        }
        public Chapter(int id, string name, Media audioName, Media audioContent)
        {
            _ID = id;
            _Name = name;
            _AudioName = audioName;
            _AudioContent = audioContent;
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

        /// <summary>
        /// Audio của tên chapter, không thể trống
        /// </summary>
        public Media AudioName
        {
            get { return _AudioName; }
            set { _AudioName = value; }
        }
        /// <summary>
        /// Audio Nội dung của chapter
        /// </summary>
        public Media AudioContent
        {
            get { return _AudioContent; }
            set { _AudioContent = value; }
        }
        #endregion
    }
}
