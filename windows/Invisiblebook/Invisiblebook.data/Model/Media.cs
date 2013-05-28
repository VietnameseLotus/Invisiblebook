using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invisiblebook.data.Model
{
    public class Media
    {
        #region Private var
        private int _ID;
        private string _FileURL;
        /// <summary>
        /// Người đọc
        /// </summary>
        private string _Announcer;
        private DateTime _ModifyDate;
        #endregion

        #region constructor

        public Media()
        {
            _ID = -1;
        }
        public Media(int id, string fileURL, string announcer, DateTime modifyDate)
        {
            _ID = id;
            _FileURL = fileURL;
            _Announcer = announcer;
            _ModifyDate = modifyDate;
        }
        #endregion

        #region public propties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FileURL
        {
            get { return _FileURL; }
            set { _FileURL = value; }
        }
        public string Announcer
        {
            get { return _Announcer; }
            set { _Announcer = value; }
        }
        public DateTime ModifyDate
        {
            get { return _ModifyDate; }
            set { _ModifyDate = value; }
        }
        #endregion
    }
}
