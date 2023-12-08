using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Xml.Serialization;
using Tuan1314.Models;
using System.Net;
namespace Tuan1314.Controllers
{
    public class TiGiaVCBController : Controller
    {
        //
        // GET: /TiGiaVCB/
        public ActionResult Index()
        {
            string siteContent = string.Empty;

            string url = "https://portal.vietcombank.com.vn/Usercontrols/TVPortal.TyGia/pXML.aspx";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            XmlSerializer serializer = new XmlSerializer(typeof(ExrateList));
            ExrateList exrateList = (ExrateList)serializer.Deserialize(responseStream);


            return View(exrateList.Exrate);
        }
	}
}