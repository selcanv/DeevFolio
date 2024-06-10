using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeevFolio.Controllers
{
    public class CvDownloadController : Controller
    {
   
        public ActionResult DownloadCV()
        {
            // PDF dosyasının yolu
            string pdfPath = Server.MapPath("~/Templates/cv.pdf");

            if (System.IO.File.Exists(pdfPath))
            {
                // Dosya bulunursa, indirme işlemi
                byte[] pdfData = System.IO.File.ReadAllBytes(pdfPath);
                return File(pdfData, "application/pdf", "cv.pdf");
            }
            else
            {
                // Dosya bulunamazsa, hata sayfasına yönlendirme
                return RedirectToAction("Error");
            }
        }

        public ActionResult Error()
        {
            // Hata sayfası
            return View();
        }

    }
}



//System.IO: Dosya işlemleri yapmak için gerekli olan System.IO namespace'ini kullanırız.

//System.Web.Mvc: ASP.NET MVC çerçevesinin temel namespace'ini içerir. Controller sınıfı buradan gelir.

//ActionResult: Bir action metodunun döndürebileceği sonuç türlerinden biridir. Bu, MVC'nin istemciye yanıt olarak gönderebileceği herhangi bir sonucu temsil eder.

//DownloadCV(): Controller sınıfında oluşturduğumuz action metodunun adıdır.

//Server.MapPath("~/Templates/cv.pdf"): Server nesnesinin MapPath metodu, sunucunun fiziksel dosya yolu ile belirtilen sanal yolu eşleştirir. Bu durumda, cv.pdf dosyasının tam dosya yolunu elde ederiz.

//System.IO.File.Exists(pdfPath): Belirtilen dosyanın var olup olmadığını kontrol eder. Eğer dosya varsa, bu blok çalışır.

//System.IO.File.ReadAllBytes(pdfPath): Belirtilen dosyayı bir byte dizisine okur.

//File(pdfData, "application/pdf", "cv.pdf"): File metodu, bir dosyayı indirme işlemi için döndürülmesi gereken bir ActionResult oluşturur. İlk parametre dosyanın byte dizisidir, ikinci parametre dosyanın MIME türüdür ve üçüncü parametre dosyanın adıdır.

//RedirectToAction("Error"): Eğer dosya bulunamazsa, Error action metoduna yönlendirilir.

//Error(): Eğer dosya bulunamazsa veya başka bir hata oluşursa, kullanıcıya gösterilecek hata sayfasını temsil eden bir action metodu.