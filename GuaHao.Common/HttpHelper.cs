using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GuaHao.Common
{
    public class HttpHelper
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public static string POST(string url, string data,ref IRequestCookieCollection cookies)
        {
            string result = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            var cookieContainer = new CookieContainer();
            
            request.CookieContainer = cookieContainer;


            request.Headers.Add("Referer", string.Format("http://www.bjguahao.gov.cn/order/confirm/142-200039602-201156818-61162384.htm", "", "", "", ""));

            if (!string.IsNullOrEmpty(data))
            {
                var postArray = Encoding.UTF8.GetBytes(data);

                var reqStream = request.GetRequestStream();

                reqStream.Write(postArray, 0, postArray.Length);
                reqStream.Close();
            }


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (string.IsNullOrEmpty(cookies["UINFO"]))
            {
                var getCookies = cookieContainer.GetCookies(request.RequestUri);
                Dictionary<string, string> dicCookies = new Dictionary<string, string>();
                foreach (Cookie cookie in getCookies)
                {
                    dicCookies.Add(cookie.Name, cookie.Value);
                }

                cookies = new RequestCookieCollection(dicCookies);
            }

            var resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);

            result = reader.ReadToEnd();
            resStream.Close();
            reader.Close();

            return result;
        }
        /// <summary>
        /// 非登录
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="cookies"></param>
        /// <returns></returns>
        public static string POST(string url, string data,IRequestCookieCollection cookies=null)
        {
            string result = string.Empty;
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            var cookieContainer = new CookieContainer();

            if (cookies!=null)
            {
                if (cookies.Count>0)
                {
                    var cookieCollection = new CookieCollection();
                    foreach (var cookie in cookies)
                    {
                        var ck = new Cookie(cookie.Key, cookie.Value);
                        ck.Domain = request.Host.ToString();
                        cookieCollection.Add(ck);
                    }
                    cookieContainer.Add(cookieCollection);
                }
            }
            
            request.CookieContainer = cookieContainer;
            

          //  request.Headers.Add("Referer", string.Format("http://www.bjguahao.gov.cn/order/confirm/142-200039602-201156818-61162384.htm", "","","",""));

            if (!string.IsNullOrEmpty(data))
            {
                var postArray = Encoding.UTF8.GetBytes(data);

                var reqStream = request.GetRequestStream();

                reqStream.Write(postArray, 0, postArray.Length);
                reqStream.Close();
            }
          

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
           
            var resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);

            result= reader.ReadToEnd();
            resStream.Close();
            reader.Close();

            return result;
        }

        public static string GET(string url)
        {
            string result = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var resStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);

            result = reader.ReadToEnd();
            resStream.Close();
            reader.Close();
            return result;
        }
    }
}
