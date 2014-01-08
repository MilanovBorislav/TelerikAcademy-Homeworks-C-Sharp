using KingsValey.Context;
using KingsValey.ExternalServices.DropBox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingsValey.Api.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(IEnumerable<HttpPostedFileBase> files, string playerName)
        {
            try
            {
                KingsValeyContext db = new KingsValeyContext();

                if (files != null)
                {
                    foreach (var file in files)
                    {
                        /// TODO Secure the uploads, limit to image files only and check file size
                        var fileName = string.Format("{0}.jpg", playerName.ToLower());

                        var physicalPath = Path.Combine(Server.MapPath("~/Content/Avatars"), fileName);

                        file.SaveAs(physicalPath);

                        string avatarUrl = DropboxClient.UploadAvatar(fileName, physicalPath);

                        var player = db.Players.FirstOrDefault(p => p.Name.ToLower() == playerName.ToLower());

                        if (player != null)
                        {
                            player.Avatar = avatarUrl;
                        }

                        db.SaveChanges();
                    }
                }

                // Return an empty string to signify success
                return Content("");
            }
            catch (Exception ex)
            {
                return Content(ex.InnerException.ToString());
                ;
            }
        }

        //public ActionResult Remove(string[] fileNames)
        //{
        //    // The parameter of the Remove action must be called "fileNames"

        //    if (fileNames != null)
        //    {
        //        foreach (var fullName in fileNames)
        //        {
        //            var fileName = Path.GetFileName(fullName);
        //            var physicalPath = Path.Combine(Server.MapPath("~/App_Data"), fileName);

        //            // TODO: Verify user permissions

        //            if (System.IO.File.Exists(physicalPath))
        //            {
        //                // The files are not actually removed in this demo
        //                // System.IO.File.Delete(physicalPath);
        //            }
        //        }
        //    }

        //    // Return an empty string to signify success
        //    return Content("");
        //}
    }
}