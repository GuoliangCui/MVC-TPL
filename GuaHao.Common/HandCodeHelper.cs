using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GuaHao.Common
{
    public class HandCodeHelper
    {
        public bool Login(string uname,string upwd,ref IRequestCookieCollection cookieCollection)
        {
            string loginUrl = "http://www.bjguahao.gov.cn/quicklogin.htm";

            var name = Convert.ToBase64String(Encoding.UTF8.GetBytes(uname));
            var pwd = Convert.ToBase64String(Encoding.UTF8.GetBytes(upwd));

            string postData = string.Format("mobileNo={0}&password={1}&yzm=&isAjax=true",name,pwd);

            var result = HttpHelper.POST(loginUrl, postData,ref cookieCollection);
            
            return JsonConvert.DeserializeAnonymousType(result, new { code = "" }).code == "200";
        }

        public bool Login2(string uname, string upwd, RequestCookieCollection cookieCollection)
        {
            string loginUrl = "http://www.bjguahao.gov.cn/quicklogin.htm";
            Dictionary<string, string> cc = new Dictionary<string, string>();
            cc.Add("1","1");
            cc.Add("2", "2");
            cookieCollection = new RequestCookieCollection(cc);
            return true;
        }

        public string SendCheckCode(IRequestCookieCollection cookieCollection)
        {
            string url = "http://www.bjguahao.gov.cn/v/sendorder.htm";
            var result = HttpHelper.POST(url,"", cookieCollection);
            return result;
        }

        /// <summary>
        /// 获取医生列表
        /// </summary>
        /// <param name="hospitalId"></param>
        /// <param name="departmentId"></param>
        /// <param name="dutyCode"></param>
        /// <param name="dutyDate"></param>
        /// <returns></returns>
        public string GetDocList(string hospitalId, string departmentId,string dutyCode, string dutyDate, IRequestCookieCollection cookieCollection)
        {
            string docListUrl = "http://www.bjguahao.gov.cn/dpt/partduty.htm";
            string docPostData = string.Format("hospitalId={0}&departmentId={1}&dutyCode={2}&dutyDate={3}&isAjax=true",hospitalId,departmentId, dutyCode, dutyDate);

            var result = HttpHelper.POST(docListUrl, docPostData,cookieCollection);

            return result;
        }

        /// <summary>
        /// 挂号
        /// </summary>
        /// <param name="dutySourceId"></param>
        /// <param name="hospitalId"></param>
        /// <param name="departmentId"></param>
        /// <param name="doctorId"></param>
        /// <param name="patientId"></param>
        /// <param name="hospitalCardId"></param>
        /// <param name="medicareCardId"></param>
        /// <param name="reimbursementType"></param>
        /// <param name="smsVerifyCode"></param>
        /// <param name="childrenBirthday"></param>
        /// <param name="dlRegType"></param>
        /// <param name="dlMajorId"></param>
        /// <param name="mapDoctorId"></param>
        /// <returns></returns>
        public string HandDoc(string hospitalId,string departmentId,string doctorId,string dutyDate,string dutyCode,string patientId,string reimbursementType,string smsVerifyCode, IRequestCookieCollection cookieCollection, string hospitalCardId = "", string medicareCardId = "", string childrenBirthday="", string dlRegType="-1", string dlMajorId="",string mapDoctorId="")
        {

            //找到最新德dutySourceId

            var docListString = GetDocList(hospitalId, departmentId, dutyCode, dutyDate, cookieCollection);

            var docListResult = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(docListString, new { code=0,data= new[] { new { dutySourceId = "", remainAvailableNumber = 0, doctorId = "" } } });
            var dsId = string.Empty;
            if (docListResult.code == 200)
            {
                foreach (var doc in docListResult.data)
                {
                    if (doc.doctorId == doctorId)
                    {
                        dsId = doc.dutySourceId;
                        break;
                    }
                    //if (doc.doctorId == doctorId && doc.remainAvailableNumber > 0)
                    //{
                    //    dsId = doc.dutySourceId;
                    //    break;
                    //}
                }
                string docListUrl = "http://www.bjguahao.gov.cn/order/confirmV1.htm";
                string docPostData = string.Format("dutySourceId={0}&hospitalId={1}&departmentId={2}&doctorId={3}&patientId={4}&hospitalCardId={5}&medicareCardId={6}&reimbursementType={7}&smsVerifyCode={8}&childrenBirthday={9}&dlRegType={10}&dlMajorId={11}&mapDoctorId={12}&isAjax=true", dsId, hospitalId, departmentId, doctorId, patientId, hospitalCardId, medicareCardId, reimbursementType, smsVerifyCode, childrenBirthday, dlRegType, dlMajorId, mapDoctorId);
                var result = HttpHelper.POST(docListUrl, docPostData, cookieCollection);
                return result;
            }
            else {
                return docListString;
            }
        }
        
        
        
        /// <summary>
        /// 获取医院列表
        /// </summary>
        /// <returns></returns>
        public string GetHospitalList()
        {
            string url = "http://www.bjguahao.gov.cn/hp/qsearch.htm?areaId=-1&levelId=3&isAjax=true";
            var result = HttpHelper.GET(url);
            return result;
        }
        /// <summary>
        /// 获取医院科室列表
        /// </summary>
        /// <returns></returns>
        public string GetKeshiList(string hosId,string hosType)
        {
            //http://www.bjguahao.gov.cn/dpt/appoint/142-200039530.htm
            string url = string.Format("http://www.bjguahao.gov.cn/dpt/dpts.htm?hospitalId={0}&hospitalType={1}&isAjax=true", hosId, hosType);
            var result = HttpHelper.GET(url);
            return result;
        }

        private CookieContainer initCookieContainerByValue(string url,string cookieName,string cookieValue)
        {
            CookieContainer cc = new CookieContainer();
            Cookie ck = new Cookie(cookieName, cookieValue);
            cc.Add(new System.Uri(url), ck);
            return cc;
        }
    }
}
