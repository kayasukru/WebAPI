using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OgretimElemaniController : ControllerBase
    {
        public OgretimElemaniController()
        {
        }

        [HttpGet]
        public List<OgretimElemani> Get()
        {
            //Veriler el ile giriliyor
            List<Ders> dersler1 = new List<Ders>();
            dersler1.Add(new Ders { Id = 1, DersKodu = "I101", DersAdi = "Web Tasarımı", DersKontenjani = 20 });
            dersler1.Add(new Ders { Id = 1, DersKodu = "I102", DersAdi = "Internet Programlama", DersKontenjani = 15 });

            List<Ders> dersler2 = new List<Ders>();
            dersler2.Add(new Ders { Id = 1, DersKodu = "I103", DersAdi = "Nesne Yönelimli Programlama", DersKontenjani = 15 });

            List<OgretimElemani> ogretimElemanlari = new List<OgretimElemani>();
            ogretimElemanlari.Add(new OgretimElemani { Id = 0, SicilNo = "A123", Adi = "Şükrü", Soyadi = "Kaya", DogumTarihi = Convert.ToDateTime("01/03/1985"), VerdigiDersler = dersler1 });
            ogretimElemanlari.Add(new OgretimElemani { Id = 1, SicilNo = "A101", Adi = "Ali", Soyadi = "Çakır", DogumTarihi = Convert.ToDateTime("11/6/1980"), VerdigiDersler = dersler2 });

            return ogretimElemanlari;
        }
    }
}
