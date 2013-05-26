using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Invisiblebook.Helper
{
    public class WebRequester
    {
        string GET(string url) 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream()) {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex) {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
        }
    }
    // POST a JSON string
    void POST(string url, string jsonContent) 
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "POST";
        request.ContentLength = jsonContent.Length;
        request.ContentType = @"application/json";
        System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
        Byte[] byteArray = encoding.GetBytes(jsonContent);

        using (Stream dataStream = request.GetRequestStream()) {
            dataStream.Write(byteArray, 0, byteArray.Length);
        }
        long length = 0;
        try {
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                length = response.ContentLength;
            }
        }
        catch (WebException ex) {
            // Log exception and throw as for GET example above
        }
    }
}
