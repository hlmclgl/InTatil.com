using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelBlogProject.Models.Classes;


namespace TravelBlogProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGetir",b);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Aciklama = b.Aciklama;
            blg.Tarih = b.Tarih;
            blg.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = c.Yorumlars.Find(id);
            return View("YorumGetir", yrm);
        }
        public ActionResult YorumGuncelle(Yorumlar yrm)
        {
            var y = c.Yorumlars.Find(yrm.ID);
            y.KullaniciAdi = yrm.KullaniciAdi;
            y.Mail = yrm.Mail;
            y.Yorum = yrm.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult Mesajlar()
        {
            var mesajlar = c.Iletisims.ToList();
            return View(mesajlar);
        }
        public ActionResult Hakkımızda()
        {
            var ab = c.Hakkımızdas.ToList();
            return View(ab);
        }
        public ActionResult GetAbout(int id)
        {
            var hkm = c.Hakkımızdas.Find(id);
            return View("GetAbout", hkm);
        }
        public ActionResult UpdateAbout(Hakkımızda hkm)
        {
            var ab = c.Hakkımızdas.Find(hkm.ID);
            ab.Aciklama = hkm.Aciklama;
            ab.FotoUrl = hkm.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Hakkımızda");
        }
    }
}