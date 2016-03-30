using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CKEditorLab.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ImageProcessor()
        {
            return View();
        }

        /// <summary>
        /// 重點:
        /// 1.
        /// </summary>
        /// <param name="upload"></param>
        /// <param name="CKEditorFuncNum"></param>
        /// <param name="CKEditor"></param>
        /// <param name="langCode"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {

            string url = Url.Content("~/AppData/" + upload.FileName);
            string script = $"<script>window.parent.CKEDITOR.tools.callFunction({CKEditorFuncNum}, '{url}','')</script>";
            upload.SaveAs(Server.MapPath("~/AppData/" + upload.FileName));
            return Content(script);


        }


    }
}