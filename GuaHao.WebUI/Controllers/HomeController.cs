using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuaHao.WebUI.Models;
using Microsoft.Extensions.Logging;
using GuaHao.Data;
using GuaHao.Common;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace GuaHao.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private RedisService _redisClient;
        private HandCodeHelper helper = null;

        public HomeController(ILogger<HomeController> logger,RedisService redisClient)
        {
            _logger = logger;
            _redisClient = redisClient;
            helper = new HandCodeHelper();
        }
        public IActionResult Index()
        {
            //_logger.LogInformation("LogInformation我记录了日志");
            //_logger.LogWarning("LogWarning我记录了日志");
            //_logger.LogTrace("LogTrace我记录了日志");
            //_logger.LogDebug("LogDebug我记录了日志");
            //_logger.LogError("LogError我记录了日志");
            //_redisClient.DB.StringSet("userName", "崔国亮",new TimeSpan(0,0,20));
            return View();
        }
        public IActionResult GuaHao()
        {
            return View();
        }
        /// <summary>
        /// 模版列表
        /// </summary>
        /// <returns></returns>
        public IActionResult TemplateList()
        {
            var uname = Request.Cookies["UINFO"];

            var result = _redisClient.DB.StringGet(uname + "_GHLIST");
            if (string.IsNullOrEmpty(result))
            {
                return Redirect("GuaHao");
            }
            ViewBag.templateData = result;
            return View();
        }

        public IActionResult About(ILogger<HomeController> logger)
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact(ILogger<HomeController> logger)
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy(ILogger<HomeController> logger)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ILogger<HomeController> logger)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        /// <summary>
        /// 登录接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Login()
        {
            var uname = Request.Form["uname"];
            var pwd = Request.Form["upwd"];
            var cookies = Request.Cookies;
             var result = helper.Login(uname, pwd, ref cookies);
         
            _logger.LogInformation("登录记录账号：{0}，密码：{1}", uname, pwd);
            if (result)
            {
                Response.Cookies.Append("UINFO", uname);
                foreach (var cookie in cookies)
                {
                    Response.Cookies.Append(cookie.Key, cookie.Value);
                }

                _redisClient.DB.StringSet(uname.ToString(), string.Format("{0},{1}", uname, pwd));
                return new JsonResult(new { code = 0, data = "OK" });
            }
            else
            {
                return new JsonResult(new { code = 1, data = "登录失败" });
            }

           
         
        }

        /// <summary>
        /// 医院列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult HostpitalList()
        {
            var result = helper.GetHospitalList();
            if (result.Length>0)
            {
                return new JsonResult(new { code = 0, data = result });
            }
            else
            {
                return new JsonResult(new { code = 1, data = "获取医院列表失败" });
            }

        }
        /// <summary>
        /// 科室列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CategoryList()
        {
            var hosId = Request.Form["hid"];
            var hosType=Request.Form["htype"];
            var result = helper.GetKeshiList(hosId, hosType);
            if (result.Length > 0)
            {
                return new JsonResult(new { code = 0, data = result });
            }
            else
            {
                return new JsonResult(new { code = 1, data = "获取科室列表失败" });
            }

        }
        /// <summary>
        /// 医生列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DoctorList()
        {
            var hosId = Request.Form["hid"];
            var departId = Request.Form["did"];
            var dutyCode = Request.Form["sxw"];
            var dutyDate = Request.Form["date"];
            var cookieValue = Request.Cookies["GHSID"];

            var result = helper.GetDocList(hosId,departId,dutyCode,dutyDate, Request.Cookies);



            var resultObj= JsonConvert.DeserializeAnonymousType(result, new { data = new List<DocInfo>(), code = "",msg="" });
            if (resultObj.code == "200")
            {
                return new JsonResult(new { code = 0, data = resultObj.data });
            }
            else
            {
                return new JsonResult(new { code = 1, data = resultObj.msg });
            }
            

        }

        /// <summary>
        /// 保存列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult SaveGuaHaoTPL()
        {
            var uname = Request.Cookies["UINFO"].Split(',')[0];
            var name = Request.Form["name"];
            var para = Request.Form["para"];
            
            var result= _redisClient.DB.StringSet(uname + "_GHLIST", name + ","+ para);

            if (result)
            {
                return new JsonResult(new { code = 0, data = "OK"});
            }
            else
            {
                return new JsonResult(new { code = 1, data ="保存模版失败" });
            }


        }

        /// <summary>
        /// 保存验证码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult SaveGuaHao()
        {
            var uname = Request.Cookies["UINFO"].Split(',')[0];
            var checkCode = Request.Form["code"].ToString();

            var result = _redisClient.DB.StringSet(uname + "_CODE", checkCode,new TimeSpan(0,5,0));

            if (result)
            {
                return new JsonResult(new { code = 0, data = "OK" });
            }
            else
            {
                return new JsonResult(new { code = 1, data = "保存验证码失败" });
            }


        }

        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetCheckCode()
        {
            var cookieValue = Request.Cookies["GHSID"];
            var result = helper.SendCheckCode(Request.Cookies);

            var resultObj = JsonConvert.DeserializeAnonymousType(result,new { code=0,msg="" });
            _logger.LogInformation("发送验证码返回：{0}",result);
            return new JsonResult(resultObj);
        }

        /// <summary>
        /// 挂号挂号
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GoGuaHao()
        {
            
            var cookieValue = Request.Cookies["GHSID"];
            var uname = Request.Cookies["UINFO"].Split(',')[0];
            

            var userOrderInfo = _redisClient.DB.StringGet(uname+"_GHLIST");
            var checkCode = _redisClient.DB.StringGet(uname + "_CODE");

            var duty= userOrderInfo.ToString().Split(',')[0];
            var para= userOrderInfo.ToString().Split(',')[1];
            var dutyArr = duty.Split('/');
            var paraArr = para.Split('-');
           // var para = docObj.dutySourceId + '-' + docObj.hospitalId + '-' + docObj.departmentId + '-' + docObj.doctorId + '-' + that.patientId + '-' + that.bxId+ sxw;
            var result = helper.HandDoc(paraArr[1], paraArr[2], paraArr[3], dutyArr[2],paraArr[6], paraArr[4], paraArr[5],checkCode,Request.Cookies);
            _logger.LogInformation("挂号返回：{0}", result);
            var resultObj = JsonConvert.DeserializeAnonymousType(result,new { code=0,msg=""});
            //if (result)
            //{
            //    return new JsonResult(new { code = 0, data = "OK" });
            //}
            //else
            //{
            //    return new JsonResult(new { code = 1, data = "获取验证码失败" });
            //}
            return new JsonResult(resultObj);

        }

    }
}
