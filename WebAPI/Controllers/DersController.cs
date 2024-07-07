using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DersController : ControllerBase
    {
        public DersController()
        {
        }

        [HttpGet]
        //Get isteği geldiğinde çalışan fonksiyon
        public List<Ders> Get()
        {
            //Veriler el ile ekleniyor
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { Id = 1, DersKodu = "I101", DersAdi = "Web Tasarımı", DersKontenjani = 20 });
            dersler.Add(new Ders { Id = 1, DersKodu = "I102", DersAdi = "Internet Programlama", DersKontenjani = 15 });
            dersler.Add(new Ders { Id = 1, DersKodu = "I103", DersAdi = "Nesne Yönelimli Programlama", DersKontenjani = 15 });

            //Veriler gönderiliyor
            return dersler;
        }
    }
}
