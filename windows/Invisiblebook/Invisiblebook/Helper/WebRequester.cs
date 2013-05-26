using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using RestSharp;
using Invisiblebook.Model;
namespace Invisiblebook.Helper
{
    /// <summary>
    /// Class hỗ trợ cho việc lấy thông tin từ server và tải các file
    /// </summary>
    public class WebRequester
    {
        private RestClient _Client;
        private string _BaseURL = "http://localhost/Invisiblebook";
        private WebRequester _instance = null;
        public WebRequester()
        {
            _Client = new RestClient(_BaseURL);
        }
        /// <summary>
        /// Dùng để lấy instance của đối tượng.
        /// </summary>
        /// <returns></returns>
        public WebRequester GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WebRequester();
            }
            return _instance;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Book> GetLatestPostList()
        {
            List<Book> result = new List<Book>();

            return result;
        }

    }
}
