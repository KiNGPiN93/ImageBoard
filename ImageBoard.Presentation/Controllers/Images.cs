using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageBoard.Presentation.Controllers
{
    public class HomeController
    {
        [HttpPost]
        public bool UploadImage(HttpPostedFileBase file)
        {


            return true;
        }
    }
}