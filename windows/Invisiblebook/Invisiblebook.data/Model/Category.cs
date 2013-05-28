using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invisiblebook.data.Model
{
    public class Category
    {
        private int _ID;
        private string _Name;
        private Media _AudioName;

        public Category()
        {
            _ID = -1;
        }

        public Category(int id, string name, Media audioName)
        {
            _ID = id;
            _Name = name;
            _AudioName = audioName;
        }
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
        public Media AudioName
        {
            get { return _AudioName; }
            set { _AudioName = value; }
        }
    }
}
