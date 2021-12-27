using DemoASPDotNetFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoASPDotNetFramework.Controllers
{
    public class MonHocController : Controller
    {
        PRN292_Demo4Entities db = new PRN292_Demo4Entities();
        // GET: MonHoc
        public ActionResult SetDataInDatabase(MonHoc model)
        {
            MonHoc tbl = new MonHoc();
            tbl.IDMH = model.IDMH;
            tbl.Ma_HK = model.Ma_HK;
            tbl.TenMH = model.TenMH;
            tbl.SoTC = model.SoTC;
            tbl.LyThuyet = model.LyThuyet;
            tbl.ThucHanh = model.ThucHanh;
            db.MonHocs.Add(tbl);
            db.SaveChanges();
            return View();
        }
    }
}